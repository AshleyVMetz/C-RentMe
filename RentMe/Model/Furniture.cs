using System;

namespace RentMe.Model
{
    /// <summary>
    /// Model class for Furniture
    /// </summary>
    class Furniture
    {
        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public Double FineRate { get; set; }

        public Double DailyRentalRate { get; set; }

        public int Quantity { get; set; }

        public int CategoryID { get; set; }

        public string Category { get; set; }

        public int StyleID { get; set; }

        public string Style { get; set; }
    }
}
