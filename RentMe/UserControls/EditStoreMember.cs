using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;
using RentMe.Util;

namespace RentMe.UserControls
{
    public partial class EditStoreMember : UserControl
    {
        private readonly StoreMemberController storeMemberController;

        public EditStoreMember()
        {
            InitializeComponent();
            storeMemberController = new StoreMemberController();
        }

        private void CustomerIDSearchButton_Click(object sender, EventArgs e)
        {
            PhoneNumberSearchTextBox.Text = "";
            FirstNameSearchTextBox.Text = "";
            LastNameSearchTextBox.Text = "";

            if (CustomerIDSearchTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Customer Id cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerId = 0;

            try
            {
                customerId = Convert.ToInt32(CustomerIDSearchTextBox.Text); 
            }

            catch (Exception ex)
            {
                MessageBox.Show("Customer Id should be a Number!!!! - " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StoreMember storeMember = null;

            try
            {
                storeMember = this.storeMemberController.GetStoreMemberByCustomerId(customerId);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while searching for Store Member!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (storeMember != null)
            {
                this.DisplayResults(storeMember);
            } else
            {
                MessageBox.Show("No Customer found!!!! - ",
                  "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void PhoneNumberSearchButton_Click(object sender, EventArgs e)
        {
            CustomerIDSearchTextBox.Text = "";
            FirstNameSearchTextBox.Text = "";
            LastNameSearchTextBox.Text = "";

            if (PhoneNumberSearchTextBox.Text.Trim().Length < 10)
            {
                MessageBox.Show("Phone Number at least has to be 10 characters!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phoneNumber = PhoneNumberSearchTextBox.Text;
            StoreMember storeMember = null;
            try
            {
                storeMember = this.storeMemberController.GetStoreMemberByPhoneNumber(phoneNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for Store Member!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (storeMember != null)
            {
                this.DisplayResults(storeMember);
            }
            else
            {
                MessageBox.Show("No Customer found!!!! - ",
                  "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NameSearchButton_Click(object sender, EventArgs e)
        {

            CustomerIDSearchTextBox.Text = "";
            PhoneNumberSearchTextBox.Text = "";

            if (FirstNameSearchTextBox.Text.Trim().Length < 1 || LastNameSearchTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Both First Name and Last Name has to be typed!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = FirstNameSearchTextBox.Text;
            string lastName = LastNameSearchTextBox.Text;

            StoreMember storeMember = null;

            try
            {
                storeMember = this.storeMemberController.GetStoreMemberByName(firstName, lastName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for Store Member!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (storeMember != null)
            {
                this.DisplayResults(storeMember);
            }
            else
            {
                MessageBox.Show("No Customer found!!!! - ",
                  "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayResults(StoreMember storeMember)
        {
            this.CustomerIDLabel.Text = Convert.ToString(storeMember.MemberID);
            this.FirstNameTextBox.Text = storeMember.FirstName;
            this.LastNameTextBox.Text = storeMember.LastName;
            this.PhoneNumberTextBox.Text = storeMember.Phone;
            this.Address1TextBox.Text = storeMember.Address1;
            this.Address2TextBox.Text = storeMember.Address2;
            this.CityTextBox.Text = storeMember.City;
            ComboBoxUtil.UpdateStateComboBox(this.StateComboBox);
            this.StateComboBox.SelectedItem = storeMember.State;
            this.ZipCodeTextBox.Text = storeMember.Zip;
            this.DateOfBirthPicker.Value = storeMember.Dob;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.CustomerIDLabel.Text.Length < 1)
            {
                MessageBox.Show("Search for a Customer before Saving!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var storeMember = new StoreMember
            {
                MemberID = Convert.ToInt32(this.CustomerIDLabel.Text),
                FirstName = this.FirstNameTextBox.Text,
                LastName = this.LastNameTextBox.Text,
                Phone = this.PhoneNumberTextBox.Text,
                Dob = this.DateOfBirthPicker.Value,
                Address1 = this.Address1TextBox.Text,
                Address2 = this.Address2TextBox.Text,
                City = this.CityTextBox.Text,
                State = this.StateComboBox.Text,
                Zip = this.ZipCodeTextBox.Text
            };

            if (Validator.ValidateStoreMember(storeMember))
            {
                return;
            }

            this.storeMemberController.UpdateStoreMember(storeMember);

            MessageBox.Show("Store Member has been Updated",
                "Store Member Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.ClearAll();

        }

        private void ClearAll()
        {
            this.CustomerIDLabel.Text = "";
            this.FirstNameTextBox.Text = "";
            this.LastNameTextBox.Text = "";
            this.PhoneNumberTextBox.Text = "";
            this.DateOfBirthPicker.Value = DateTime.Today;
            this.Address1TextBox.Text = "";
            this.Address2TextBox.Text = "";
            this.CityTextBox.Text = "";
            this.ZipCodeTextBox.Text = "";
            this.StateComboBox.SelectedIndex = 0;
            CustomerIDSearchTextBox.Text = "";
            PhoneNumberSearchTextBox.Text = "";
            FirstNameSearchTextBox.Text = "";
            LastNameSearchTextBox.Text = "";
        }
    }
}
