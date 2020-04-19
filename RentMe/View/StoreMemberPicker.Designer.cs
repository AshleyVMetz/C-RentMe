namespace RentMe.View
{
    partial class StoreMemberPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.storeMemberListView = new System.Windows.Forms.ListView();
            this.memberID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Multiple store members match that search criterion. Please select the Member ID o" +
    "f correct member from the list.";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(685, 415);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(766, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // storeMemberListView
            // 
            this.storeMemberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberID,
            this.fName,
            this.lName,
            this.phone,
            this.dob,
            this.sex,
            this.address1,
            this.address2,
            this.city,
            this.state,
            this.zip});
            this.storeMemberListView.HideSelection = false;
            this.storeMemberListView.Location = new System.Drawing.Point(12, 25);
            this.storeMemberListView.MultiSelect = false;
            this.storeMemberListView.Name = "storeMemberListView";
            this.storeMemberListView.Size = new System.Drawing.Size(829, 384);
            this.storeMemberListView.TabIndex = 4;
            this.storeMemberListView.UseCompatibleStateImageBehavior = false;
            this.storeMemberListView.View = System.Windows.Forms.View.Details;
            // 
            // memberID
            // 
            this.memberID.Text = "Member ID";
            this.memberID.Width = 65;
            // 
            // fName
            // 
            this.fName.Text = "First Name";
            this.fName.Width = 80;
            // 
            // lName
            // 
            this.lName.Text = "Last Name";
            this.lName.Width = 80;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 80;
            // 
            // dob
            // 
            this.dob.Text = "DOB";
            this.dob.Width = 80;
            // 
            // sex
            // 
            this.sex.Text = "Sex";
            this.sex.Width = 80;
            // 
            // address1
            // 
            this.address1.Text = "Address 1";
            this.address1.Width = 100;
            // 
            // address2
            // 
            this.address2.Text = "Address 2";
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 80;
            // 
            // state
            // 
            this.state.Text = "State";
            this.state.Width = 40;
            // 
            // zip
            // 
            this.zip.Text = "Zip";
            // 
            // StoreMemberPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.storeMemberListView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreMemberPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Member Picker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoreMemberPicker_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView storeMemberListView;
        private System.Windows.Forms.ColumnHeader memberID;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader lName;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader dob;
        private System.Windows.Forms.ColumnHeader address1;
        private System.Windows.Forms.ColumnHeader address2;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader zip;
    }
}