using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    class StoreMemberDAL
    {

        /// <summary>
        /// Adds Store Member to Database
        /// </summary>
        /// <param name="StoreMember">Store Member Object</param>
        /// <returns>true if record got inserted, else false</returns>
        public Boolean AddStoreMember(StoreMember StoreMember)
        {
            string sqlStatement = "INSERT INTO RentMe.dbo.StoreMember (fName, lName, dob, phone, address1, address2, city, state, zip) " +
                "VALUES (@FirstName, @LastName, @Dob, @Phone, @Address1, @Address2, @City, @State, @Zip)";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@FirstName", StoreMember.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", StoreMember.LastName);
                    sqlCommand.Parameters.AddWithValue("@Dob", StoreMember.Dob);
                    sqlCommand.Parameters.AddWithValue("@Phone", StoreMember.Phone);
                    sqlCommand.Parameters.AddWithValue("@Address1", StoreMember.Address1);
                    sqlCommand.Parameters.AddWithValue("@Address2", StoreMember.Address2);
                    sqlCommand.Parameters.AddWithValue("@City", StoreMember.City);
                    sqlCommand.Parameters.AddWithValue("@State", StoreMember.State);
                    sqlCommand.Parameters.AddWithValue("@Zip", StoreMember.Zip);
                    int execution = sqlCommand.ExecuteNonQuery();

                    if (execution > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
