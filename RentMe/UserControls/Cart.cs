using System;
using System.Drawing;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;
using RentMe.Util;

namespace RentMe.UserControls
{
    public partial class Cart : UserControl
    {
        private readonly StoreMemberController storeMemberController;
        private readonly RentalTransactionController rentalTransactionController;

        public Cart()
        {
            InitializeComponent();
            storeMemberController = new StoreMemberController();
            rentalTransactionController = new RentalTransactionController();
        }

        /// <summary>
        /// Gets list of items from cart and shows it
        /// </summary>
        public void AddCartItems()
        {
            CartItemPanel.Controls.Clear();

            for(int i=0; i < EmployeeDashboard.cart.Items.Count; i++)
            {
                CartItem item = EmployeeDashboard.cart.Items[i];
                Label serialNumberLabel = new Label();
                serialNumberLabel.Name = "SerialNumberLabel" + i;
                serialNumberLabel.Text = item.SerialNumber;
                serialNumberLabel.Location = new Point(-3, 15 + (40 * i));
                CartItemPanel.Controls.Add(serialNumberLabel);

                Label descriptionLabel = new Label();
                descriptionLabel.Name = "DescriptionLabel" + i;
                descriptionLabel.Text = item.Description;
                descriptionLabel.Location = new Point(113, 15 + (40 * i));
                descriptionLabel.Width = 180;
                CartItemPanel.Controls.Add(descriptionLabel);

                ComboBox quantityComboBox = new ComboBox();
                quantityComboBox.Name = "QuantityComboBox" + i;
                quantityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                PopulateComboBox(quantityComboBox, item.Quantity);
                quantityComboBox.Location = new Point(314, 15 + (40 * i));
                quantityComboBox.Width = 40;
                CartItemPanel.Controls.Add(quantityComboBox);
                
                Label rentalRateLabel = new Label();
                rentalRateLabel.Name = "RentalRateLabel" + i;
                rentalRateLabel.Text = item.DailyRentalRate.ToString();
                rentalRateLabel.Location = new Point(397, 15 + (40 * i));
                CartItemPanel.Controls.Add(rentalRateLabel);

                Button updateButton = new Button();
                updateButton.Name = "UpdateButton" + i;
                updateButton.Text = "Update";
                updateButton.Location = new Point(517, 15 + (40 * i));
                CartItemPanel.Controls.Add(updateButton);
                updateButton.Click += new EventHandler(UpdateButton_ClickHandler);

            }


        }

        private void PopulateComboBox(ComboBox comboBox, int quantity)
        {
            comboBox.Items.Clear();

            for (int i = 0; i <= quantity; i++)
            {
                comboBox.Items.Add("" + i);
            }

            comboBox.SelectedIndex = quantity;
        }

        private void UpdateButton_ClickHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = Int32.Parse(button.Name.Substring(button.Name.Length - 1));

            ComboBox comboBox = (ComboBox)CartItemPanel.Controls["QuantityComboBox" + index];
            int quantity = Int32.Parse(comboBox.Text);

            CartItem item = EmployeeDashboard.cart.Items[index];
            if (quantity == 0)
            {
                EmployeeDashboard.cart.Items.Remove(item);
            } else
            {
                item.Quantity = quantity;
            }
            
            AddCartItems();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {

            if (CustomerIDTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Customer Id cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerId = 0;

            try
            {
                customerId = Convert.ToInt32(CustomerIDTextBox.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Customer Id should be a Number!!!! - " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmployeeDashboard.cart.MemberID = customerId;
            EmployeeDashboard.cart.RentalStartDate = RentalStartTimePicker.Value;
            EmployeeDashboard.cart.RentalEndDate = RentalEndTimePicker.Value;

            if (Validator.ValidateCart(EmployeeDashboard.cart))
            {
                return;
            }

            Console.WriteLine("Validation is fine");

            // Check if memberId is valid
            StoreMember storeMember = null;

            try
            {
                storeMember = this.storeMemberController.GetStoreMemberByCustomerId(customerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while getting Store Member information!!!! - " + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (storeMember != null)
            {
                // Find Total amount due
                double totalAmount = 0;
                int rentalDays = (int) Math.Round(RentalEndTimePicker.Value.Subtract(RentalStartTimePicker.Value).TotalDays);

                for (int i=0; i < EmployeeDashboard.cart.Items.Count; i++ )
                {
                    CartItem item = EmployeeDashboard.cart.Items[i];
                    totalAmount += (item.Quantity * item.DailyRentalRate * rentalDays);
                }

                // Show confirmation with final amount
                String message = "Total rental cost for the customer - " + storeMember.FirstName + " " + storeMember.LastName + " is " + totalAmount;
                DialogResult dr = MessageBox.Show(message, "Confirm Cost for rental", MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    // Place order
                    Boolean isInserted = this.rentalTransactionController.InsertRentalTransaction(EmployeeDashboard.cart);

                    if (!isInserted)
                    {
                        MessageBox.Show("Error while creating rental transaction!!!! - ",
                  "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Rental transaction successful!!!! - ",
                  "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("No Customer found!!!! - ",
                  "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
     
        }
    }
}
