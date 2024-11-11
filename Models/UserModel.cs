using System.Data.SqlClient;

namespace CLDVSem2Part3.Models
{
    public class UserModel
    {

        public static string con_string = "Server=tcp:st10355869.database.windows.net,1433;Initial Catalog=st10355869cldv;Persist Security Info=False;User ID=st10355869;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;;";
        public static SqlConnection con = new SqlConnection(con_string);



        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }





        public int insert_User(UserModel m)
        {
            try
            {
                string sql = "INSERT INTO Customer (FirstName, SecondName, Email) VALUES (@FirstName, @SecondName, @Email)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", m.FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", m.SecondName);
                    cmd.Parameters.AddWithValue("@Email", m.Email);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}