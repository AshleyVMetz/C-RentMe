using RentMe.DAL;
using RentMe.Model;
using System;

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
            if (employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null.");
            }
            else
            {
                this.employeeDataSource.AddEmployee(employee);
            }
        }
    }
}
