using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a store member.
    /// </summary>
    class StoreMember
    {
        public int MemberID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string Phone { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Sex { get; set; }
    }
}
