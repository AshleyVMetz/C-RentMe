﻿namespace RentMe.Model
{
    /// <summary>
    /// This class models an item that can be returned.
    /// </summary>
    public class ReturnableItem
    {
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public int RentalID { get; set; }
        public string Description { get; set; }
        public string Style { get; set; }
        public string Category { get; set; }


    }
}
