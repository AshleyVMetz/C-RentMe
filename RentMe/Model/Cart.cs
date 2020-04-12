using System;
using System.Collections.Generic;

namespace RentMe.Model
{
    /// <summary>
    /// Class which represents Cart containing all Cart Items and related details
    /// </summary>
    public class Cart
    {
        public List<CartItem> Items { get; set; }

        public int MemberID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public Double TotalRentalAmount { get; set; }
    }
}
