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
        public AdminDashboard(string username)
        {
            InitializeComponent();
            labeluser.Text = username;
        }
    }
}
