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
                    if (result > 0)
                    {
                        UpdateFurnitureQuantity(returnItem);
                    }
                    return result > 0;
                }
            }

        }

        public bool UpdateFurnitureQuantity(ReturnItem returnItem)

        {
            string updateStatement =
                 @"  Update furnitureItem
                 SET Quantity = Quantity + @quantity
                 Where Serial# = @serial#";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())

            {

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))

                {
                    cmd.Parameters.AddWithValue("@serial#", returnItem.SerialNumber);
                   
                    cmd.Parameters.AddWithValue("@quantity", returnItem.Quantity);
                    

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
                 ),0) AS Quantity,
				 f.Description, s.Description As 'Style', c.Description As 'Category'
				 
                From RentedItem i 
                Left Join FurnitureItem f ON i.Serial# = f.Serial#
				JOIN dbo.Style s on f.StyleID = s.StyleID
                JOIN dbo.Category c on f.CategoryID = c.CategoryID
                Where i.RentalID = @rentalID AND (i.Quantity - coalesce(
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
                            returnableItem.Description = reader["Description"].ToString();
                            returnableItem.Style = reader["Style"].ToString();
                            returnableItem.Category = reader["Category"].ToString();
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

