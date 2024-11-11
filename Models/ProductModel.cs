using System.Data.SqlClient;

namespace CLDVSem2Part3.Models
{
    public class ProductModel
    {
        public static string con_string = "Server=tcp:st10355869.database.windows.net,1433;Initial Catalog=st10355869cldv;Persist Security Info=False;User ID=st10355869;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;;";
        public static SqlConnection con = new SqlConnection(con_string);


        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

       



        public int insert_product(ProductModel p)
        {

            try
            {
                string sql = "INSERT INTO Product (Name, Price) VALUES (@Name, @Price)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Price", p.Price);
                
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }


       
    }
}
