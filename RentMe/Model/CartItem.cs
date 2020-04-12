using System;

namespace RentMe.Model
{
    /// <summary>
    /// Cart Item object to hold individual Cart
    /// </summary>
    public class CartItem
    {
        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public Double DailyRentalRate { get; set; }
    }
}
