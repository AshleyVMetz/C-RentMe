using RentMe.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class is the DAL layer for return.
    /// </summary>
    class ReturnDAL
    {
        /// <summary>
        /// This method creates a return item
        /// </summary>
        /// <param name="returnItem">A ReturnItem</param>
        /// <returns>true or false</returns>
        public bool CreateReturnItem(ReturnItem returnItem)

        {

            string insertStatement =
            @"INSERT INTO dbo.Returns
            (Serial#
             , RentalID
             , ReturnID
             , Quantity
             , FineDue
             , RefundDue) 
            SELECT
           @serial#
           ,@rentalID
           ,@returnID
           ,@quantity
           ,@fineDue
           ,@refundDue
		   WHERE @quantity <= (SELECT  
           i.Quantity - coalesce(
           (
          SELECT SUM(Quantity) From Returns WHERE Serial# = i.Serial# AND RentalID = i.RentalID
           ),0) AS Quantity
           From RentedItem i Where i.RentalID = @rentalID AND (i.Quantity - coalesce(
           (
           SELECT SUM(Quantity) From Returns WHERE Serial# = i.Serial# AND RentalID = i.RentalID
           ),0) > 0) AND Serial# = @serial#);";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())

            {

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))

                {
                    cmd.Parameters.AddWithValue("@serial#", returnItem.SerialNumber);
                    cmd.Parameters.AddWithValue("@rentalID", returnItem.RentalID);
                    cmd.Parameters.AddWithValue("@returnID", returnItem.ReturnID);
                    cmd.Parameters.AddWithValue("@quantity", returnItem.Quantity);
                    cmd.Parameters.AddWithValue("@fineDue", returnItem.FineDue);
                    cmd.Parameters.AddWithValue("@refundDue", returnItem.RefundDue);

                    var result = cmd.ExecuteNonQuery();
                    connection.Close();
                    return result > 0;
                }
            }

        }

        /// <summary>
        /// This method gets a list of returnable items by rental ID.
        /// </summary>
        /// <param name="rentalID">rentalID</param>
        /// <returns>A List</returns>
        internal List<ReturnableItem> GetReturnableItemsByRentalID(int rentalID)
        {
            List<ReturnableItem> returnableItemList = new List<ReturnableItem>();
            string selectStatement =
                @"SELECT i.Serial#, 
                 i.Quantity - coalesce(
                 (
                 SELECT SUM(Quantity) From Returns WHERE Serial# = i.Serial# AND RentalID = i.RentalID
                 ),0) AS Quantity
                From RentedItem i Where i.RentalID = @rentalID AND (i.Quantity - coalesce(
                 (
                 SELECT SUM(Quantity) From Returns WHERE Serial# = i.Serial# AND RentalID = i.RentalID
                 ),0) > 0) ";
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
                            var returnableItem = new ReturnableItem();
                            returnableItem.SerialNumber = reader["Serial#"].ToString();
                            returnableItem.Quantity = int.Parse(reader["Quantity"].ToString());
                            returnableItem.RentalID = rentalID;
                            returnableItemList.Add(returnableItem);
                        }
                    }
                }
            }
            return returnableItemList;
        }
    }

}

