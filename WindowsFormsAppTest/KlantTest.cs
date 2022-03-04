using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppTest
{
    class KlantTest
    {
        private List<KlantData> _klantDatas = new List<KlantData>();

        public KlantTest()
        {
            GetKlants();
        }

        private string ConnectieDB => ConfigurationManager.AppSettings["connectieString"];

        public List<KlantData> GetKlantDatas(bool reload = false)
        {
            if (reload)
            {
                _klantDatas.Clear();
                GetKlants();
            }

            return _klantDatas;
        }

        public void GetKlants()
        {

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
                    _klantDatas.Add(new KlantData((int)dr[0], dr[1].ToString()));
                }
            }
        }

        public void AddKlant(string name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "INSERT INTO [dbo].[Klant] ([Name]) VALUES (@Name)";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateKlant(int id, string name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectieDB))
            {
                connection.Open();
                var sql = "UPDATE Klant SET Name = @Name " + "where id =" + id;
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);

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
