using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
   public class ReturnItem
    {
        public string SerialNumber { get; set; }
        public int ReturnID { get; set; }
        public int RentalID { get; set; }
        public int Quantity { get; set; }
        public decimal FineDue { get; set; }
        public decimal RefundDue { get; set; }
    }
}
