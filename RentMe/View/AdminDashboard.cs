using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// This class models a dashboard for admin users.
    /// </summary>
    public partial class AdminDashboard : Form
    {
        /// <summary>
        /// Constructor method.
        /// </summary>
        /// <param name="username">The username of the logged in user.</param>
        public AdminDashboard(string username)
        {
            InitializeComponent();
            labeluser.Text = username;
        }

        /// <summary>
        /// This method logs the user out of the application when the logout button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, System.EventArgs e)
        {
            Form loginForm = new EmployeeLogin();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
