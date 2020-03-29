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
using RentMe.Util;

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

                if(Validator.ValidateStoreMember(storeMember))
                {
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
            ComboBoxUtil.UpdateStateComboBox(this.StateComboBox);

            this.StateComboBox.SelectedIndex = -1;
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
            this.StateComboBox.SelectedIndex = -1;
        }
    }
}
