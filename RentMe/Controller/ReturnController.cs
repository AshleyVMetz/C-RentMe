using RentMe.DAL;
using RentMe.Model;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class is the controller for return.
    /// </summary>
    class ReturnController
    {
        private ReturnDAL returnDAL;

        /// <summary>
        /// Constructor method.
        /// </summary>
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

        /// <summary>
        /// This method returns a list of returnable items by rental ID.
        /// </summary>
        /// <param name="rentalID">The ID of the rental.</param>
        /// <returns>A list of returnable items by rental ID.</returns>
        internal List<ReturnableItem> GetReturnableItemsByRentalID(int rentalID)
        {
            return returnDAL.GetReturnableItemsByRentalID(rentalID);
        }
    }
}
