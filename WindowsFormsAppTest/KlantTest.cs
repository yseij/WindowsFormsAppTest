using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppTest
{
    class KlantTest
    {
        public KlantTest()
        {

        }

        private string ConnectieDB => ConfigurationManager.AppSettings["connectieString"];


        public List<Klant> GetKlantData()
        {
            List<Klant> klantDatas = new List<Klant>();

            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {

                cmd.CommandText = "SELECT * FROM Klant";
                cmd.CommandType = CommandType.Text;
                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    klantDatas.Add(new Klant((Guid)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
                }
            }

            return klantDatas;
        }

        public List<Klant> GetKlantDataByKlantName(string name)
        {
            List<Klant> klantDatas = new List<Klant>();

            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Klant where name like '%" + name + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    klantDatas.Add(new Klant((Guid)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
                }
            }

            return klantDatas;
        }

        public void AddKlant(string name, string basisUrl1, string basisUrl2)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "INSERT INTO [dbo].[Klant] ([Name], [BasisUrl1], [BasisUrl2]) VALUES (@Name, @BasisUrl1, @BasisUrl2)";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@BasisUrl1", basisUrl1);
                    cmd.Parameters.AddWithValue("@BasisUrl2", basisUrl2);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateKlant(int id, string name, string basisUrl1, string basisUrl2)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "UPDATE Klant SET Name = @Name, BasisUrl1 = @BasisUrl1, BasisUrl2 = @BasisUrl2" + "where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@BasisUrl1", basisUrl1);
                    cmd.Parameters.AddWithValue("@BasisUrl2", basisUrl2);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteKlant(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "DELETE FROM Klant where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
