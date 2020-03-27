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
            this.StyleComboBox.SelectedIndex = 0;

            foreach (var item in categories)
            {
                this.CategoryComboBox.Items.Add(new { Text = item.Description, Value = item.CategoryID });
            }
            this.CategoryComboBox.SelectedIndex = 0;
        }
    }
}
