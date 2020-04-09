using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
   public class Item
    {
        public int RentalID { get; }
     
        public DateTime ScheduledReturn { get; set; }
    }
}
