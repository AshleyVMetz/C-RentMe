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
    public partial class Home : UserControl
    {
        private readonly FurnitureController furnitureController;
        public Home()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.PopulateComponents();
        }

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

        private void ClearDataGrid()
        {
            this.FurnitureListView.Items.Clear();
        }

    }
}
