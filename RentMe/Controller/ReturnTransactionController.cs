using RentMe.DAL;
using RentMe.Model;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Controller class to mediate between ReturnTransactionDAL and View.
    /// </summary>
    class ReturnTransactionController
    {
        private ReturnTransactionDAL returnDataSource;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public ReturnTransactionController()
        {
            this.returnDataSource = new ReturnTransactionDAL();
        }

        /// <summary>
        /// This method returns a list of returned items from the return transactions with the specified StoreMemberID.
        /// </summary>
        /// <param name="storeMemberID">The ID of the StoreMember.</param>
        /// <returns>A list of returned items from the return transactions with the specified StoreMemberID.</returns>
        public List<ReturnedItem> GetReturnTransactionsWithItemsByStoreMemberID(string storeMemberID)
        {
            return this.returnDataSource.GetReturnTransactionsWithItemsByStoreMemberID(int.Parse(storeMemberID));
        }
    }
}
