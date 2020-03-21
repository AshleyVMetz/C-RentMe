using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    /// <summary>
    /// DAL class to mediate between Employees table in the database and Controller.
    /// </summary>
    class EmployeeDAL
    {
        /// <summary>
        /// This method adds an employee to the database.
        /// </summary>
        /// <param name="employee">The employee to be added to the database.</param>
        public void AddEmployee(Employee employee)
        {
            string insertStatement =
                "INSERT INTO Employees (FName,LName,Sex,DOB,Phone,Address1,Address2,City,State,ZipCode,Username,Password,IsActive,IsAdmin) " +
                "VALUES (@fName,@lName,@sex,@dob,@phone,@address1,@address2,@city,@state,@zipCode,@username,@password,@isActive,@isAdmin); ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@fName", employee.FName);
                    insertCommand.Parameters.AddWithValue("@lName", employee.LName);
                    insertCommand.Parameters.AddWithValue("@sex", employee.Sex);
                    insertCommand.Parameters.AddWithValue("@dob", employee.DOB.ToString("yyyy'-'MM'-'dd"));
                    insertCommand.Parameters.AddWithValue("@phone", employee.Phone);
                    insertCommand.Parameters.AddWithValue("@address1", employee.Address1);
                    insertCommand.Parameters.AddWithValue("@address2", employee.Address2);
                    insertCommand.Parameters.AddWithValue("@city", employee.City);
                    insertCommand.Parameters.AddWithValue("@state", employee.State);
                    insertCommand.Parameters.AddWithValue("@zipCode", employee.ZipCode);
                    insertCommand.Parameters.AddWithValue("@username", employee.Username);
                    insertCommand.Parameters.AddWithValue("@password", employee.Password);
                    insertCommand.Parameters.AddWithValue("@isActive", employee.IsActive ? 1 : 0);
                    insertCommand.Parameters.AddWithValue("@isAdmin", employee.IsAdmin ? 1 : 0);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
