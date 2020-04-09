using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// DAL class to mediate between RentalTransaction table in the database and Controller.
    /// </summary>
    class RentalTransactionDAL
    {
        /// <summary>
        /// This method returns a list of rented items from the rental transactions with the specified StoreMemberID.
        /// </summary>
        /// <param name="storeMemberID">The ID of the StoreMember.</param>
        /// <returns>A list of rented items from the rental transactions with the specified StoreMemberID.</returns>
        public List<RentedItem> GetRentalTransactionsWithItemsByStoreMemberID(int storeMemberID)
        {
            List<RentedItem> rentedList = new List<RentedItem>();
            string selectStatement =
                "SELECT RentalTransaction.RentalID AS RentalID, RentalTransaction.DateOfRental AS DateOfRental, RentalTransaction.ScheduledReturn AS ScheduledReturn, " +
                       "Employees.FName AS EmployeeFirst, Employees.LName AS EmployeeLast, FurnitureItem.Description AS ItemDescription, " +
                       "FurnitureItem.DailyRentalRate AS ItemPrice, RentedItem.Quantity AS ItemQuantity " +
                "FROM RentalTransaction " +
                "LEFT JOIN Employees ON RentalTransaction.EmployeeID=Employees.EmployeeID " +
                "LEFT JOIN RentedItem ON RentalTransaction.RentalID=RentedItem.RentalID " +
                "LEFT JOIN FurnitureItem ON RentedItem.Serial#=FurnitureItem.Serial# " +
                "WHERE RentalTransaction.MemberID=@memberID " +
                "ORDER BY RentalID ASC; ";
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
                            int rentalID = reader.GetInt32(0);
                            DateTime dateOfRental = (DateTime)reader["DateOfRental"];
                            DateTime scheduledReturn = (DateTime)reader["ScheduledReturn"];
                            string employeeFullName = reader["EmployeeFirst"].ToString() + " " + reader["EmployeeLast"].ToString();
                            string itemDescription = reader["ItemDescription"].ToString();
                            decimal itemPrice = reader.GetDecimal(6);
                            int itemQuantity = reader.GetInt32(7);
                            RentedItem rentedItem = new RentedItem(rentalID, dateOfRental, scheduledReturn, employeeFullName, itemDescription, itemPrice, itemQuantity);
                            rentedList.Add(rentedItem);
                        }
                    }
                }
            }
            return rentedList;
        }

        internal List<int> GetRentalIDListByMemberID(int memberID)
        {
            List<int> list = new List<int>();
            string selectStatement =
                @"SELECT RentalID FROM RentalTransaction Where MemberID = @memberID; ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rentalID = int.Parse(reader["RentalID"].ToString());
                            list.Add(rentalID);
                        }
                    }
                }
            }
            return list;
        }
    

        public Item GetRentalTransactionByRentalID(int rentalID)
        {
            Item item = new Item();
            string selectStatement =
                "SELECT ScheduledReturn " +
                "FROM RentalTransaction " +
                "WHERE RentalTransaction.RentalID=@rentalID ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@rentalID", rentalID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                           
                            item.ScheduledReturn = (DateTime)reader["ScheduledReturn"];
                           
                        }
                    }
                }
            }
            return item;
        }
    }
    
}
