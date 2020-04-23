using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class is for the return user control.
    /// </summary>
    public partial class Return : UserControl
    {
        ReturnController returnController;
        ReturnTransactionController returnTransactionController;
        FurnitureController furnitureController;
        RentalTransactionController rentalTransactionController;
        EmployeeController employeeController;
        int employeeID;
        int memberID;
        List<int> rentalIDList;
        List<ReturnableItem> returnableItems;
        List<ReturnableItem> itemsToReturn;
        ReturnableItem currentItem;
        /// <summary>
        /// Constructor method.
        /// </summary>
        public Return()
        {
            InitializeComponent();
            this.returnController = new ReturnController();
            this.returnTransactionController = new ReturnTransactionController();
            this.furnitureController = new FurnitureController();
            rentalTransactionController = new RentalTransactionController();
            this.employeeController = new EmployeeController();
            this.employeeID = EmployeeDashboard.employeeID;
            buttonReturn.Enabled = false;
            buttonAddToReturn.Enabled = false;
            this.itemsToReturn = new List<ReturnableItem>();

        }




        /// <summary>
        /// This method submits a return when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ReturnTransaction transaction = new ReturnTransaction();
            transaction.EmployeeID = employeeID;
            transaction.ReturnDate = DateTime.Now;
            int returnID = returnTransactionController.CreateReturnTransaction(transaction);
            transaction.ReturnID = returnID;
            decimal finalBalance = 0;

            foreach (var itemToReturn in itemsToReturn)
            {
                var returnItem = new ReturnItem();
                returnItem.ReturnID = returnID;
                returnItem.RentalID = itemToReturn.RentalID;
                returnItem.SerialNumber = itemToReturn.SerialNumber;
                returnItem.Quantity = itemToReturn.Quantity;
                var furnitures = furnitureController.GetFurnituresBySerialNumber(returnItem.SerialNumber);
                var itemScheduledReturn = rentalTransactionController.GetRentalTransactionByRentalID(returnItem.RentalID);

                var daysLate = DayNum(DateTime.Now.Date.ToString(), itemScheduledReturn.ScheduledReturn.ToString()) + 1;
                var daysEarly = DayNum(itemScheduledReturn.ScheduledReturn.ToString(), DateTime.Now.Date.ToString()) - 1;

                if (furnitures.Count > 0)
                {
                    var furniture = furnitures.FirstOrDefault();
                    int resultDiff = DateTime.Compare(DateTime.Now.Date, itemScheduledReturn.ScheduledReturn);
                    if (resultDiff < 0)
                    {
                        returnItem.RefundDue = Convert.ToDecimal(furniture.DailyRentalRate * daysEarly * returnItem.Quantity);
                        returnItem.FineDue = 0;
                        finalBalance += returnItem.RefundDue;
                    }
                    else if (resultDiff == 0)
                    {
                        returnItem.RefundDue = 0;
                        returnItem.FineDue = 0;

                    }
                    else
                    {
                        returnItem.FineDue = Convert.ToDecimal((furniture.FineRate + furniture.DailyRentalRate) * daysLate * returnItem.Quantity);
                        returnItem.RefundDue = 0;
                        finalBalance -= returnItem.FineDue;
                    }


                }
                var result = returnController.CreateReturnItem(returnItem);
                if (!result)
                {
                    MessageBox.Show("Failed to Return Items.");
                    return;
                }
            }

            if (finalBalance > 0)
            {
                transaction.RefundDueTotal = finalBalance;
                transaction.FineDueTotal = 0;
            }
            else
            {
                transaction.FineDueTotal = Math.Abs(finalBalance);
                transaction.RefundDueTotal = 0;
            }
            returnTransactionController.UpdateTransaction(transaction);
            MessageBox.Show("Successfully Returned Furniture Items");
            buttonSearch_Click(sender, e);
            MessageBox.Show("Fine Due: " + "$ " + transaction.FineDueTotal.ToString() + "\n" + "Refund Due: " + "$ " + transaction.RefundDueTotal.ToString());
            this.Clear();
        }

        /// <summary>
        /// This method cancels the return when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        /// <summary>
        /// This helper method returns the days between dates.
        /// </summary>
        /// <param name="date">The date</param>
        /// <param name="startDate">The start date</param>
        /// <returns>The days between dates.</returns>
        static int DayNum(string date, string startDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime dt = DateTime.Parse(date);
            TimeSpan t = dt - start;
            return (int)t.TotalDays;
        }

        /// <summary>
        /// This method clears the return data.
        /// </summary>

        public void Clear()
        {

            textBoxStoreMemberID.Text = "";
            this.listViewReturnableItems.Items.Clear();
            this.listViewItemsToReturn.Items.Clear();
            buttonReturn.Enabled = false;
            buttonAddToReturn.Enabled = false;
            SerialNumberLabel.Text = "";
            QuantityAvailableLabel.Text = "";
            this.ComboBoxRequiredQuantity.Items.Clear();
            ComboBoxRequiredQuantity.ResetText();

        }

        /// <summary>
        /// This method searches the returnable items when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            memberID = int.Parse(textBoxStoreMemberID.Text);
            rentalIDList = rentalTransactionController.GetRentalIDListByMemberID(memberID);
            returnableItems = new List<ReturnableItem>();
            foreach (var rentalID in rentalIDList)
            {
                var list = returnController.GetReturnableItemsByRentalID(rentalID);
                returnableItems.AddRange(list);
            }
            RefreshListViewReturnableItems();

        }

        private void RefreshListViewReturnableItems()
        {
            this.listViewReturnableItems.Items.Clear();

            try
            {
                foreach (var item in this.returnableItems)
                {
                    var lvi = new ListViewItem(new[] { item.SerialNumber, item.Description, item.Style, item.Category, item.Quantity.ToString(), item.RentalID.ToString() });
                    this.listViewReturnableItems.Items.Add(lvi);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching data from database!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefreshListViewItemsToReturn()
        {
            this.listViewItemsToReturn.Items.Clear();
            try
            {
                foreach (var item in this.itemsToReturn)
                {
                    var lvi = new ListViewItem(new[] { item.SerialNumber, item.Description, item.Style, item.Category, item.Quantity.ToString(), item.RentalID.ToString() });
                    this.listViewItemsToReturn.Items.Add(lvi);
                }
                if (returnableItems.Count > 0)
                {
                    buttonReturn.Enabled = true;

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching data from database!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PopulateReturnSelection(ListViewItem item)
        {
            SerialNumberLabel.Text = item.SubItems[0].Text;
            QuantityAvailableLabel.Text = item.SubItems[4].Text;
            PopulateQuantityRequired(Int32.Parse(item.SubItems[4].Text));
            currentItem = new ReturnableItem();
            currentItem.SerialNumber = item.SubItems[0].Text;
            currentItem.Description = item.SubItems[1].Text;
            currentItem.Style = item.SubItems[2].Text;
            currentItem.Category = item.SubItems[3].Text;
            currentItem.RentalID = int.Parse(item.SubItems[5].Text);
        }

        private void PopulateQuantityRequired(int quantity)
        {
            ComboBoxRequiredQuantity.Items.Clear();
            ComboBoxRequiredQuantity.SelectedIndex = -1;

            for (int i = 1; i <= quantity; i++)
            {
                ComboBoxRequiredQuantity.Items.Add("" + i);
            }
        }

        private void listViewReturnableItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReturnableItems.SelectedItems.Count > 0)
            {
                this.PopulateReturnSelection(listViewReturnableItems.SelectedItems[0]);
                buttonAddToReturn.Enabled = true;
            }



        }

        private void buttonAddToReturn_Click(object sender, EventArgs e)
        {

            currentItem.Quantity = int.Parse(ComboBoxRequiredQuantity.Text);
            itemsToReturn.Add(currentItem);
            this.RefreshListViewItemsToReturn();
        }
    }
}
