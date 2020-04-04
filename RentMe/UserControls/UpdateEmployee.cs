using System;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control to update an employee.
    /// </summary>
    public partial class UpdateEmployee : UserControl
    {
        private readonly EmployeeController employeeController;
        private Employee employee;
        public int employeeID;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public UpdateEmployee()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
        }

        /// <summary>
        /// This method clears the form values when the clearButton is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            this.employeeIDSearchTextBox.Clear();
            this.phoneSearchTextBox.Clear();
            this.fullNameSearchTextBox.Clear();
            this.employeeIDTextBox.Clear();
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.sexComboBox.SelectedIndex = -1;
            this.dobDateTimePicker.Value = DateTime.Now;
            this.phoneTextBox.Clear();
            this.address1TextBox.Clear();
            this.address2TextBox.Clear();
            this.cityTextBox.Clear();
            this.stateComboBox.SelectedIndex = -1;
            this.zipCodeTextBox.Clear();
            this.usernameTextBox.Clear();
            this.passwordMaskedTextBox.Clear();
            this.activeCheckBox.Checked = false;
            this.activeCheckBox.Enabled = true;
            this.adminCheckBox.Checked = false;
            this.adminCheckBox.Enabled = true;
            this.updateEmployeeButton.Enabled = false;
        }

        /// <summary>
        /// This method searches the database for an employee using one of the parameters entered on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.updateEmployeeButton.Enabled = true;
            this.GetEmployee();
            if (this.employeeID == this.employee.EmployeeID)
            {
                this.activeCheckBox.Enabled = false;
                this.adminCheckBox.Enabled = false;
            }
            else
            {
                this.activeCheckBox.Enabled = true;
                this.adminCheckBox.Enabled = true;
            }
        }

        /// <summary>
        /// This method updates the specified employee in the database using the parameters entered on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = this.firstNameTextBox.Text;
                string lName = this.lastNameTextBox.Text;
                string sex = this.sexComboBox.Text;
                DateTime dob = this.dobDateTimePicker.Value;
                string phone = this.phoneTextBox.Text;
                string address1 = this.address1TextBox.Text;
                string address2 = this.address2TextBox.Text;
                string city = this.cityTextBox.Text;
                string state = this.stateComboBox.Text;
                string zipCode = this.zipCodeTextBox.Text;
                string username = this.usernameTextBox.Text;
                string password = this.passwordMaskedTextBox.Text;
                Boolean isActive = this.activeCheckBox.Checked;
                Boolean isAdmin = this.adminCheckBox.Checked;
                this.employeeController.UpdateEmployee(this.employee, new Employee(0, fName, lName, sex, dob, phone, address1, address2, city, state,
                                                       zipCode, username, password, isActive, isAdmin));
                this.GetEmployee();
                if (!this.employee.FName.Equals(fName) || !this.employee.LName.Equals(lName) || !this.employee.Sex.Equals(sex) || this.employee.DOB != dob ||
                    !this.employee.Phone.Equals(phone) || !this.employee.Address1.Equals(address1) || !this.employee.Address2.Equals(address2) ||
                    !this.employee.City.Equals(city) || !this.employee.State.Equals(state) || !this.employee.ZipCode.Equals(zipCode) ||
                    !this.employee.Username.Equals(username) || !this.employee.Password.Equals(password) ||
                    this.employee.IsActive != isActive || this.employee.IsAdmin != isAdmin)
                {
                    MessageBox.Show("The employee was updated by someone else. Please refresh and try again.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The employee was successfully updated.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input or database connection. " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This helper method returns the employee from the database, if any.
        /// </summary>
        private void GetEmployee()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.employeeIDSearchTextBox.Text) && string.IsNullOrEmpty(this.phoneSearchTextBox.Text) &&
                   string.IsNullOrEmpty(this.fullNameSearchTextBox.Text))
                {
                    this.employee = this.employeeController.GetEmployeeByID(this.employeeIDSearchTextBox.Text);
                }
                else if (string.IsNullOrEmpty(this.employeeIDSearchTextBox.Text) && !string.IsNullOrEmpty(this.phoneSearchTextBox.Text) &&
                         string.IsNullOrEmpty(this.fullNameSearchTextBox.Text))
                {
                    this.employee = this.employeeController.GetEmployeeByPhone(this.phoneSearchTextBox.Text);
                }
                else if (string.IsNullOrEmpty(this.employeeIDSearchTextBox.Text) && string.IsNullOrEmpty(this.phoneSearchTextBox.Text) &&
                         !string.IsNullOrEmpty(this.fullNameSearchTextBox.Text))
                {
                    this.employee = this.employeeController.GetEmployeeByFullName(this.fullNameSearchTextBox.Text);
                }
                else
                {
                    this.updateEmployeeButton.Enabled = false;
                    MessageBox.Show("Ensure you have entered exactly one of the available parameters.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.employeeIDTextBox.Text = this.employee.EmployeeID.ToString();
                this.firstNameTextBox.Text = this.employee.FName;
                this.lastNameTextBox.Text = this.employee.LName;
                this.sexComboBox.Text = this.employee.Sex;
                this.dobDateTimePicker.Value = this.employee.DOB;
                this.phoneTextBox.Text = this.employee.Phone;
                this.address1TextBox.Text = this.employee.Address1;
                this.address2TextBox.Text = this.employee.Address2;
                this.cityTextBox.Text = this.employee.City;
                this.stateComboBox.Text = this.employee.State;
                this.zipCodeTextBox.Text = this.employee.ZipCode;
                this.usernameTextBox.Text = this.employee.Username;
                this.passwordMaskedTextBox.Text = this.employee.Password;
                this.activeCheckBox.Checked = this.employee.IsActive;
                this.adminCheckBox.Checked = this.employee.IsAdmin;
            }
            catch (Exception ex)
            {
                this.updateEmployeeButton.Enabled = false;
                MessageBox.Show("Something is wrong with the input or database connection. " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
