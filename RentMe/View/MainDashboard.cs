using RentMe.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe
{
    /// <summary>
    /// This class models a dashboard for an employee.
    /// </summary>
    public partial class EmployeeDashboard : Form
    {
        Form previousForm = null;
        public static Cart cart = null;
        public static int employeeID;

        /// <summary>
        /// Constructor method.
        /// </summary>
        /// <param name="username">The username of the logged in user.</param>
        /// <param name="fname">The first name of the logged in user.</param>
        /// <param name="lname">The last name of the logged in user.</param>
        /// <param name="form">The login form.</param>
        public EmployeeDashboard(string username, string fname, string lname, int employeeId, Form form)
        {
            employeeID = employeeId;
            InitializeComponent();
            labelUser.Text = username;
            labelName.Text = fname + " " + lname;
            cart = new Cart();
            cart.Items = new List<CartItem>();
            cart.EmployeeID = employeeId;
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

        /// <summary>
        /// This method refreshes the cart when the tab is entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartTab_Enter(object sender, System.EventArgs e)
        {
            this.CartUserControl.AddCartItems();
        }

        /// <summary>
        /// This method refreshes the search when the home tab is entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Enter(object sender, System.EventArgs e)
        {
            this.homeUserControl.RefreshSearch();
        }
    }
}
