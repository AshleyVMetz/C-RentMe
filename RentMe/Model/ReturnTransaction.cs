using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
    public class ReturnTransaction
    {
        public int ReturnID { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal FineDueTotal { get; set; }
        public decimal RefundDueTotal { get; set; }
        public int EmployeeID { get; set; }
       
    }
}
