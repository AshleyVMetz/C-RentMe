using System;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control to view rentals.
    /// </summary>
    public partial class ViewRentals : UserControl
    {
        private readonly RentalTransactionController rentalTransactionController;
        public string storeMemberID;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public ViewRentals()
        {
            InitializeComponent();
            this.rentalTransactionController = new RentalTransactionController();
        }

        /// <summary>
        /// This method binds the rental list to the list view.
        /// </summary>
        public void RefreshListView()
        {
            try
            {
                this.rentalListView.Items.Clear();
                if (string.IsNullOrEmpty(this.storeMemberID))
                {
                    return;
                }
                foreach (RentedItem rentedItem in this.rentalTransactionController.GetRentalTransactionsWithItemsByStoreMemberID(this.storeMemberID))
                {
                    ListViewItem rentedItemLVI = new ListViewItem(rentedItem.RentalID.ToString());
                    rentedItemLVI.SubItems.Add(rentedItem.DateOfRental.ToShortDateString());
                    rentedItemLVI.SubItems.Add(rentedItem.ScheduledReturn.ToShortDateString());
                    rentedItemLVI.SubItems.Add(rentedItem.EmployeeFullName);
                    rentedItemLVI.SubItems.Add(rentedItem.ItemDescription);
                    rentedItemLVI.SubItems.Add(rentedItem.ItemPrice.ToString());
                    rentedItemLVI.SubItems.Add(rentedItem.ItemQuantity.ToString());
                    rentedItemLVI.SubItems.Add((rentedItem.ItemPrice * rentedItem.ItemQuantity * (int)(rentedItem.ScheduledReturn - rentedItem.DateOfRental).TotalDays).ToString());
                    this.rentalListView.Items.Add(rentedItemLVI);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input or database connection. " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
