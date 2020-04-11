using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Controller class to mediate between RentalTransactionDAL and View.
    /// </summary>
    class RentalTransactionController
    {
        private RentalTransactionDAL rentalDataSource;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public RentalTransactionController()
        {
            this.rentalDataSource = new RentalTransactionDAL();
        }

        /// <summary>
        /// This method returns a list of rented items from the rental transactions with the specified StoreMemberID.
        /// </summary>
        /// <param name="storeMemberID">The ID of the StoreMember.</param>
        /// <returns>A list of rented items from the rental transactions with the specified StoreMemberID.</returns>
        public List<RentedItem> GetRentalTransactionsWithItemsByStoreMemberID(string storeMemberID)
        {
            return this.rentalDataSource.GetRentalTransactionsWithItemsByStoreMemberID(int.Parse(storeMemberID));
        }

        public Item GetRentalTransactionByRentalID(int rentalID)
        {
            return this.rentalDataSource.GetRentalTransactionByRentalID(rentalID);
        }

        internal List<int> GetRentalIDListByMemberID(int memberID)
        {
            return this.rentalDataSource.GetRentalIDListByMemberID(memberID);
        }

        /// <summary>
        /// Inserts cart items to rental tables
        /// </summary>
        /// <param name="cart">Cart containing rental items</param>
        /// <returns>true if everything got inserted correctly else if there is any exception</returns>
        public Boolean InsertRentalTransaction(Cart cart)
        {
            return this.rentalDataSource.InsertRentalTransaction(cart);
        }
    
    }
}
