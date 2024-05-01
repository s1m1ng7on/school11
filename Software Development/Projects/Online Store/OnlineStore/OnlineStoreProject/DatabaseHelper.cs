using System.Data;
using System.Data.SqlClient;

namespace OnlineStoreProject
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable ExecuteReader(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                return dataTable;
            }
        }
    }
}
