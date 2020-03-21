using System;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control to add an employee.
    /// </summary>
    public partial class AddEmployee : UserControl
    {
        private readonly EmployeeController employeeController;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public AddEmployee()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
        }

        /// <summary>
        /// This method clears the form values when the clearButton is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        /// <summary>
        /// This method adds the employee to the database using the parameters entered on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployeeButton_Click(object sender, EventArgs e)
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
                string password = this.passwordTextBox.Text;
                Boolean isActive = this.activeCheckBox.Checked;
                Boolean isAdmin = this.adminCheckBox.Checked;
                this.employeeController.AddEmployee(new Employee(0, fName, lName, sex, dob, phone, address1, address2, city, state,
                                                                 zipCode, username, password, isActive, isAdmin));
                this.ClearForm();
                MessageBox.Show("The employee was successfully added.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check that all required values are entered. " + Environment.NewLine + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This helper method clears the form values.
        /// </summary>
        private void ClearForm()
        {
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
            this.passwordTextBox.Clear();
            this.activeCheckBox.Checked = false;
            this.adminCheckBox.Checked = false;
        }
    }
}
