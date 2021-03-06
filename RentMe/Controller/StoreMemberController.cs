﻿using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Controller class to mediate between StoreMemberDAL and View.
    /// </summary>
    class StoreMemberController
    {
        private readonly StoreMemberDAL storeMemberDAL;

        /// <summary>
        /// Constructor method.
        /// </summary>
        public StoreMemberController()
        {
            this.storeMemberDAL = new StoreMemberDAL();
        }

        /// <summary>
        /// Inserts Store Member to Database
        /// </summary>
        /// <param name="storeMember">store member entered by employee</param>
        public int Add(StoreMember storeMember)
        {
            if (storeMember == null)
            {
                throw new ArgumentNullException("Store Member cannot be empty");
            }

            return this.storeMemberDAL.AddStoreMember(storeMember);

        }

        /// <summary>
        /// Get Store Member details using Customer Id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns>StoreMember Object</returns>
        public StoreMember GetStoreMemberByCustomerId(int customerId)
        {
            return this.storeMemberDAL.GetStoreMemberByCustomerId(customerId);
        }

        /// <summary>
        /// Get Store Member details using Phone Number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>List of StoreMember Objects</returns>
        public List<StoreMember> GetStoreMemberByPhoneNumber(string phoneNumber)
        {
            return this.storeMemberDAL.GetStoreMemberByPhoneNumber(phoneNumber);
        }

        /// <summary>
        /// Get Store Member details using Name
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>List of StoreMember Objects</returns>
        public List<StoreMember> GetStoreMemberByName(string firstName, string lastName)
        {
            return this.storeMemberDAL.GetStoreMemberByName(firstName, lastName);
        }

        /// <summary>
        /// Update Store Member Information
        /// </summary>
        /// <param name="storeMember">Store Member Object</param>
        /// <returns>true if storeMember got successfully updated else false</returns>
        public Boolean UpdateStoreMember(StoreMember storeMember)
        {
            return this.storeMemberDAL.UpdateStoreMember(storeMember);
        }
    }
}
