using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;
using RentMe.Util;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control to view and edit store members.
    /// </summary>
    public partial class EditStoreMember : UserControl
    {
        private readonly StoreMemberController storeMemberController;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public EditStoreMember()
        {
            InitializeComponent();
            storeMemberController = new StoreMemberController();
        }

        /// <summary>
        /// This method searches for a customer by ID when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method searches for a customer by phone number when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberSearchButton_Click(object sender, EventArgs e)
        {
            CustomerIDSearchTextBox.Text = "";
            FirstNameSearchTextBox.Text = "";
            LastNameSearchTextBox.Text = "";

            if (!Regex.IsMatch(PhoneNumberSearchTextBox.Text.Trim(), @"\d\d\d-\d\d\d-\d\d\d\d"))
            {
                MessageBox.Show("Phone Number should be XXX-XXX-XXXX format!!!!",
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
                return;
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

        /// <summary>
        /// This method searches for a customer by name when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                return;
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

        /// <summary>
        /// This helper method displays the search results.
        /// </summary>
        /// <param name="storeMember"></param>
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
            ComboBoxUtil.UpdateGenderComboBox(this.GenderComboBox);
            this.GenderComboBox.SelectedItem = storeMember.Sex;
            this.ZipCodeTextBox.Text = storeMember.Zip;
            this.DateOfBirthPicker.Value = storeMember.Dob;
            this.viewRentalsUserControl.storeMemberID = this.CustomerIDLabel.Text;
            this.viewRentalsUserControl.RefreshListView();
            this.viewReturnsUserControl.storeMemberID = this.CustomerIDLabel.Text;
            this.viewReturnsUserControl.RefreshListView();
        }


        /// <summary>
        /// This method updates the specified customer in the database using the parameters entered on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Sex = this.GenderComboBox.Text,
                Zip = this.ZipCodeTextBox.Text
            };

            if (Validator.ValidateStoreMember(storeMember))
            {
                return;
            }

            try
            {
                this.storeMemberController.UpdateStoreMember(storeMember);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating Store Member!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Store Member has been Updated",
                "Store Member Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.ClearAll();

        }

        /// <summary>
        /// This helper method clears the form values.
        /// </summary>
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
            this.StateComboBox.Items.Clear();
            this.GenderComboBox.Items.Clear();
            CustomerIDSearchTextBox.Text = "";
            PhoneNumberSearchTextBox.Text = "";
            FirstNameSearchTextBox.Text = "";
            LastNameSearchTextBox.Text = "";
            this.viewRentalsUserControl.storeMemberID = this.CustomerIDLabel.Text;
            this.viewRentalsUserControl.RefreshListView();
            this.viewReturnsUserControl.storeMemberID = this.CustomerIDLabel.Text;
            this.viewReturnsUserControl.RefreshListView();
        }

        /// <summary>
        /// This method clears the form values when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
