using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
	class CreateDatabase
	{
		private SqlConnection myConn = new SqlConnection(@"data source=" + Properties.Settings.Default.ServerNaam + ";Integrated Security=True;database=master");
		private bool _succesvol = true;
		public CreateDatabase()
		{

		}

		private string _createDb = "CREATE DATABASE KraanTestTool ON PRIMARY " +
								   "(NAME = KraanTestTool_Data, " +
								   "FILENAME = '" + Properties.Settings.Default.SaveDbPlace + "\\KraanTestTool.mdf', " +
								   "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
								   "LOG ON (NAME = KraanTestTool_Log, " +
								   "FILENAME = '" + Properties.Settings.Default.SaveDbPlace + "\\KraanTestTool.ldf', " +
								   "SIZE = 1MB, " +
								   "MAXSIZE = 5MB, " +
								   "FILEGROWTH = 10%)";

		private string _createTableHttp = "USE [KraanTestTool] " +
										  "CREATE TABLE Http " +
										  "(Id INT NOT NULL	IDENTITY(1,1) PRIMARY KEY, " +
										  "Name VARCHAR(Max) NOT NULL, );";

		private string _insertDataHttp = "USE [KraanTestTool] " +
										 "INSERT INTO Http " +
										 "(Name) VALUES " +
										 "('https://wsdev.kraan.com/')," +
										 "('https://ws.kraan.com:444/')," +
										 "('https://wsdev.kraan.com:1234/')";

		private string _createTableKlant = "USE [KraanTestTool] " +
										  "CREATE TABLE Klant " +
										  "(Id INT NOT NULL	IDENTITY(1,1) PRIMARY KEY, " +
										  "Name VARCHAR(Max) NOT NULL, );";

		private string _insertDataKlant = "USE [KraanTestTool] " +
										  "INSERT INTO Klant " +
										  "(Name) VALUES " +
										  "('Klant 1')," +
										  "('Klant 2')," +
										  "('Klant 3')," +
										  "('Klant 4')," +
										  "('Klant 5')";

		private string _createTableWebservice = "USE [KraanTestTool] " +
												"CREATE TABLE WebService " +
												"(Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, " +
												"Name VARCHAR(Max) NOT NULL, " +
												"Soap BIT NOT NULL, );";

		private string _insertDataWebservice = "USE [KraanTestTool] " +
								  "INSERT INTO Webservice " +
								  "(Name, Soap) VALUES " +
								  "('KraanHomeDNA', '0')," +
								  "('KraanHomeDNARelease', '0')," +
								  "('Kraan2Webservices', '1')," +
								  "('KraanESB', '0')," +
								  "('KraanHandheld', '0')," +
								  "('KraanMobileWebservice', '0')," +
								  "('KraanSalesService', '1')," +
								  "('release', '1')," +
								  "('KraanWerkbonWebservice', '1')";

		private string _createTableUrl = "USE [KraanTestTool] " +
										 "CREATE TABLE Url " +
										 "(Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, " +
										 "Name VARCHAR(Max) NOT NULL, " +

										 "SecurityId  VARCHAR(Max),  " +
										 "Webservice INT FOREIGN KEY REFERENCES WebService(Id),  " +
										 "Klant	INT	FOREIGN KEY REFERENCES Klant(Id), " +
										 "Http INT FOREIGN KEY REFERENCES Http(Id) );";

		private string _insertDataUrl = "USE [KraanTestTool] " +
						  "INSERT INTO Url " +
						  "(Name,SecurityId,Webservice,Klant,Http) VALUES " +
						  "('HomeDna.svc/GetWebserviceVersion','', '1', '1', '2'), " +
						  "('HomeDna.svc/GetListKrnExt', '/099793AF-C758-4E53-B27E-6BE923B114BF', '2', '1', '2')," +
						  "('HomeDna.svc/GetProject', '/099793AF-C758-4E53-B27E-6BE923B114BF/0/WEL10', '2', '2', '2')," +
						  "('HomeDna.svc/GetProject', '/099793AF-C758-4E53-B27E-6BE923B114BF/00E4A20A-4403-7C8E-6DF6-91214579ADB4/0', '2', '3', '2')," +
						  "('AuthService.svc', '', '3', '3', '2')," +
						  "('CrmService.svc', '', '3', '3', '2')," +
						  "('WorkflowService.svc', '', '3', '3', '2')," +
						  "('UrenService.svc', '', '3', '4', '2')," +
						  "('MaterieelService.svc', '', '3', '4', '2')," +
						  "('Webservice.svc', '', '9', '4', '2')," +
						  "('HandheldService.svc/rest/GetVersion', '', '5', '5', '3')," +
						  "('HomeDna.svc/GetDocument', '', '2', '5', '2')," +
						  "('MessageServiceSoap.svc', '', '7', '5', '2')," +
						  "('MessageServiceSoap31.svc', '', '8', '5', '3')";

		private string _deleteDb = "USE [master] " +
								   "ALTER DATABASE KraanTestTool " +
								   "SET SINGLE_USER " +
								   "WITH ROLLBACK IMMEDIATE; " +
								   "DROP DATABASE KraanTestTool;";


		public bool MakeDb(bool resetDb)
		{
			bool IsDbExist = false;

			if (!resetDb)
			{
				IsDbExist = CheckIfDbExist();
			}
			else
			{
				SqlCommand myCommand = new SqlCommand(_deleteDb, myConn);
				myConn.Open();
				myCommand.ExecuteNonQuery();
				myConn.Close();
			}
			
			if (!IsDbExist)
			{
				SqlCommand myCommand = new SqlCommand(_createDb, myConn);
				try
				{
					myConn.Open();
					myCommand.ExecuteNonQuery();
					MessageBox.Show("DataBase KraanTestTool succesvol aangemaakt", "TestTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
					FillDb();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), "KraanTestTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				finally
				{
					if (myConn.State == ConnectionState.Open)
					{
						myConn.Close();
					}
				}
				if (_succesvol)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return true;
			}
			
		}

		private bool CheckIfDbExist()
		{
			bool dbExist = false;

			using (var command = new SqlCommand($"SELECT db_id('KraanTestTool')", myConn))
			{
				myConn.Open();
				dbExist = (command.ExecuteScalar() != DBNull.Value);
				myConn.Close();
			}
			return dbExist;
		}

		private void FillDb()
		{
			HttpTable();
			KlantTable();
			WebserviceTable();
			UrlTable();
			if (_succesvol)
			{
				MessageBox.Show("Tabellen zijn succesvol toegevoegd", "TestTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}	
		}

		private void HttpTable()
		{
			SqlCommand myCommandCreate = new SqlCommand(_createTableHttp, myConn);
			SqlCommand myCommandInsert = new SqlCommand(_insertDataHttp, myConn);
			try
			{
				myCommandCreate.ExecuteNonQuery();
				myCommandInsert.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				_succesvol = false;
				MessageBox.Show(ex.ToString(), "TestTool - Http Tabel", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void KlantTable()
		{
			SqlCommand myCommandCreate = new SqlCommand(_createTableKlant, myConn);
			SqlCommand myCommandInsert = new SqlCommand(_insertDataKlant, myConn);
			try
			{
				myCommandCreate.ExecuteNonQuery();
				myCommandInsert.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "TestTool - Klant tabel", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void WebserviceTable()
		{
			SqlCommand myCommandCreate = new SqlCommand(_createTableWebservice, myConn);
			SqlCommand myCommandInsert = new SqlCommand(_insertDataWebservice, myConn);
			try
			{
				myCommandCreate.ExecuteNonQuery();
				myCommandInsert.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				_succesvol = false;
				MessageBox.Show(ex.ToString(), "TestTool - Webservice tabel", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void UrlTable()
		{
			SqlCommand myCommandCreate = new SqlCommand(_createTableUrl, myConn);
			SqlCommand myCommandInsert = new SqlCommand(_insertDataUrl, myConn);
			try
			{

				myCommandCreate.ExecuteNonQuery();
				myCommandInsert.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				_succesvol = false;
				MessageBox.Show(ex.ToString(), "TestTool - Url tabel", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
