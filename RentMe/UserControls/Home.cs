using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;
using RentMe.Util;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control for searching furniture.
    /// </summary>
    public partial class Home : UserControl
    {
        private readonly FurnitureController furnitureController;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public Home()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.PopulateComponents();
        }

        /// <summary>
        /// This helper method populates the style and category comboboxes.
        /// </summary>
        private void PopulateComponents()
        {
            List<Style> styles = new List<Style>();
            List<Category> categories = new List<Category>();

            try
            {
                styles = this.furnitureController.GetStyles();
                categories = this.furnitureController.GetCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving styles/categories !!!! - " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            foreach (var item in styles)
            {
                this.StyleComboBox.Items.Add(new { Text = item.Description, Value = item.StyleID });
            }
            this.StyleComboBox.SelectedIndex = -1;

            foreach (var item in categories)
            {
                this.CategoryComboBox.Items.Add(new { Text = item.Description, Value = item.CategoryID });
            }
            this.CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// This method searches furniture by serial number when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialNumberSearchButton_Click(object sender, EventArgs e)
        {
            List<Furniture> furnitures = new List<Furniture>();

            this.StyleComboBox.SelectedIndex = -1;
            this.CategoryComboBox.SelectedIndex = -1;
            this.ClearDataGrid();

            if (SerialNumberTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Serial Number cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                furnitures = this.furnitureController.GetFurnituresBySerialNumber(SerialNumberTextBox.Text.Trim());

            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching data from database!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGrid(furnitures);
        }

        /// <summary>
        /// This helper method refreshes the returned furniture items.
        /// </summary>
        /// <param name="furnitures"></param>
        private void RefreshDataGrid(List<Furniture> furnitures)
        {
            this.FurnitureListView.Items.Clear();
            try
            {
                foreach (var item in furnitures)
                {
                    var lvi = new ListViewItem(new[] { item.SerialNumber, item.Description, item.Style, item.Category, item.Quantity.ToString(), item.DailyRentalRate.ToString(), item.FineRate.ToString() });
                    this.FurnitureListView.Items.Add(lvi);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching data from database!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// This method searches furniture by style when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StyleSearchButton_Click(object sender, EventArgs e)
        {
            this.CategoryComboBox.SelectedIndex = -1;
            this.SerialNumberTextBox.Text = "";
            this.ClearDataGrid();
            List<Furniture> furnitures = new List<Furniture>();

            if (this.StyleComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select a style to search!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int styleId = (this.StyleComboBox.SelectedItem as dynamic).Value;
                furnitures = this.furnitureController.GetFurnituresByStyle(styleId);

            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching data from database!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGrid(furnitures);
        }

        /// <summary>
        /// This method searches furniture by category when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategorySearchButton_Click(object sender, EventArgs e)
        {
            this.StyleComboBox.SelectedIndex = -1;
            this.SerialNumberTextBox.Text = "";
            this.ClearDataGrid();
            List<Furniture> furnitures = new List<Furniture>();

            if (this.CategoryComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select a category to search!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int categoryId = (this.CategoryComboBox.SelectedItem as dynamic).Value;
                furnitures = this.furnitureController.GetFurnituresByCategory(categoryId);

            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching data from database!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGrid(furnitures);
        }

        /// <summary>
        /// This helper method clears the returned furniture items.
        /// </summary>
        private void ClearDataGrid()
        {
            this.FurnitureListView.Items.Clear();
        }

        /// <summary>
        /// This method changes the furniture for cart selection when the list view selected index is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FurnitureListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Just test");
            Console.WriteLine(FurnitureListView.SelectedItems);
            if (FurnitureListView.SelectedItems.Count > 0)
            {
                Console.WriteLine(FurnitureListView.SelectedItems[0]);
                this.PopulateCartSelection(FurnitureListView.SelectedItems[0]);
            }
        }

        /// <summary>
        /// This helper method populates the furniture for cart selection.
        /// </summary>
        /// <param name="item">The item available for cart selection.</param>
        private void PopulateCartSelection(ListViewItem item)
        {
            SerialNumberLabel.Text = item.SubItems[0].Text;
            DescriptionLabel.Text = item.SubItems[1].Text;
            StyleLabel.Text = item.SubItems[2].Text;
            CategoryLabel.Text = item.SubItems[3].Text;
            DailyRateLabel.Text = item.SubItems[5].Text;
            FineRateLabel.Text = item.SubItems[6].Text;
            QuantityAvailableLabel.Text = item.SubItems[4].Text;
            PopulateQuantity(Int32.Parse(item.SubItems[4].Text));
        }

        /// <summary>
        /// This helper method populates the quantity available combobox.
        /// </summary>
        /// <param name="quantity">The quantity available for cart selection.</param>
        private void PopulateQuantity(int quantity)
        {
            QuantityRequiredComboBox.Items.Clear();
            QuantityRequiredComboBox.SelectedIndex = -1;

            for (int i=1; i <= quantity; i++)
            {
                QuantityRequiredComboBox.Items.Add(""+i);
            }
        }

        /// <summary>
        /// This method clears the furniture for cart selection when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SerialNumberLabel.Text = "";
            DescriptionLabel.Text = "";
            StyleLabel.Text = "";
            CategoryLabel.Text = "";
            DailyRateLabel.Text = "";
            FineRateLabel.Text = "";
            QuantityAvailableLabel.Text = "";
            PopulateQuantity(0);
        }

        /// <summary>
        /// This method adds the furniture for cart selection to the cart when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem();
            item.SerialNumber = SerialNumberLabel.Text;
            item.Description = DescriptionLabel.Text;
            if (DailyRateLabel.Text.Length > 0)
            {
                item.DailyRentalRate = Int32.Parse(DailyRateLabel.Text);
            }
            
            if (QuantityRequiredComboBox.Text.Length > 0)
            {
                item.Quantity = Int32.Parse(QuantityRequiredComboBox.Text);
            } else
            {
                item.Quantity = 0;
            }

            if (Validator.ValidateCartItem(item))
            {
                return;
            }

            CartItem matchedCartItem = null;

            foreach ( CartItem cartItem in EmployeeDashboard.cart.Items)
            {
                if(cartItem.SerialNumber == item.SerialNumber)
                {
                    matchedCartItem = cartItem;
                    break;
                }
            }

            if (matchedCartItem == null)
            {
                EmployeeDashboard.cart.Items.Add(item);
            } else
            {
                matchedCartItem.Quantity = item.Quantity;
            }

            MessageBox.Show("Furniture Added to cart!!!!",
                    "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
