using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    class StoreMemberController
    {
        private readonly StoreMemberDAL storeMemberDAL;

        public StoreMemberController()
        {
            this.storeMemberDAL = new StoreMemberDAL();
        }

        /// <summary>
        /// Inserts Store Member to Database
        /// </summary>
        /// <param name="storeMember">store member entered by employee</param>
        public void Add(StoreMember storeMember)
        {
            if (storeMember == null)
            {
                throw new ArgumentNullException("Store Member cannot be empty");
            }

            if (!this.storeMemberDAL.AddStoreMember(storeMember))
            {
                throw new Exception("Unable to insert data");
            }

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
        /// <returns>StoreMember Object</returns>
        public StoreMember GetStoreMemberByPhoneNumber(string phoneNumber)
        {
            return this.storeMemberDAL.GetStoreMemberByPhoneNumber(phoneNumber);
        }

        /// <summary>
        /// Get Store Member details using Name
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>StoreMember Object</returns>
        public StoreMember GetStoreMemberByName(string firstName, string lastName)
        {
            return this.storeMemberDAL.GetStoreMemberByName(firstName, lastName);
        }

     }
}
