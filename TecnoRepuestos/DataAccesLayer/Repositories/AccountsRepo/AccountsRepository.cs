using DataAccesLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.AccountsRepo
{
    public class AccountsRepository
    {
        private SqlConnect _dbConnection;

        public AccountsRepository(SqlConnect _connection)
        {
            _dbConnection = _connection;
        }

        public DataTable GetAccountsPayble()
        {
            DataTable dt = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetPendingAccounts", connection))
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

        public DataTable GetPaidAccounts()
        {
            DataTable dt = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetPaidAccounts", connection))
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

        public void PayAccount(int accountId, decimal amount)
        {
            try
            {
                using (var connection = _dbConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_PayAccount", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@AccountId", accountId);
                        cmd.Parameters.AddWithValue("@Amount", amount);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Reenvía el mensaje que viene desde THROW en el SP
                throw new Exception(ex.Message);
            }
        }

    }
}
