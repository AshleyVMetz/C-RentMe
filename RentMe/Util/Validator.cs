using System;
using System.Linq;
using System.Windows.Forms;
using RentMe.Model;

namespace RentMe.Util
{
    /// <summary>
    /// Utility class to validate fields
    /// </summary>
    class Validator
    {
        public static Boolean ValidateStoreMember(StoreMember storeMember)
        {
            if (storeMember.FirstName.Trim().Length < 1)
            {
                MessageBox.Show("First Name cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (storeMember.LastName.Trim().Length < 1)
            {
                MessageBox.Show("Last Name cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (storeMember.Phone.Trim().Length < 10)
            {
                MessageBox.Show("Phone should contain 10 digits!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (storeMember.Dob == null)
            {
                MessageBox.Show("Date of Birth cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (storeMember.Address1.Trim().Length < 5 ||
                storeMember.City.Trim().Length < 1 ||
                storeMember.State.Trim().Length < 1 ||
                storeMember.Zip.Trim().Length < 1)
            {
                MessageBox.Show("All mandatory address fields should be filled!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        } 
    }
}
