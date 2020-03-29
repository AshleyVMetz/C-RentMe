using System.Windows.Forms;

namespace RentMe
{
    public partial class EmployeeDashboard : Form
    {
        Form previousForm = null;
        public EmployeeDashboard(string username, string fname, string lname, Form form)
        {
            InitializeComponent();
            labelUser.Text = username;
            labelName.Text = fname + " " + lname;

            this.previousForm = form;

        }

        private void EmployeeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Close();
        }

        private void logoutButton_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            previousForm.Visible = true;
        }
    }
}
