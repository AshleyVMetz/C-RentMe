﻿using System;
using System.Windows.Forms;
using RentMe.Model;
using RentMe.Controller;
using RentMe.Util;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control for adding a store member.
    /// </summary>
    public partial class AddStoreMember : UserControl
    {
        private readonly StoreMemberController storeMemberController;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public AddStoreMember()
        {
            storeMemberController = new StoreMemberController();
            InitializeComponent();
            AddStateData();
            AddGenderData();
        }

        /// <summary>
        /// This method adds a store member to the database using the parameters entered on the form when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    Zip = this.ZipCodeTextBox.Text,
                    Sex = this.GenderComboBox.Text
                };

                if (Validator.ValidateStoreMember(storeMember))
                {
                    return;
                }

                int customerId = this.storeMemberController.Add(storeMember);

                MessageBox.Show("Store Member has been created with Customer Id - " + customerId,
                    "Store Member Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating Store Member!!!! - " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This helper method populates the state combobox options.
        /// </summary>
        private void AddStateData()
        {
            ComboBoxUtil.UpdateStateComboBox(this.StateComboBox);

            this.StateComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// This helper method populates the gender combobox options.
        /// </summary>
        private void AddGenderData()
        {
            ComboBoxUtil.UpdateGenderComboBox(this.GenderComboBox);

            this.GenderComboBox.SelectedIndex = -1;
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

        /// <summary>
        /// This helper method clears the form values.
        /// </summary>
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
            this.GenderComboBox.SelectedIndex = -1;
        }
    }
}
