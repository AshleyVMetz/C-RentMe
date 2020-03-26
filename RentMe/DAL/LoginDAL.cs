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
        public Boolean? EmployeeLogin(String username, String password)
        {

            string selectStatement =
                @"SELECT *
                FROM dbo.Employees
                WHERE Username = @username and Password = @password";

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
                            bool admin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                            return admin;
                        }
                    }
                }
            }
            return null;
        }

    }
}
