using System;
using System.Text.RegularExpressions;
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

            string phoneNumber = Regex.Replace(storeMember.Phone, @"[^0-9]+", "");

            if (phoneNumber.Length != 10)
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

            if (GetDifferenceInYears(storeMember.Dob, DateTime.Now) < 18)
            {
                MessageBox.Show("Customer below 18 years cannot be registered!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (storeMember.Address1.Trim().Length < 1 ||
                storeMember.City.Trim().Length < 1 ||
                storeMember.State.Trim().Length < 1 ||
                storeMember.Zip.Trim().Length < 1)
            {
                MessageBox.Show("All mandatory address fields should be filled!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (!Regex.IsMatch(storeMember.Zip, @"^(\d{5}(?:\-\d{4})?)$"))
            {
                MessageBox.Show("Invalid Zip code Should be in the format 11111 or 11111-1111!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (storeMember.Sex.Trim().Length < 1)
            {
                MessageBox.Show("Gender has to be selected!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        public static Boolean ValidateReturn(ReturnItem returnItem)
        {
            if (returnItem.SerialNumber.Trim().Length < 1)
            {
                MessageBox.Show("Serial Number cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (returnItem.RentalID.ToString().Trim().Length < 1)
            {
                MessageBox.Show("RentalID cannot be empty!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
           
            return false;
        }

        private static int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            int years = endDate.Year - startDate.Year;

            if (startDate.Month == endDate.Month &&
                endDate.Day < startDate.Day || endDate.Month < startDate.Month)
            {
                years--;
            }

            return years;
        }

        public static Boolean ValidateCartItem(CartItem item)
        {
            if (item.SerialNumber.Equals("") || item.Description.Equals("") || item.DailyRentalRate <= 0)
            {
                MessageBox.Show("Select an item before adding it to cart!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (item.Quantity <= 0)
            {
                MessageBox.Show("Select quantity to add it to cart!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

    }
}
