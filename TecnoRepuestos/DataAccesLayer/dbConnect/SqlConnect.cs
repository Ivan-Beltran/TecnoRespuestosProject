using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.dbConnect
{
    public class SqlConnect
    {
        private readonly string _connectionString;

        public SqlConnect()
        {
            _connectionString= "Data Source=ivan;Initial Catalog=TecnoRepuestosDB;Integrated Security=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
