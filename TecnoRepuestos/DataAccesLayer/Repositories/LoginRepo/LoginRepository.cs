using CommonLayer.Entities;
using DataAccesLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.LoginRepo
{
    public class LoginRepository
    {
        private SqlConnect _dbConnection;

        public LoginRepository(SqlConnect _connection)
        {
            _dbConnection=_connection;
        }

        public User Login(string username, string password)
        {
            User user = null;

            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                using (SqlCommand command = new SqlCommand("LoginUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);


                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("Id")),
                                UserName = dr["UserName"].ToString(),
                                Name = dr["FullName"].ToString(),
                                RoleId = Convert.ToInt32(dr["RoleId"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al iniciar sesión: " + ex.Message);
            }

            return user;
        }

    }
}
