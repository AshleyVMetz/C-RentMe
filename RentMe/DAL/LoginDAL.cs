using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    public class LoginDAL
    {
        public Boolean? EmployeeLogin(String username, String password)
        {
          
            string selectStatement =
                @"SELECT *
                FROM dbo.Employees
                WHERE Username = @username and Password = @password" ;

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
