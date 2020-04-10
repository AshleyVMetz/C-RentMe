using RentMe.Model;
using System;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for StoreMember
    /// </summary>
    class StoreMemberDAL
    {

        /// <summary>
        /// Adds Store Member to Database
        /// </summary>
        /// <param name="StoreMember">Store Member Object</param>
        /// <returns>true if record got inserted, else false</returns>
        public Boolean AddStoreMember(StoreMember StoreMember)
        {
            string sqlStatement = "INSERT INTO dbo.StoreMembers (fName, lName, dob, phone, address1, address2, city, state, zipcode, sex) " +
                "VALUES (@FirstName, @LastName, @Dob, @Phone, @Address1, @Address2, @City, @State, @Zip, @Sex)";

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
                    sqlCommand.Parameters.AddWithValue("@Sex", StoreMember.Sex);
                    int execution = sqlCommand.ExecuteNonQuery();

                    if (execution > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Get Store Member details using Customer Id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns>StoreMember Object</returns>
        public StoreMember GetStoreMemberByCustomerId(int customerId)
        {
            StoreMember storeMember = null;

            string selectStatement =
                "select * from dbo.StoreMembers WHERE MemberID = @MemberID ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@MemberID", customerId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            storeMember = this.RetrieveStoreMember(reader);
                        }
                    }
                }
            }

            return storeMember;
        }

        /// <summary>
        /// Get Store Member details using Phone Number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>StoreMember Object</returns>
        public StoreMember GetStoreMemberByPhoneNumber(string phoneNumber)
        {
            StoreMember storeMember = null;
            int counter = 0;

            string selectStatement =
                "select * from dbo.StoreMembers WHERE Phone = @Phone ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Phone", phoneNumber);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            counter++;
                            if (counter > 1)
                            {
                                throw new ArgumentException("There is more than 1 store member with that phone. Please search by another criteria.");
                            }
                            storeMember = this.RetrieveStoreMember(reader);
                        }
                    }
                }
            }

            return storeMember;
        }

        /// <summary>
        /// Get Store Member details using Name
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>StoreMember Object</returns>
        public StoreMember GetStoreMemberByName(string firstName, string lastName)
        {
            StoreMember storeMember = null;
            int counter = 0;

            string selectStatement =
                "select * from dbo.StoreMembers WHERE lower(FName) = lower(@FirstName) and lower(LName) = lower(@LastName) ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@FirstName", firstName);
                    selectCommand.Parameters.AddWithValue("@LastName", lastName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            counter++;
                            if (counter > 1)
                            {
                                throw new ArgumentException("There is more than 1 store member by that name. Please search by another criteria.");
                            }
                            storeMember = this.RetrieveStoreMember(reader);
                        }
                    }
                }
            }

            return storeMember;
        }

        /// <summary>
        /// Update Store Member Information
        /// </summary>
        /// <param name="storeMember">Store Member Object</param>
        /// <returns>true if storeMember got successfully updated else false</returns>
        public Boolean UpdateStoreMember(StoreMember storeMember)
        {
            string sqlStatement = "UPDATE dbo.StoreMembers set FName = @FName, LName = @LName, Phone = @Phone, Address1 = @Address1, Address2 = @Address2, City=@City, State=@State, ZipCode=@ZipCode, DOB=@DOB, Sex=@Sex WHERE MemberID=@MemberId ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@FName", storeMember.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LName", storeMember.LastName);
                    sqlCommand.Parameters.AddWithValue("@Phone", storeMember.Phone);
                    sqlCommand.Parameters.AddWithValue("@Address1", storeMember.Address1);
                    sqlCommand.Parameters.AddWithValue("@Address2", storeMember.Address2);
                    sqlCommand.Parameters.AddWithValue("@City", storeMember.City);
                    sqlCommand.Parameters.AddWithValue("@State", storeMember.State);
                    sqlCommand.Parameters.AddWithValue("@ZipCode", storeMember.Zip);
                    sqlCommand.Parameters.AddWithValue("@DOB", storeMember.Dob);
                    sqlCommand.Parameters.AddWithValue("@MemberId", storeMember.MemberID);
                    sqlCommand.Parameters.AddWithValue("@Sex", storeMember.Sex);

                    int execution = sqlCommand.ExecuteNonQuery();

                    if (execution > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private StoreMember RetrieveStoreMember(SqlDataReader reader)
        {
            StoreMember storeMember = new StoreMember();
            storeMember.MemberID = Convert.ToInt32(reader["MemberID"]);
            storeMember.FirstName = reader["FName"].ToString();
            storeMember.LastName = reader["LName"].ToString();
            storeMember.Phone = reader["Phone"].ToString();
            storeMember.Address1 = reader["Address1"].ToString();
            storeMember.Address2 = reader["Address2"].ToString();
            storeMember.City = reader["City"].ToString();
            storeMember.State = reader["State"].ToString();
            storeMember.Zip = reader["ZipCode"].ToString();
            storeMember.Dob = (DateTime)reader["DOB"];
            storeMember.Sex = reader["Sex"].ToString();

            return storeMember;
        }

    }
}
