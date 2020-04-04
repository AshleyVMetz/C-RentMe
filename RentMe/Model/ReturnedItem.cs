using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a ReturnedItem.
    /// </summary>
    class ReturnedItem
    {
        /// <summary>
        /// Accessors for ReturnedItem instance variables.
        /// </summary>
        public int ReturnID { get; }
        public int RentalID { get; }
        public DateTime ReturnDate { get; }
        public DateTime ScheduledReturn { get; }
        public string EmployeeFullName { get; }
        public string ItemDescription { get; }
        public int ItemQuantity { get; }
        public decimal FineDue { get; }
        public decimal RefundDue { get; }

        /// <summary>
        /// Constructor method.
        /// </summary>
        /// <param name="returnID">The ID of the return.</param>
        /// <param name="rentalID">The ID of the rental.</param>
        /// <param name="returnDate">The date of the return.</param>
        /// <param name="scheduledReturn">The scheduled return date of the rental.</param>
        /// <param name="employeeFullName">The full name of the employee who accepted the return of the item(s).</param>
        /// <param name="itemDescription">The description of the item returned.</param>
        /// <param name="itemQuantity">The quantity of the item returned.</param>
        /// <param name="fineDue">The fine due for the item returned.</param>
        /// <param name="refundDue">The refund due for the item returned.</param>
        public ReturnedItem(int returnID, int rentalID, DateTime returnDate, DateTime scheduledReturn, string employeeFullName, string itemDescription,
                            int itemQuantity, decimal fineDue, decimal refundDue)
        {
            this.ReturnID = returnID;
            this.RentalID = rentalID;
            this.ReturnDate = returnDate;
            this.ScheduledReturn = scheduledReturn;
            this.EmployeeFullName = employeeFullName;
            this.ItemDescription = itemDescription;
            this.ItemQuantity = itemQuantity;
            this.FineDue = fineDue;
            this.RefundDue = refundDue;
        }
    }
}
