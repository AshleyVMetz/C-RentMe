using RentMe.Model;
using System;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class is the DAL for login.
    /// </summary>
    public class LoginDAL
    {
        /// <summary>
        /// This class checks the entered data against the employee database.
        /// </summary>
        /// <param name="username">String username entered</param>
        /// <param name="password">String password entered</param>
        /// <returns></returns>
        public LoginResult EmployeeLogin(String username, String password)
        {

            string selectStatement =
                @"SELECT *
                FROM dbo.Employees
                WHERE Username = @username and Password = @password COLLATE Latin1_General_CS_AS and IsActive = 1";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    selectCommand.Parameters.AddWithValue("@password", password);


                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var loginResult = new LoginResult();
                            loginResult.IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                            loginResult.FName = reader["FName"].ToString();
                            return loginResult;
                        }
                    }
                }
            }
            return null;
        }

    }
}
