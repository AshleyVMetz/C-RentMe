using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;
using RentMe.Util;

namespace RentMe.UserControls
{
    /// <summary>
    /// This method models a user control for the cart.
    /// </summary>
    public partial class Cart : UserControl
    {
        private readonly StoreMemberController storeMemberController;
        private readonly RentalTransactionController rentalTransactionController;
        private readonly FurnitureController furnitureController;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public Cart()
        {
            InitializeComponent();
            storeMemberController = new StoreMemberController();
            rentalTransactionController = new RentalTransactionController();
            furnitureController = new FurnitureController();
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

                TextBox quantityTextBox = new TextBox();
                quantityTextBox.Name = "QuantityTextBox" + i;
                quantityTextBox.Text = item.Quantity.ToString();
                quantityTextBox.Location = new Point(314, 15 + (40 * i));
                quantityTextBox.Width = 40;
                CartItemPanel.Controls.Add(quantityTextBox);
                
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

        /// <summary>
        /// This method updates the cart when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_ClickHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = Int32.Parse(button.Name.Substring(button.Name.Length - 1));

            TextBox textBox = (TextBox)CartItemPanel.Controls["QuantityTextBox" + index];
            int quantity = Int32.Parse(textBox.Text);

            CartItem item = EmployeeDashboard.cart.Items[index];

            int availableQuantity = 0;

            try
            {
                availableQuantity = furnitureController.GetCurrentFurnitureCount(item.SerialNumber);
            } catch(Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error while fetching available quantity!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (quantity > availableQuantity)
            {
                MessageBox.Show("Added quantity is more than available quantity!! Available quantity is - " + availableQuantity,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddCartItems();
                return;
            }

            if (quantity == 0)
            {
                EmployeeDashboard.cart.Items.Remove(item);
            } else
            {
                item.Quantity = quantity;
            }
            
            AddCartItems();
        }

        /// <summary>
        /// This method checks out with the current cart when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                DialogResult dr = MessageBox.Show(message, "Confirm Cost for rental", MessageBoxButtons.YesNo,
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

                    ClearAllCart();

                }
            }
            else
            {
                MessageBox.Show("No Customer found!!!! - ",
                  "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
     
        }

        /// <summary>
        /// This helper method refreshes the cart.
        /// </summary>
        private void ClearAllCart()
        {
            EmployeeDashboard.cart.Items = new List<CartItem>();
            CustomerIDTextBox.Text = "";
            RentalStartTimePicker.Value = DateTime.Now;
            RentalEndTimePicker.Value = DateTime.Now;
            AddCartItems();
        }
    }
}
