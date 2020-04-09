using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    class ReturnDAL
    {
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

        /*internal List<ReturnableItem> GetReturnableItemsByRentalIDList(List<int> rentalIDList)
        {
            List<ReturnableItem> returnableItemList = new List<ReturnableItem>();
            string selectStatement =
                @"SELECT i.Serial#, 
                 i.Quantity - coalesce(
                 (
                 SELECT SUM(Quantity) From Returns WHERE Serial# = i.Serial# AND RentalID = i.RentalID
                 ),0) AS Quantity
                From RentedItem i Where i.RentalID IN (@rentalID) AND (i.Quantity - coalesce(
                 (
                 SELECT SUM(Quantity) From Returns WHERE Serial# = i.Serial# AND RentalID = i.RentalID
                 ),0) > 0) ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@rentalID", String.Join(",", rentalIDList));
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var returnableItem = new ReturnableItem();
                            returnableItem.SerialNumber = reader["Serial#"].ToString();
                            returnableItem.Quantity = int.Parse(reader["Quantity"].ToString());

                            returnableItemList.Add(returnableItem);
                        }
                    }
                }
            }
            return returnableItemList;
        }*/

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

