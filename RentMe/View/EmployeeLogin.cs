using RentMe.Controller;
using System;
using System.Windows.Forms;


namespace RentMe.View
{
    public partial class EmployeeLogin : Form
    {
        private readonly LoginController controller;
        public EmployeeLogin()
        {
            InitializeComponent();
            this.controller = new LoginController();
        }

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
                else if (loginResult == true)
                {
                    this.Hide();
                    AdminDashboard adminDashboard = new AdminDashboard(usernameTextBox.Text);
                    adminDashboard.Show();
                }
                else
                {
                    this.Hide();
                    EmployeeDashboard mainDashboard = new EmployeeDashboard(usernameTextBox.Text);
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
