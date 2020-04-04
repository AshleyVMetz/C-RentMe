using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentedItem.
    /// </summary>
    class RentedItem
    {
        /// <summary>
        /// Accessors for RentedItem instance variables.
        /// </summary>
        public int RentalID { get; }
        public DateTime DateOfRental { get; }
        public DateTime ScheduledReturn { get; }
        public string EmployeeFullName { get; }
        public string ItemDescription { get; }
        public decimal ItemPrice { get; }
        public int ItemQuantity { get; }

        /// <summary>
        /// Constructor method.
        /// </summary>
        /// <param name="rentalID">The ID of the rental.</param>
        /// <param name="dateOfRental">The date of the rental.</param>
        /// <param name="scheduledReturn">The scheduled return date of the rental.</param>
        /// <param name="employeeFullName">The full name of the employee who rented the item(s).</param>
        /// <param name="itemDescription">The description of the item rented.</param>
        /// <param name="itemPrice">The price of the item rented.</param>
        /// <param name="itemQuantity">The quantity of the item rented.</param>
        public RentedItem(int rentalID, DateTime dateOfRental, DateTime scheduledReturn, string employeeFullName, string itemDescription,
                          decimal itemPrice, int itemQuantity)
        {
            this.RentalID = rentalID;
            this.DateOfRental = dateOfRental;
            this.ScheduledReturn = scheduledReturn;
            this.EmployeeFullName = employeeFullName;
            this.ItemDescription = itemDescription;
            this.ItemPrice = itemPrice;
            this.ItemQuantity = itemQuantity;
        }
    }
}
