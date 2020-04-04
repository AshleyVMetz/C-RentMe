using System.Windows.Forms;

namespace RentMe
{
    /// <summary>
    /// This class models a dashboard for an employee.
    /// </summary>
    public partial class EmployeeDashboard : Form
    {
        Form previousForm = null;

        /// <summary>
        /// Constructor method.
        /// </summary>
        /// <param name="username">The username of the logged in user.</param>
        /// <param name="fname">The first name of the logged in user.</param>
        /// <param name="lname">The last name of the logged in user.</param>
        /// <param name="form">The login form.</param>
        public EmployeeDashboard(string username, string fname, string lname, Form form)
        {
            InitializeComponent();
            labelUser.Text = username;
            labelName.Text = fname + " " + lname;

            this.previousForm = form;

        }

        /// <summary>
        /// This method closes all remaining forms when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Close();
        }

        /// <summary>
        /// This method logs the user out of the application when the logout button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutButton_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            previousForm.Visible = true;
        }
    }
}
