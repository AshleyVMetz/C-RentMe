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
        /// <summary>
        /// This method provides store member validation.
        /// </summary>
        /// <param name="storeMember">The store member to be validated.</param>
        /// <returns>False if and only if all parameters are valid.</returns>
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
        
        /// <summary>
        /// This method returns the difference between dates in years.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>The difference between dates in years.</returns>
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

        /// <summary>
        /// This method provides cart item validation.
        /// </summary>
        /// <param name="item">The item to be validated.</param>
        /// <returns>False if and only if all parameters are valid.</returns>
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

        /// <summary>
        /// This method provides cart validation.
        /// </summary>
        /// <param name="item">The cart to be validated.</param>
        /// <returns>False if and only if all parameters are valid.</returns>
        public static Boolean ValidateCart(Cart cart)
        {
            DateTime today = DateTime.Now;

            if (cart.RentalStartDate.Year < today.Year ||
                cart.RentalStartDate.Month < today.Month ||
                cart.RentalStartDate.Day < today.Day)
            {
                MessageBox.Show("Rental start date cannot be before today!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (cart.RentalEndDate.Year < cart.RentalStartDate.Year ||
                cart.RentalEndDate.Month < cart.RentalStartDate.Month ||
                cart.RentalEndDate.Day < cart.RentalStartDate.Day)
            {
                MessageBox.Show("Rental end date cannot be before Rental start date!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            int rentalDays = (int) Math.Round(cart.RentalEndDate.Subtract(cart.RentalStartDate).TotalDays);

            if (rentalDays == 0)
            {
                MessageBox.Show("Furnitures should be rented at least for a day!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (cart.Items.Count == 0)
            {
                MessageBox.Show("Add furniture to cart before checkout!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (cart.MemberID <= 0)
            {
                MessageBox.Show("Enter Customer Id before checkout!!!!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }
}
