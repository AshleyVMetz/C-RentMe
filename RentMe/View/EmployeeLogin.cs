using RentMe.Controller;
using System;
using System.Windows.Forms;


namespace RentMe.View
{
    /// <summary>
    /// This class is for the login form view
    /// </summary>
    public partial class EmployeeLogin : Form
    {
        private readonly LoginController controller;

        public EmployeeLogin()
        {
            InitializeComponent();
            this.controller = new LoginController();
        }

        /// <summary>
        /// This method checks the user's entered data when the login button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(usernameTextBox.Text))
                {
                    MessageBox.Show("Please enter username");
                    return;
                }
                if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    MessageBox.Show("Please enter password");
                    return;
                }
                var loginResult = controller.EmployeeLogin(usernameTextBox.Text, passwordTextBox.Text);
                if (loginResult == null)
                {
                    MessageBox.Show("Incorrect username or password");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
                else if (loginResult.IsAdmin == true)
                {
                    this.Hide();
                    AdminDashboard adminDashboard = new AdminDashboard(usernameTextBox.Text, loginResult.FName, this);
                    adminDashboard.Show();
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";

                }
                else
                {
                    this.Visible = false;
                    EmployeeDashboard mainDashboard = new EmployeeDashboard(usernameTextBox.Text, loginResult.FName, this);

                    mainDashboard.Show();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Employee Does Not Exist");
            }

        }
    }
}
