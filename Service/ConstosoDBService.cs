﻿using System.Data;
using System.Data.SqlClient;

namespace WebApp1.Service
{
    public class ConstosoDBService
    {

        public DataSet GetDataSetByCategory(string inpString)
        {
            string connectionString = "Server=tcp:test-fw-sqlmi.20909H2H.database.windows.net,1433;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication=\"Active Directory Password\";";

            // BAD: the category might have SQL special characters in it
            using (var connection = new SqlConnection(connectionString))
            {
                var query1 = "SELECT ITEM,PRICE,LABEL FROM PRODUCT WHERE ITEM_CATEGORY='"
                  + inpString + "' ORDER BY PRICE";
                var adapter = new SqlDataAdapter(query1, connection);
                var result = new DataSet();
                adapter.Fill(result);
                return result;
            }
        }
    }
}