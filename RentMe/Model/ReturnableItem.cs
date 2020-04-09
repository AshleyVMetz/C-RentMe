using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
    public class ReturnableItem
    {
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public int RentalID { get; set; }

    }
}
