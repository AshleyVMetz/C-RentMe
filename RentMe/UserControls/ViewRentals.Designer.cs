namespace RentMe.UserControls
{
    partial class ViewRentals
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rentalListView = new System.Windows.Forms.ListView();
            this.RentalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOfRental = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduledReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // rentalListView
            // 
            this.rentalListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rentalListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RentalID,
            this.dateOfRental,
            this.scheduledReturn,
            this.employeeFullName,
            this.itemDescription,
            this.itemPrice,
            this.itemQuantity,
            this.totalCost});
            this.rentalListView.HideSelection = false;
            this.rentalListView.Location = new System.Drawing.Point(3, 3);
            this.rentalListView.Name = "rentalListView";
            this.rentalListView.Size = new System.Drawing.Size(752, 282);
            this.rentalListView.TabIndex = 0;
            this.rentalListView.UseCompatibleStateImageBehavior = false;
            this.rentalListView.View = System.Windows.Forms.View.Details;
            // 
            // RentalID
            // 
            this.RentalID.Text = "Rental ID";
            this.RentalID.Width = 62;
            // 
            // dateOfRental
            // 
            this.dateOfRental.Text = "Rental Date";
            this.dateOfRental.Width = 100;
            // 
            // scheduledReturn
            // 
            this.scheduledReturn.Text = "Scheduled Return";
            this.scheduledReturn.Width = 100;
            // 
            // employeeFullName
            // 
            this.employeeFullName.Text = "Employee";
            this.employeeFullName.Width = 100;
            // 
            // itemDescription
            // 
            this.itemDescription.Text = "Item Description";
            this.itemDescription.Width = 182;
            // 
            // itemPrice
            // 
            this.itemPrice.Text = "Item Price";
            this.itemPrice.Width = 62;
            // 
            // itemQuantity
            // 
            this.itemQuantity.Text = "Quantity";
            this.itemQuantity.Width = 62;
            // 
            // totalCost
            // 
            this.totalCost.Text = "Total Cost";
            this.totalCost.Width = 62;
            // 
            // ViewRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalListView);
            this.Name = "ViewRentals";
            this.Size = new System.Drawing.Size(758, 288);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView rentalListView;
        private System.Windows.Forms.ColumnHeader RentalID;
        private System.Windows.Forms.ColumnHeader totalCost;
        private System.Windows.Forms.ColumnHeader dateOfRental;
        private System.Windows.Forms.ColumnHeader scheduledReturn;
        private System.Windows.Forms.ColumnHeader employeeFullName;
        private System.Windows.Forms.ColumnHeader itemDescription;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.ColumnHeader itemQuantity;
    }
}
