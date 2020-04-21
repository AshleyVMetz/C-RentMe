using RentMe.Model;
using RentMe.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// This class models a form when multiple store members meet the search criterion.
    /// </summary>
    public partial class StoreMemberPicker : Form
    {
        private List<StoreMember> StoreMembers;
        private EditStoreMember EditStoreMember;

        /// <summary>
        /// Controller method.
        /// </summary>
        public StoreMemberPicker(List<StoreMember> storeMembers, EditStoreMember editStoreMember)
        {
            InitializeComponent();
            this.StoreMembers = storeMembers;
            this.RefreshListView();
            this.EditStoreMember = editStoreMember;
        }

        /// <summary>
        /// This helper method refreshes the returned store members.
        /// </summary>
        private void RefreshListView()
        {
            this.storeMemberListView.Items.Clear();
            try
            {
                foreach (var member in this.StoreMembers)
                {
                    var lvi = new ListViewItem(new[] { member.MemberID.ToString(), member.FirstName, member.LastName, member.Phone, member.Dob.ToShortDateString(),
                                                       member.Sex, member.Address1, member.Address2, member.City, member.State, member.Zip });
                    this.storeMemberListView.Items.Add(lvi);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching data from database!!!!",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method selects the store member when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectButton_Click(object sender, System.EventArgs e)
        {
            this.EditStoreMember.SearchSelectedStoreMember(this.storeMemberListView.SelectedItems[0].ToString());
            this.Close();
        }

        /// <summary>
        /// This method returns to the prior form when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method returns to the prior form when this form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreMemberPicker_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
