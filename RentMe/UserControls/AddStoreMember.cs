﻿using System;
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
                    State = "NY",
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

                if (storeMember.Phone.Trim().Length < 1)
                {
                    MessageBox.Show("Phone cannot be empty!!!!",
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating Store Member!!!! - " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
