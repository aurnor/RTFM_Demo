
using System.Data.SqlClient;

namespace WebApp1.Service
{
    public class ConstosoDBService
    {
        public void ExecuteGenericRequest(string customerName)
        {
            string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            string commandText = "SELECT * FROM Customers WHERE CustomerName = '" + customerName + "';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);

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