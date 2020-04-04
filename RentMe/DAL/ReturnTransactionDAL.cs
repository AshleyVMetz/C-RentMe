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
    }
}