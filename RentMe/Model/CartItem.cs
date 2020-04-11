using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
    public class CartItem
    {
        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public Double DailyRentalRate { get; set; }
    }
}
