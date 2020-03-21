﻿using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models an employee.
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Accessors for employee instance variables.
        /// </summary>
        public int EmployeeID { get; }
        public string FName { get; }
        public string LName { get; }
        public string Sex { get; }
        public DateTime DOB { get; }
        public string Phone { get; }
        public string Address1 { get; }
        public string Address2 { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string Username { get; }
        public string Password { get; }
        public Boolean IsActive { get; }
        public Boolean IsAdmin { get; }

        /// <summary>
        /// Constructor method.
        /// </summary>
        /// <param name="employeeID">The ID of the employee.</param>
        /// <param name="fName">The first name of the employee.</param>
        /// <param name="lName">The last name of the employee.</param>
        /// <param name="sex">The sex of the employee.</param>
        /// <param name="dob">The date of birth of the employee.</param>
        /// <param name="phone">The phone of the employee.</param>
        /// <param name="address1">The firt address line of the employee.</param>
        /// <param name="address2">The second address line of the employee.</param>
        /// <param name="city">The city of the employee.</param>
        /// <param name="state">The state of the employee.</param>
        /// <param name="zipCode">The zip code of the employee.</param>
        /// <param name="username">The username of the employee.</param>
        /// <param name="password">The password of the employee.</param>
        /// <param name="isActive">The status of the employee.</param>
        /// <param name="isAdmin">The admin status of the employee.</param>
        public Employee(int employeeID, string fName, string lName, string sex, DateTime dob, string phone, string address1, string address2,
                        string city, string state, string zipCode, string username, string password, Boolean isActive, Boolean isAdmin)
        {
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(sex) || dob == DateTime.MinValue || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address1) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zipCode) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Employee parameters cannot be null or empty.");
            }
            this.EmployeeID = employeeID;
            this.FName = fName;
            this.LName = lName;
            this.Sex = sex;
            this.DOB = dob;
            this.Phone = phone;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Username = username;
            this.Password = password;
            this.IsActive = isActive;
            this.IsAdmin = isAdmin;
        }
    }
}
