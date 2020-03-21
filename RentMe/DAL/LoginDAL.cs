using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    class LoginDAL
    {
        public void GetEmployeeLogin()
        {
            string selectStatement =
                "SELECT * " +
                "FROM dbo.Employees " +
                "Where Username =  @username and Password = @password" ;


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username.Text);
                    selectCommand.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Registration registration = new Registration();
                            registration.CustomerID = int.Parse(reader["CustomerID"].ToString());
                            registration.ProductCode = reader["ProductCode"].ToString();

                            registrationList.Add(registration);
                        }
                    }
                }

            }
            return registrationList;
        }
}
