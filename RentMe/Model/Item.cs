using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class is the model for a rental Item with a rentalID and scheduled return.
    /// </summary>
    public class Item
    {
        public int RentalID { get; }
     
        public DateTime ScheduledReturn { get; set; }
    }
}
