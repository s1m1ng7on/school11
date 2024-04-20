using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineStoreProject
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public void Command(SqlCommand command)
        {
            using (SqlData)
        }
    }
}
