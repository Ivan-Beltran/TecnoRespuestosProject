using CommonLayer.Entities;
using DataAccesLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.CustomersRepo
{
    public class CustomersRepository
    {
        private SqlConnect _dbConnection;

        public CustomersRepository(SqlConnect _connection)
        {
               _dbConnection = _connection;
        }

        public DataTable GetCustomers()
        {
            DataTable dt = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetCustomers", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public void InsertCustomer(Customer c)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("InsertCustomer", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", c.Name);
                    cmd.Parameters.AddWithValue("@LastName", c.LastName);
                    cmd.Parameters.AddWithValue("@Address", c.Address);
                    cmd.Parameters.AddWithValue("@DUI", c.DUI);
                    cmd.Parameters.AddWithValue("@Email", c.Email);
                    cmd.Parameters.AddWithValue("@Telephone", c.Telephone);

                    // NRC opcional
                    if (string.IsNullOrWhiteSpace(c.NRC))
                        cmd.Parameters.AddWithValue("@NRC", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NRC", c.NRC);

                   

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
