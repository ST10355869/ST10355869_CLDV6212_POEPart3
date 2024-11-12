using System.Data.SqlClient;

namespace CLDVSem2Part3.Models
{
    public class OrderModel
    {

        public static string con_string = "Server=tcp:st10355869.database.windows.net,1433;Initial Catalog=st10355869cldv;Persist Security Info=False;User ID=st10355869;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;;";
        public static SqlConnection con = new SqlConnection(con_string);

        public int OrderID { get; set; }

        public string Description { get; set; }

        public int insert_order(OrderModel m)
        {
            using (SqlConnection con = new SqlConnection(con_string))
            {
                try
                {
                    string sql = "INSERT INTO Orders (Description) VALUES (@Description)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Description", m.Description);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }




    }
}
