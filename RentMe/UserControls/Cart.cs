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

namespace RentMe.UserControls
{
    public partial class Cart : UserControl
    {
        public Cart()
        {
            InitializeComponent();
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
            }

            
        }

        private void PopulateComboBox(ComboBox comboBox, int quantity)
        {
            comboBox.Items.Clear();

            for (int i = 0; i <= quantity; i++)
            {
                comboBox.Items.Add("" + i);
            }

            comboBox.SelectedIndex = quantity-1;
        }

        // X positions - -3, 113, 314, 397, 517
        // Y positions - 13, 57,
    }
}
