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
        public UrlTest()
        {

        }

        private string Url { get; set; }
        private string WebserviceVersie { get; set; }
        private bool KraanDllCorrect { get; set; }
        private bool KraanIniCorrect { get; set; }
        private bool KraanDatabase { get; set; }
        private bool SslCorrect { get; set; }

        public string connectieDB()
        {
            return (@"data source=(localdb)\MSSQLLocalDB; Initial Catalog=Urls;Integrated Security=True;");
        }
        public ArrayList GetUrls()
        {

            DataTable dt = new DataTable();
            int rows_returned;

            using (SqlConnection connection = new SqlConnection(connectieDB()))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {

                cmd.CommandText = "SELECT * FROM Url";
                cmd.CommandType = CommandType.Text;
                connection.Open();
                rows_returned = sda.Fill(dt);
                connection.Close();

                ArrayList arlist = new ArrayList();
                foreach (DataRow dr in dt.Rows)
                {


                    // get each rows columns as a string (casting null into the nil (empty) string
                    string[] values = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; ++i)
                    {
                        values[i] = (dr[i].ToString()) ?? ""; // we'll treat nulls as the nil string for the nonce
                    }

                    // construct the string to be dumped, quoting each value and doubling any embedded quotes.
                    string data = string.Join(";", values.Select(s => "\"" + s.Replace("\"", "\"\"") + "\""));
                    arlist.Add(values);
                }
                return arlist;
            }
        }

        public void AddUrl(string url, string securityId)
        {
            using (SqlConnection connection = new SqlConnection(connectieDB()))
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
            using (SqlConnection connection = new SqlConnection(connectieDB()))
            {
                connection.Open();
                var sql = "UPDATE Url SET Name = @Url, SecurityID = @SecurityID " +  "where id =" + id;
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
            Console.WriteLine(id);
            using (SqlConnection connection = new SqlConnection(connectieDB()))
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
