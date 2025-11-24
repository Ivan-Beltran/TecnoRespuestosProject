using CommonLayer.Entities;
using DataAccesLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.SuppliersRepo
{
    public class SuppliersRepository

    {
        private SqlConnect _dbConnection;

        public SuppliersRepository(SqlConnect _connection)
        {
            _dbConnection = _connection;
        }

        public void Insert(Supplier s)
        {
            using (var connection = _dbConnection.GetConnection())
            {

                using (SqlCommand cmd = new SqlCommand("sp_InsertSupplier", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SupplierName", s.SupplierName);
                    cmd.Parameters.AddWithValue("@ContacName", s.ContacName);
                    cmd.Parameters.AddWithValue("@NIT", s.NIT);

                    if (string.IsNullOrWhiteSpace(s.NRC))
                        cmd.Parameters.AddWithValue("@NRC", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NRC", s.NRC);

                    cmd.Parameters.AddWithValue("@Telephone", s.Telephone);
                    cmd.Parameters.AddWithValue("@Email", s.Email);
                    cmd.Parameters.AddWithValue("@Address", s.Address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetSuppliers()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetSuppliers", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
            }
        }

    }
}
