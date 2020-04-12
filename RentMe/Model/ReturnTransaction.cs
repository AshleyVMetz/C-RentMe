using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a return transaction.
    /// </summary>
    public class ReturnTransaction
    {
        public int ReturnID { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal FineDueTotal { get; set; }
        public decimal RefundDueTotal { get; set; }
        public int EmployeeID { get; set; }

    }
}
