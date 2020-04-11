using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    class ReturnController
    {
        /// <summary>
        /// This class is the controller for return.
        /// </summary>
        private ReturnDAL returnDAL;

        public ReturnController()
        {
            this.returnDAL = new ReturnDAL();
        }

        /// <summary>
        /// This method creates a return item
        /// </summary>
        /// <param name="returnItem">item to be returned</param>
        /// <returns>true or false</returns>
        public bool CreateReturnItem(ReturnItem returnItem)
        {
            return this.returnDAL.CreateReturnItem(returnItem);
        }

        internal List<ReturnableItem> GetReturnableItemsByRentalID(int rentalID)
        {
            return returnDAL.GetReturnableItemsByRentalID(rentalID);
        }


    }
}
