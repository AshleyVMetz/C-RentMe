using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Model;
using RentMe.Controller;

namespace RentMe.UserControls
{
    public partial class AddStoreMember : UserControl
    {
        private readonly StoreMemberController storeMemberController;

        public AddStoreMember()
        {
            storeMemberController = new StoreMemberController();
            InitializeComponent();
            AddStateData();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var storeMember = new StoreMember
                {
                    FirstName = this.FirstNameTextBox.Text,
                    LastName = this.LastNameTextBox.Text,
                    Phone = this.PhoneTextBox.Text,
                    Dob = this.DateOfBirthPicker.Value,
                    Address1 = this.Address1TextBox.Text,
                    Address2 = this.Address2TextBox.Text,
                    City = this.CityTextBox.Text,
                    State = this.StateComboBox.Text,
                    Zip = this.ZipCodeTextBox.Text
                };

                if(storeMember.FirstName.Trim().Length < 1)
                {
                    MessageBox.Show("First Name cannot be empty!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (storeMember.LastName.Trim().Length < 1)
                {
                    MessageBox.Show("Last Name cannot be empty!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (storeMember.Phone.Trim().Length != 10)
                {
                    MessageBox.Show("Phone should contain 10 integers!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (storeMember.Dob == null)
                {
                    MessageBox.Show("Date of Birth cannot be empty!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (storeMember.Address1.Trim().Length < 5 ||
                    storeMember.City.Trim().Length < 1 ||
                    storeMember.State.Trim().Length < 1 ||
                    storeMember.Zip.Trim().Length < 1)
                {
                    MessageBox.Show("All mandatory address fields should be filled!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.storeMemberController.Add(storeMember);

                MessageBox.Show("Store Member has been created",
                    "Store Member Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating Store Member!!!! - " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStateData()
        {
            this.StateComboBox.Items.Add("AL");
            this.StateComboBox.Items.Add("AK");
            this.StateComboBox.Items.Add("AZ");
            this.StateComboBox.Items.Add("AR");
            this.StateComboBox.Items.Add("CA");
            this.StateComboBox.Items.Add("CO");
            this.StateComboBox.Items.Add("CT");
            this.StateComboBox.Items.Add("DE");
            this.StateComboBox.Items.Add("FL");
            this.StateComboBox.Items.Add("GA");
            this.StateComboBox.Items.Add("HI");
            this.StateComboBox.Items.Add("ID");
            this.StateComboBox.Items.Add("IL");
            this.StateComboBox.Items.Add("IN");
            this.StateComboBox.Items.Add("IA");
            this.StateComboBox.Items.Add("KS");
            this.StateComboBox.Items.Add("KY");
            this.StateComboBox.Items.Add("LA");
            this.StateComboBox.Items.Add("ME");
            this.StateComboBox.Items.Add("MD");
            this.StateComboBox.Items.Add("MA");
            this.StateComboBox.Items.Add("MI");
            this.StateComboBox.Items.Add("MN");
            this.StateComboBox.Items.Add("MS");
            this.StateComboBox.Items.Add("MO");
            this.StateComboBox.Items.Add("MT");
            this.StateComboBox.Items.Add("NE");
            this.StateComboBox.Items.Add("NV");
            this.StateComboBox.Items.Add("NH");
            this.StateComboBox.Items.Add("NJ");
            this.StateComboBox.Items.Add("NY");
            this.StateComboBox.Items.Add("NM");
            this.StateComboBox.Items.Add("NC");
            this.StateComboBox.Items.Add("ND");
            this.StateComboBox.Items.Add("OH");
            this.StateComboBox.Items.Add("OK");
            this.StateComboBox.Items.Add("OR");
            this.StateComboBox.Items.Add("PA");
            this.StateComboBox.Items.Add("RI");
            this.StateComboBox.Items.Add("SD");
            this.StateComboBox.Items.Add("ST");
            this.StateComboBox.Items.Add("TN");
            this.StateComboBox.Items.Add("TX");
            this.StateComboBox.Items.Add("UT");
            this.StateComboBox.Items.Add("VT");
            this.StateComboBox.Items.Add("VA");
            this.StateComboBox.Items.Add("WA");
            this.StateComboBox.Items.Add("WV");
            this.StateComboBox.Items.Add("WI");
            this.StateComboBox.Items.Add("WY");

            this.StateComboBox.SelectedIndex = 0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.FirstNameTextBox.Text = "";
            this.LastNameTextBox.Text = "";
            this.PhoneTextBox.Text = "";
            this.DateOfBirthPicker.Value = DateTime.Today;
            this.Address1TextBox.Text = "";
            this.Address2TextBox.Text = "";
            this.CityTextBox.Text = "";
            this.ZipCodeTextBox.Text = "";
            this.StateComboBox.SelectedIndex = 0;
        }
    }
}
