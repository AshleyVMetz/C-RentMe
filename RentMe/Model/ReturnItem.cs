namespace RentMe.Model
{
    /// <summary>
    /// This class models an item that is returned.
    /// </summary>
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
