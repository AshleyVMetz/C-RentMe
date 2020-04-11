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

        /// <summary>
        /// This method returns an int of return transaction.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>An int of returnTransactionID</returns>
        internal int CreateReturnTransaction(ReturnTransaction transaction)
        {
            return this.returnDataSource.CreateReturnTransaction(transaction);
        }

        /// <summary>
        /// This method updates the transaction.
        /// </summary>
        /// <param name="transaction"></param>
        internal void UpdateTransaction(ReturnTransaction transaction)
        {
            this.returnDataSource.UpdateTransaction(transaction);
        }
    }
}
