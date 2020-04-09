using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    class ReturnController
    {
        private ReturnDAL returnDAL;

        public ReturnController()
        {
            this.returnDAL = new ReturnDAL();
        }

        

       

        public bool CreateReturnItem(ReturnItem returnItem)
        {
            return this.returnDAL.CreateReturnItem(returnItem);
        }

        internal List<ReturnableItem> GetReturnableItemsByRentalID(int rentalID)
        {
            return returnDAL.GetReturnableItemsByRentalID(rentalID);
        }

      /*  internal List<ReturnableItem> GetReturnableItemsByRentalIDList(List<int> rentalIDList)
        {
            return returnDAL.GetReturnableItemsByRentalIDList(rentalIDList);
        }*/
    }
}
