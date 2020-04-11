using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// DAL class to mediate between ReturnTransaction table in the database and Controller.
    /// </summary>
    class ReturnTransactionDAL
    {
        /// <summary>
        /// This method returns a list of rented items from the rental transactions with the specified StoreMemberID.
        /// </summary>
        /// <param name="storeMemberID">The ID of the StoreMember.</param>
        /// <returns>A list of rented items from the rental transactions with the specified StoreMemberID.</returns>
        public List<ReturnedItem> GetReturnTransactionsWithItemsByStoreMemberID(int storeMemberID)
        {
            List<ReturnedItem> returnedList = new List<ReturnedItem>();
            string selectStatement =
                "SELECT ReturnTransaction.ReturnID AS ReturnID, Returns.RentalID AS RentalID, ReturnTransaction.ReturnDate AS ReturnDate, " +
                       "RentalTransaction.ScheduledReturn AS ScheduledReturn, Employees.FName AS EmployeeFirst, Employees.LName AS EmployeeLast, " +
                       "FurnitureItem.Description AS ItemDescription, Returns.Quantity AS ItemQuantity, " +
                       "Returns.FineDue AS FineDue, Returns.RefundDue AS RefundDue " +
                "FROM ReturnTransaction " +
                "LEFT JOIN Employees ON ReturnTransaction.EmployeeID=Employees.EmployeeID " +
                "LEFT JOIN Returns ON ReturnTransaction.ReturnID=Returns.ReturnID " +
                "LEFT JOIN RentalTransaction ON Returns.RentalID=RentalTransaction.RentalID " +
                "LEFT JOIN FurnitureItem ON Returns.Serial#=FurnitureItem.Serial# " +
                "WHERE RentalTransaction.MemberID=@memberID " +
                "ORDER BY ReturnID ASC, RentalID ASC; ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", storeMemberID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int returnID = reader.GetInt32(0);
                            int rentalID = reader.GetInt32(1);
                            DateTime returnDate = (DateTime)reader["ReturnDate"];
                            DateTime scheduledReturn = (DateTime)reader["ScheduledReturn"];
                            string employeeFullName = reader["EmployeeFirst"].ToString() + " " + reader["EmployeeLast"].ToString();
                            string itemDescription = reader["ItemDescription"].ToString();
                            int itemQuantity = reader.GetInt32(7);
                            decimal fineDue = reader.GetDecimal(8);
                            decimal refundDue = reader.GetDecimal(9);
                            ReturnedItem returnedItem = new ReturnedItem(returnID, rentalID, returnDate, scheduledReturn, employeeFullName, itemDescription, itemQuantity, fineDue, refundDue);
                            returnedList.Add(returnedItem);
                        }
                    }
                }
            }
            return returnedList;
        }

        /// <summary>
        /// This method updates a return transaction.
        /// </summary>
        /// <param name="transaction">A return transaction</param>

        internal void UpdateTransaction(ReturnTransaction transaction)
        {
            string updateStatement =
                @"Update [dbo].[ReturnTransaction] 
                SET [FineDueTotal] = @newFineDueTotal,
                [RefundDueTotal]=@newRefundDueTotal
                Where ReturnID = @returnID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@newFineDueTotal", transaction.FineDueTotal);
                    cmd.Parameters.AddWithValue("@newRefundDueTotal", transaction.RefundDueTotal);
                    cmd.Parameters.AddWithValue("@returnID", transaction.ReturnID);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// This method creates a return transaction.
        /// </summary>
        /// <param name="transaction">A return transaction</param>
        /// <returns>The return transaction ID</returns>
        public int CreateReturnTransaction(ReturnTransaction transaction)
        {
            string insertStatement =
           @"INSERT INTO dbo.ReturnTransaction
            (ReturnDate
             , FineDueTotal
             , RefundDueTotal
             , EmployeeID ) 
            VALUES
           (@returnDate
           ,@fineDueTotal
           ,@refundDueTotal
           ,@employeeID ); 
           SELECT SCOPE_IDENTITY()";



            using (SqlConnection connection = RentMeDBConnection.GetConnection())

            {

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))

                {
                    cmd.Parameters.AddWithValue("@returnDate", transaction.ReturnDate);
                    cmd.Parameters.AddWithValue("@fineDueTotal", 0);
                    cmd.Parameters.AddWithValue("@refundDueTotal", 0);
                    cmd.Parameters.AddWithValue("@employeeID", transaction.EmployeeID);
                    var idObject = cmd.ExecuteScalar();
                    var id = int.Parse(idObject.ToString());
                    connection.Close();
                    return id;
                }

            }

        }
    }
}