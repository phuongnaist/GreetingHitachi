using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingHitachi.DAO
{
    public class DataProvider
    {
        private string connectionString = "Data Source=DESKTOP-CQEKB9O\\TRUNGDUONGPC;Initial Catalog=GreetingHitachi;Integrated Security=True";

        //private string connectionString = "Data Source=LAPTOP-HCF2RCQ6;Initial Catalog=GreetingHitachi;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }

            return dataTable;
        }
    }
}
