using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace OnlineStoreProject
{
    public class DatabaseHelper
    {
        private SqlConnection connection;

        public DatabaseHelper(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            Open();
        }

        public SqlDataReader ExecuteReader(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteReader();
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public void Open()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
