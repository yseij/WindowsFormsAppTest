using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest
{
    class UrlTest
    {
        private List<UrlData> _urlDatas = new List<UrlData>();
        public UrlTest()
        {
            GetUrls();
        }

        private string ConnectieDB
        {
            get { return (@"data source=(localdb)\MSSQLLocalDB; Initial Catalog=Urls;Integrated Security=True;"); }
        }

        public List<UrlData> GetUrlDatas(bool reload = false)
        {
            if (reload)
            {
                _urlDatas.Clear();
                GetUrls();
            }

            return _urlDatas;
        }
        public void GetUrls()
        {

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
                    _urlDatas.Add(new UrlData((int)dr[0], dr[1].ToString(), dr[2].ToString()));
                }
            }
        }

        public void AddUrl(string url, string securityId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "INSERT INTO [dbo].[Url] ([Name],[SecurityID]) VALUES (@Url, @SecurityID)";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Url", url);
                    cmd.Parameters.AddWithValue("@SecurityID", securityId);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateUrl(int id, string url, string securityId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "UPDATE Url SET Name = @Url, SecurityID = @SecurityID " + "where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Url", url);
                    cmd.Parameters.AddWithValue("@SecurityID", securityId);

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
                var sql = "DELETE FROM url where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
