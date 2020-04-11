using System.Windows.Forms;

namespace RentMe.Util
{
    /// <summary>
    /// This is a Utility class used for Combo Box related functionalities
    /// </summary>
    class ComboBoxUtil
    {

        /// <summary>
        /// Populates State ComboBox with US states values
        /// </summary>
        public static void UpdateStateComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("AL");
            comboBox.Items.Add("AK");
            comboBox.Items.Add("AZ");
            comboBox.Items.Add("AR");
            comboBox.Items.Add("CA");
            comboBox.Items.Add("CO");
            comboBox.Items.Add("CT");
            comboBox.Items.Add("DE");
            comboBox.Items.Add("FL");
            comboBox.Items.Add("GA");
            comboBox.Items.Add("HI");
            comboBox.Items.Add("ID");
            comboBox.Items.Add("IL");
            comboBox.Items.Add("IN");
            comboBox.Items.Add("IA");
            comboBox.Items.Add("KS");
            comboBox.Items.Add("KY");
            comboBox.Items.Add("LA");
            comboBox.Items.Add("ME");
            comboBox.Items.Add("MD");
            comboBox.Items.Add("MA");
            comboBox.Items.Add("MI");
            comboBox.Items.Add("MN");
            comboBox.Items.Add("MS");
            comboBox.Items.Add("MO");
            comboBox.Items.Add("MT");
            comboBox.Items.Add("NE");
            comboBox.Items.Add("NV");
            comboBox.Items.Add("NH");
            comboBox.Items.Add("NJ");
            comboBox.Items.Add("NY");
            comboBox.Items.Add("NM");
            comboBox.Items.Add("NC");
            comboBox.Items.Add("ND");
            comboBox.Items.Add("OH");
            comboBox.Items.Add("OK");
            comboBox.Items.Add("OR");
            comboBox.Items.Add("PA");
            comboBox.Items.Add("RI");
            comboBox.Items.Add("SD");
            comboBox.Items.Add("ST");
            comboBox.Items.Add("TN");
            comboBox.Items.Add("TX");
            comboBox.Items.Add("UT");
            comboBox.Items.Add("VT");
            comboBox.Items.Add("VA");
            comboBox.Items.Add("WA");
            comboBox.Items.Add("WV");
            comboBox.Items.Add("WI");
            comboBox.Items.Add("WY");
        }

        /// <summary>
        /// Populates Gender ComboBox with US states values
        /// </summary>
        public static void UpdateGenderComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("Male");
            comboBox.Items.Add("Female");
            comboBox.Items.Add("Not Specified");
        }
    }
}
