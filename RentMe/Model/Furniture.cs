﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
    /// <summary>
    /// Model class for Furniture
    /// </summary>
    class Furniture
    {
        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public float FineRate { get; set; }

        public float DailyRentalRate { get; set; }

        public int Quantity { get; set; }

        public int CategoryID { get; set; }

        public string Category { get; set; }

        public int StyleID { get; set; }

        public string Style { get; set; }
    }
}