
using System.Data.SqlClient;

namespace WebApp1.Service
{
    public class ConstosoDBService
    {
        public void LogUserExist(string customerName)
        {

            using (SqlConnection connection = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE CustomerName = '" + customerName + "';", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["CustomerName"].ToString());
                }
            }
        }
    }
}