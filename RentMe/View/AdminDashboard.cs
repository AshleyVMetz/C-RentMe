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
        public AdminDashboard(string username, string fName, string lName, Form form)

        {
            InitializeComponent();
            labeluser.Text = username;
            NameLabel.Text = fName + " " + lName;

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
            previousForm.Visible = true;

        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Close();

        }
    }
}
