using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppTest
{
    class UrlTest
    {
        private List<UrlData> _urlDatasByForeignKeyWebservice = new List<UrlData>();
        private List<UrlData> _urlDatasByForeignKeyKlant = new List<UrlData>();

        public UrlTest()
        {
            //GetUrls();
        }

        private string ConnectieDB => ConfigurationManager.AppSettings["connectieString"];

        public List<UrlData> GetUrlData()
        {
            List<UrlData> urlDatas = new List<UrlData>();

            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {

                cmd.CommandText = "SELECT * FROM Url";
                cmd.CommandType = CommandType.Text;
                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    urlDatas.Add(new UrlData((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3], (int)dr[4], (int)dr[5]));
                }
            }
            return urlDatas;
        }

        public List<UrlData> GetUrlDataByUrlName(string name)
        {
            List<UrlData> urlDatas = new List<UrlData>();

            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {

                cmd.CommandText = "SELECT * FROM Url where name like '%" + name + "%'";
                cmd.CommandType = CommandType.Text;
                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    urlDatas.Add(new UrlData((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3], (int)dr[4], (int)dr[5]));
                }
            }
            return urlDatas;
        }

        public void AddUrl(string url, int webService, int klant, int http, string securityId = "")
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "INSERT INTO [dbo].[Url] ([Name],[SecurityID],[Webservice],[Klant],[Http]) VALUES (@Url, @SecurityID, @WebService, @Klant, @Http)";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Url", url);
                    cmd.Parameters.AddWithValue("@SecurityID", securityId);
                    cmd.Parameters.AddWithValue("@WebService", webService);
                    cmd.Parameters.AddWithValue("@Klant", klant);
                    cmd.Parameters.AddWithValue("@Http", http);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateUrl(int id, string url, string securityId, int webService, int klant, int http)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "UPDATE Url SET Name = @Url, SecurityID = @SecurityID, WebService = @WebService, Klant = @Klant, Http = @Http " + "where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Url", url);
                    cmd.Parameters.AddWithValue("@SecurityID", securityId);
                    cmd.Parameters.AddWithValue("@WebService", webService);
                    cmd.Parameters.AddWithValue("@Klant", klant);
                    cmd.Parameters.AddWithValue("@Http", http);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteUrl(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "DELETE FROM Url where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<UrlData> GetAllUrlsByForeignKeyWebservice(int webService)
        {
            _urlDatasByForeignKeyWebservice.Clear();
            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                cmd.CommandText = "SELECT * FROM Url where Webservice = " + webService;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    _urlDatasByForeignKeyWebservice.Add(new UrlData((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3], (int)dr[4], (int)dr[5]));
                }
            }
            return _urlDatasByForeignKeyWebservice;
        }

        public List<UrlData> GetAllUrlsByForeignKeyKlant(int klant)
        {
            _urlDatasByForeignKeyKlant.Clear();
            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                cmd.CommandText = "SELECT * FROM Url where Klant = " + klant;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    _urlDatasByForeignKeyKlant.Add(new UrlData((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3], (int)dr[4], (int)dr[5]));
                }
            }
            return _urlDatasByForeignKeyKlant;
        }
    }
}
