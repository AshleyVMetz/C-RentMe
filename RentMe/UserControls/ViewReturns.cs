using RentMe.Controller;
using RentMe.Model;
using System;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control to view returns.
    /// </summary>
    public partial class ViewReturns : UserControl
    {
        private readonly ReturnTransactionController returnTransactionController;
        public string storeMemberID;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public ViewReturns()
        {
            InitializeComponent();
            this.returnTransactionController = new ReturnTransactionController();
        }

        /// <summary>
        /// This method binds the return list to the list view.
        /// </summary>
        public void RefreshListView()
        {
            try
            {
                this.returnListView.Items.Clear();
                if (string.IsNullOrEmpty(this.storeMemberID))
                {
                    return;
                }
                foreach (ReturnedItem returnedItem in this.returnTransactionController.GetReturnTransactionsWithItemsByStoreMemberID(this.storeMemberID))
                {
                    ListViewItem returnedItemLVI = new ListViewItem(returnedItem.ReturnID.ToString());
                    returnedItemLVI.SubItems.Add(returnedItem.RentalID.ToString());
                    returnedItemLVI.SubItems.Add(returnedItem.ReturnDate.ToShortDateString());
                    returnedItemLVI.SubItems.Add(returnedItem.ScheduledReturn.ToShortDateString());
                    returnedItemLVI.SubItems.Add(returnedItem.EmployeeFullName);
                    returnedItemLVI.SubItems.Add(returnedItem.ItemSerial);
                    returnedItemLVI.SubItems.Add(returnedItem.ItemDescription);
                    returnedItemLVI.SubItems.Add(returnedItem.ItemQuantity.ToString());
                    returnedItemLVI.SubItems.Add(returnedItem.FineDue.ToString());
                    returnedItemLVI.SubItems.Add(returnedItem.RefundDue.ToString());
                    this.returnListView.Items.Add(returnedItemLVI);
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
