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
    }
}
