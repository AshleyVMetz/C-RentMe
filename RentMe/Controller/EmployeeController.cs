using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    /// <summary>
    /// Controller class to mediate between EmployeeDAL and View.
    /// </summary>
    class EmployeeController
    {
        private EmployeeDAL employeeDataSource;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public EmployeeController()
        {
            this.employeeDataSource = new EmployeeDAL();
        }

        /// <summary>
        /// This method adds an employee to the database.
        /// </summary>
        /// <param name="employee">The employee to be added to the database.</param>
        public void AddEmployee(Employee employee)
        {
            this.employeeDataSource.AddEmployee(employee);
        }

        /// <summary>
        /// This method returns an employee with the specified ID.
        /// </summary>
        /// <param name="employeeID">The ID of the employee.</param>
        /// <returns>An employee with the specified ID.</returns>
        public Employee GetEmployeeByID(string employeeID)
        {
            return this.employeeDataSource.GetEmployeeByID(int.Parse(employeeID));
        }

        /// <summary>
        /// This method returns an employee with the specified phone.
        /// </summary>
        /// <param name="phone">The phone of the employee.</param>
        /// <returns>An employee with the specified phone.</returns>
        public Employee GetEmployeeByPhone(string phone)
        {
            return this.employeeDataSource.GetEmployeeByPhone(phone);
        }

        /// <summary>
        /// This method returns an employee with the specified full name.
        /// </summary>
        /// <param name="fullName">The full name of the employee.</param>
        /// <returns>An employee with the specified full name.</returns>
        public Employee GetEmployeeByFullName(string fullName)
        {
            return this.employeeDataSource.GetEmployeeByFullName(fullName);
        }

        /// <summary>
        /// This method updates the specified employee in the database.
        /// </summary>
        /// <param name="oldEmployeeDetails">The employee to be updated in the database.</param>
        /// <param name="newEmployeeDetails">The new details of the employee.</param>
        public void UpdateEmployee(Employee oldEmployeeDetails, Employee newEmployeeDetails)
        {
            this.employeeDataSource.UpdateEmployee(oldEmployeeDetails, newEmployeeDetails);
        }
    }
}
