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

            try
            {
                StoreMember storeMember = this.storeMemberController.GetStoreMemberByCustomerId(customerId);
                Console.WriteLine(storeMember.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while searching for Store Member!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         }

        private void PhoneNumberSearchButton_Click(object sender, EventArgs e)
        {
            if (PhoneNumberSearchTextBox.Text.Trim().Length < 10)
            {
                MessageBox.Show("Phone Number at least has to be 10 characters!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phoneNumber = PhoneNumberSearchTextBox.Text;

            try
            {
                StoreMember storeMember = this.storeMemberController.GetStoreMemberByPhoneNumber(phoneNumber);
                Console.WriteLine(storeMember.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for Store Member!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NameSearchButton_Click(object sender, EventArgs e)
        {
            if (FirstNameSearchTextBox.Text.Trim().Length < 1 || LastNameSearchTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Both First Name and Last Name has to be typed!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = FirstNameSearchTextBox.Text;
            string lastName = LastNameSearchTextBox.Text;

            try
            {
                StoreMember storeMember = this.storeMemberController.GetStoreMemberByName(firstName, lastName);
                Console.WriteLine(storeMember.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for Store Member!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayResults()
        {

        }
    }
}
