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
    public partial class Return : UserControl
    {
        ReturnController returnController;
        ReturnTransactionController returnTransactionController;
        FurnitureController furnitureController;
        RentalTransactionController rentalTransactionController;
        EmployeeController employeeController;
        int memberID;
        List<int> rentalIDList;
        List<ReturnableItem> itemsToReturn;
        public Return()
        {
            InitializeComponent();
            this.returnController = new ReturnController();
            this.returnTransactionController = new ReturnTransactionController();
            this.furnitureController = new FurnitureController();
            rentalTransactionController = new RentalTransactionController();
            this.employeeController = new EmployeeController();
            this.LoadEmployees();
            buttonReturn.Enabled = false;
            comboBoxEmployee.Enabled = false;
        }

        private void LoadEmployees()
        {
            var employeeList = new List<Employee>();
            var emptyEmployee = new Employee();
            emptyEmployee.FullName = "--select--";
            employeeList.Add(emptyEmployee);
            var employeeListFromDB = employeeController.GetEmployeeList();
            employeeList.AddRange(employeeListFromDB);
            comboBoxEmployee.DataSource = employeeList;
            comboBoxEmployee.DisplayMember = "FullName";
            comboBoxEmployee.ValueMember = "EmployeeID";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ReturnTransaction transaction = new ReturnTransaction();
            transaction.EmployeeID = int.Parse(comboBoxEmployee.SelectedValue.ToString());
            if (transaction.EmployeeID < 1)
            {
                MessageBox.Show("Please Select An Employee");
                return;
            }
            transaction.ReturnDate = DateTime.Now;
            int returnID = returnTransactionController.CreateReturnTransaction(transaction);
            transaction.ReturnID = returnID;
            itemsToReturn = itemsToReturn.Where(i => i.Quantity > 0).ToList();
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
                    MessageBox.Show("Failed to Return Items. Please make sure the quantity is valid");
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
            labelAmountFineDue.Text = transaction.FineDueTotal.ToString();
            label4AmountRefundDue.Text = transaction.RefundDueTotal.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        static int DayNum(string date, string startDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime dt = DateTime.Parse(date);
            TimeSpan t = dt - start;
            return (int)t.TotalDays;
        }

        public void Clear()
        {
            
            textBoxStoreMemberID.Text = "";
            dataGridViewReturnableItems.DataSource = null;
            dataGridViewReturnableItems.Refresh();
            buttonReturn.Enabled = false;
            comboBoxEmployee.Enabled = false;
           
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            memberID = int.Parse(textBoxStoreMemberID.Text);
            rentalIDList = rentalTransactionController.GetRentalIDListByMemberID(memberID);
            itemsToReturn = new List<ReturnableItem>();
            foreach (var rentalID in rentalIDList)
            {
                var list = returnController.GetReturnableItemsByRentalID(rentalID);
                itemsToReturn.AddRange(list);
            }
            dataGridViewReturnableItems.DataSource = itemsToReturn;
            dataGridViewReturnableItems.Columns[0].ReadOnly = true;
            dataGridViewReturnableItems.Columns[2].ReadOnly = true;
            dataGridViewReturnableItems.Refresh();
            if (itemsToReturn.Count > 0)
            {
                buttonReturn.Enabled = true;
                comboBoxEmployee.Enabled = true;
            }
            else
            {
                MessageBox.Show("No returnable Items");
            }
        }
    }
}
