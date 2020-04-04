using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// This class models a dashboard for admin users.
    /// </summary>
    public partial class AdminDashboard : Form
    {
        Form previousForm = null;
        
        /// <summary>
        /// Constructor method.
        /// </summary>
        /// <param name="username">The username of the logged in user.</param>
        public AdminDashboard(int employeeID, string username, string fName, string lName, Form form)

        {
            InitializeComponent();
            this.updateEmployeeUserControl.employeeID = employeeID;
            this.userLabel.Text = username;
            this.nameLabel.Text = fName + " " + lName;
            this.previousForm = form;
        }

        /// <summary>
        /// This method logs the user out of the application when the logout button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            this.previousForm.Visible = true;
        }

        /// <summary>
        /// This method closes all remaining forms when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }
    }
}
