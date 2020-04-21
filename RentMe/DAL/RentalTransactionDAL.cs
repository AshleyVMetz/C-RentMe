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
                       "Employees.FName AS EmployeeFirst, Employees.LName AS EmployeeLast, FurnitureItem.Serial# AS ItemSerial, FurnitureItem.Description AS ItemDescription, " +
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
                            string itemSerial = reader["ItemSerial"].ToString();
                            string itemDescription = reader["ItemDescription"].ToString();
                            decimal itemPrice = reader.GetDecimal(7);
                            int itemQuantity = reader.GetInt32(8);
                            RentedItem rentedItem = new RentedItem(rentalID, dateOfRental, scheduledReturn, employeeFullName, itemSerial, itemDescription, itemPrice, itemQuantity);
                            rentedList.Add(rentedItem);
                        }
                    }
                }
            }
            return rentedList;
        }

        /// <summary>
        /// This method gets a list of rental id by member id.
        /// </summary>
        /// <param name="memberID">memberID</param>
        /// <returns>A list</returns>
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

        /// <summary>
        /// This method gets a rental transaction by rental ID.
        /// </summary>
        /// <param name="rentalID">rentalID</param>
        /// <returns>A Rental Item</returns>
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

        /// <summary>
        /// Inserts cart items to rental tables
        /// </summary>
        /// <param name="cart">Cart containing rental items</param>
        /// <returns>true if everything got inserted correctly else if there is any exception</returns>
        public Boolean InsertRentalTransaction(Cart cart)
        {
            int rentalTransactionId = 0;
            string insertRentalTransactionStatement =
                "insert into dbo.RentalTransaction (DateOfRental, ScheduledReturn, EmployeeID, MemberID) " +
                "VALUES (@RentalStartDate, @RentalEndDate, @EmployeeId, @MemberId); SELECT SCOPE_IDENTITY() ";

            string insertRentalItemStatement =
                "insert into dbo.RentedItem (Serial#, RentalID, Quantity) VALUES (@SerialNumber, @RentalId, @Quantity) ";

            string updateQuantity =
                "update dbo.FurnitureItem set Quantity = (Quantity-@Quantity) where Serial# = @SerialNumber";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction("RentalTransaction");

                try
                {
                    using (SqlCommand insertCommand = new SqlCommand(insertRentalTransactionStatement, connection, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@RentalStartDate", cart.RentalStartDate);
                        insertCommand.Parameters.AddWithValue("@RentalEndDate", cart.RentalEndDate);
                        insertCommand.Parameters.AddWithValue("@EmployeeId", cart.EmployeeID);
                        insertCommand.Parameters.AddWithValue("@MemberId", cart.MemberID);

                        rentalTransactionId = Convert.ToInt32(insertCommand.ExecuteScalar());
                    }

                    foreach (CartItem item in cart.Items)
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertRentalItemStatement, connection, transaction))
                        {
                            insertCommand.Parameters.AddWithValue("@SerialNumber", item.SerialNumber);
                            insertCommand.Parameters.AddWithValue("@RentalId", rentalTransactionId);
                            insertCommand.Parameters.AddWithValue("@Quantity", item.Quantity);

                            insertCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand updateCommand = new SqlCommand(updateQuantity, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@SerialNumber", item.SerialNumber);
                            updateCommand.Parameters.AddWithValue("@Quantity", item.Quantity);

                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine(" Exception Type: {0}", ex.GetType());
                    Console.WriteLine(" Message: {0}", ex.Message);
                    return false;
                }
            }

            return true;
        }
    }
}
