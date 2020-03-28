using System.Windows.Forms;

namespace RentMe
{
    public partial class EmployeeDashboard : Form
    {
        Form previousForm = null;
        public EmployeeDashboard(string username, string fname, Form form)
        {
            InitializeComponent();
            labelUser.Text = username;
            labelFName.Text = fname;
            this.previousForm = form;

        }

        private void EmployeeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Close();
        }
    }
}
