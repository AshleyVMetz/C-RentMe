using RentMe.Model;
using System;
using System.Data.SqlClient;

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
        public int AddEmployee(Employee employee)
        {
            int employeeID = 0;
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
            string selectStatement =
                "SELECT MAX(EmployeeID) AS EmployeeID " +
                "FROM Employees; ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employeeID = reader.GetInt32(0);
                        }
                    }
                }
            }
            return employeeID;
        }

        /// <summary>
        /// This method returns an employee with the specified ID.
        /// </summary>
        /// <param name="employeeID">The ID of the employee.</param>
        /// <returns>An employee with the specified ID.</returns>
        public Employee GetEmployeeByID(int employeeID)
        {
            Employee employee = null;
            string selectStatement =
                "SELECT EmployeeID, FName, LName, Sex, DOB, Phone, Address1, Address2, City, State, ZipCode, Username, Password, IsActive, IsAdmin " +
                "FROM Employees " +
                "WHERE EmployeeID=@employeeID; ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@employeeID", employeeID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeIDfromDB = reader.GetInt32(0);
                            string fName = reader["FName"].ToString();
                            string lName = reader["LName"].ToString();
                            string sex = reader["Sex"].ToString();
                            DateTime dob = (DateTime)reader["DOB"];
                            string phone = reader["Phone"].ToString();
                            string address1 = reader["Address1"].ToString();
                            string address2 = reader["Address2"].ToString();
                            string city = reader["City"].ToString();
                            string state = reader["State"].ToString();
                            string zipCode = reader["ZipCode"].ToString();
                            string username = reader["Username"].ToString();
                            string password = reader["Password"].ToString();
                            Boolean isActive = (Boolean)reader["IsActive"];
                            Boolean isAdmin = (Boolean)reader["IsAdmin"];
                            employee = new Employee(employeeIDfromDB, fName, lName, sex, dob, phone, address1, address2, city, state, zipCode, username,
                                                    password, isActive, isAdmin);
                        }
                    }
                }
            }
            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new ArgumentException("There is no employee with that ID in the database.");
            }
        }

        /// <summary>
        /// This method returns an employee with the specified phone.
        /// </summary>
        /// <param name="phone">The phone of the employee.</param>
        /// <returns>An employee with the specified phone.</returns>
        public Employee GetEmployeeByPhone(string phone)
        {
            int counter = 0;
            Employee employee = null;
            string selectStatement =
                "SELECT EmployeeID, FName, LName, Sex, DOB, Phone, Address1, Address2, City, State, ZipCode, Username, Password, IsActive, IsAdmin " +
                "FROM Employees " +
                "WHERE Phone=@phone; ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@phone", phone);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            counter++;
                            if (counter > 1)
                            {
                                throw new ArgumentException("There is more than 1 employee with that phone. Please search by another parameter.");
                            }
                            int employeeID = reader.GetInt32(0);
                            string fName = reader["FName"].ToString();
                            string lName = reader["LName"].ToString();
                            string sex = reader["Sex"].ToString();
                            DateTime dob = (DateTime)reader["DOB"];
                            string phoneFromDB = reader["Phone"].ToString();
                            string address1 = reader["Address1"].ToString();
                            string address2 = reader["Address2"].ToString();
                            string city = reader["City"].ToString();
                            string state = reader["State"].ToString();
                            string zipCode = reader["ZipCode"].ToString();
                            string username = reader["Username"].ToString();
                            string password = reader["Password"].ToString();
                            Boolean isActive = (Boolean)reader["IsActive"];
                            Boolean isAdmin = (Boolean)reader["IsAdmin"];
                            employee = new Employee(employeeID, fName, lName, sex, dob, phoneFromDB, address1, address2, city, state, zipCode, username,
                                                    password, isActive, isAdmin);
                        }
                    }
                }
            }
            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new ArgumentException("There is no employee with that phone in the database.");
            }
        }

        /// <summary>
        /// This method returns an employee with the specified full name.
        /// </summary>
        /// <param name="fullName">The full name of the employee.</param>
        /// <returns>An employee with the specified full name.</returns>
        public Employee GetEmployeeByFullName(string fullName)
        {
            fullName = fullName.Trim();
            if (!fullName.Contains(" "))
            {
                throw new ArgumentException("Ensure you have entered the first and last name separated by a space.");
            }
            int counter = 0;
            Employee employee = null;
            string selectStatement =
                "SELECT EmployeeID, FName, LName, Sex, DOB, Phone, Address1, Address2, City, State, ZipCode, Username, Password, IsActive, IsAdmin " +
                "FROM Employees " +
                "WHERE FName=@fName AND LName=@lName; ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@fName", fullName.Substring(0, fullName.IndexOf(" ")));
                    selectCommand.Parameters.AddWithValue("@lName", fullName.Substring(fullName.IndexOf(" ") + 1, fullName.Length - fullName.IndexOf(" ") - 1));
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            counter++;
                            if (counter > 1)
                            {
                                throw new ArgumentException("There is more than 1 employee with that name. Please search by another parameter.");
                            }
                            int employeeID = reader.GetInt32(0);
                            string fNameFromDB = reader["FName"].ToString();
                            string lNameFromDB = reader["LName"].ToString();
                            string sex = reader["Sex"].ToString();
                            DateTime dob = (DateTime)reader["DOB"];
                            string phone = reader["Phone"].ToString();
                            string address1 = reader["Address1"].ToString();
                            string address2 = reader["Address2"].ToString();
                            string city = reader["City"].ToString();
                            string state = reader["State"].ToString();
                            string zipCode = reader["ZipCode"].ToString();
                            string username = reader["Username"].ToString();
                            string password = reader["Password"].ToString();
                            Boolean isActive = (Boolean)reader["IsActive"];
                            Boolean isAdmin = (Boolean)reader["IsAdmin"];
                            employee = new Employee(employeeID, fNameFromDB, lNameFromDB, sex, dob, phone, address1, address2, city, state, zipCode, username,
                                                    password, isActive, isAdmin);
                        }
                    }
                }
            }
            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new ArgumentException("There is no employee with that name in the database. Ensure you have entered their first and last name separated by a space.");
            }
        }

        /// <summary>
        /// This method updates the specified employee in the database.
        /// </summary>
        /// <param name="oldEmployeeDetails">The employee to be updated in the database.</param>
        /// <param name="newEmployeeDetails">The new details of the employee.</param>
        public void UpdateEmployee(Employee oldEmployeeDetails, Employee newEmployeeDetails)
        {
            string insertStatement =
                        "UPDATE Employees " +
                        "SET FName=@fName, LName=@lName, Sex=@sex, DOB=@dob, Phone=@phone, Address1=@address1, Address2=@address2, City=@city, " +
                            "State=@state, ZipCode=@zipCode, Username=@username, Password=@password, IsActive=@isActive, IsAdmin=@isAdmin " +
                        "WHERE EmployeeID=@employeeID AND FName=@oldFName AND LName=@oldLName AND Sex=@oldSex AND DOB=@oldDOB AND Phone=@oldPhone " +
                            "AND Address1=@oldAddress1 AND City=@oldCity AND State=@oldState AND ZipCode=@oldZipCode " +
                            "AND Username=@oldUsername AND Password=@oldPassword AND IsActive=@oldIsActive AND IsAdmin=@oldIsAdmin; ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@employeeID", oldEmployeeDetails.EmployeeID);
                    insertCommand.Parameters.AddWithValue("@oldFName", oldEmployeeDetails.FName);
                    insertCommand.Parameters.AddWithValue("@oldLName", oldEmployeeDetails.LName);
                    insertCommand.Parameters.AddWithValue("@oldSex", oldEmployeeDetails.Sex);
                    insertCommand.Parameters.AddWithValue("@oldDOB", oldEmployeeDetails.DOB.ToString("yyyy'-'MM'-'dd"));
                    insertCommand.Parameters.AddWithValue("@oldPhone", oldEmployeeDetails.Phone);
                    insertCommand.Parameters.AddWithValue("@oldAddress1", oldEmployeeDetails.Address1);
                    insertCommand.Parameters.AddWithValue("@oldCity", oldEmployeeDetails.City);
                    insertCommand.Parameters.AddWithValue("@oldState", oldEmployeeDetails.State);
                    insertCommand.Parameters.AddWithValue("@oldZipCode", oldEmployeeDetails.ZipCode);
                    insertCommand.Parameters.AddWithValue("@oldUsername", oldEmployeeDetails.Username);
                    insertCommand.Parameters.AddWithValue("@oldPassword", oldEmployeeDetails.Password);
                    insertCommand.Parameters.AddWithValue("@oldIsActive", oldEmployeeDetails.IsActive ? 1 : 0);
                    insertCommand.Parameters.AddWithValue("@oldIsAdmin", oldEmployeeDetails.IsAdmin ? 1 : 0);
                    insertCommand.Parameters.AddWithValue("@FName", newEmployeeDetails.FName);
                    insertCommand.Parameters.AddWithValue("@LName", newEmployeeDetails.LName);
                    insertCommand.Parameters.AddWithValue("@Sex", newEmployeeDetails.Sex);
                    insertCommand.Parameters.AddWithValue("@DOB", newEmployeeDetails.DOB.ToString("yyyy'-'MM'-'dd"));
                    insertCommand.Parameters.AddWithValue("@Phone", newEmployeeDetails.Phone);
                    insertCommand.Parameters.AddWithValue("@Address1", newEmployeeDetails.Address1);
                    insertCommand.Parameters.AddWithValue("@Address2", newEmployeeDetails.Address2);
                    insertCommand.Parameters.AddWithValue("@City", newEmployeeDetails.City);
                    insertCommand.Parameters.AddWithValue("@State", newEmployeeDetails.State);
                    insertCommand.Parameters.AddWithValue("@ZipCode", newEmployeeDetails.ZipCode);
                    insertCommand.Parameters.AddWithValue("@Username", newEmployeeDetails.Username);
                    insertCommand.Parameters.AddWithValue("@Password", newEmployeeDetails.Password);
                    insertCommand.Parameters.AddWithValue("@IsActive", newEmployeeDetails.IsActive ? 1 : 0);
                    insertCommand.Parameters.AddWithValue("@IsAdmin", newEmployeeDetails.IsAdmin ? 1 : 0);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
