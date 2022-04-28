﻿using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppTest
{
    class WebserviceTest
    {
        private string ConnectieDB => ConfigurationManager.AppSettings["connectieString"];

        public List<WebService> GetWebServiceData()
        {
            List<WebService> webServiceDatas = new List<WebService>();

            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {

                cmd.CommandText = "SELECT * FROM WebService";
                cmd.CommandType = CommandType.Text;
                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    webServiceDatas.Add(new WebService((int)dr[0], dr[1].ToString(), (bool)dr[2]));
                }
            }
            return webServiceDatas;
        }

        public List<WebService> GetWebServicesByWebserviceName(string name)
        {
            List<WebService> webServiceDatas = new List<WebService>();

            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM WebService where name like '%" + name + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    webServiceDatas.Add(new WebService((int)dr[0], dr[1].ToString(), (bool)dr[2]));
                }
            }
            return webServiceDatas;
        }

        public void AddWebService(string name, bool soap)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "INSERT INTO [dbo].[Webservice] ([Name], [SOAP]) VALUES (@Name, @Soap)";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Soap", soap);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateWebService(int id, string name, bool soap)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "UPDATE Webservice SET Name = @Name, Soap = @Soap where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Soap", soap);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteWebService(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "DELETE FROM Webservice where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
