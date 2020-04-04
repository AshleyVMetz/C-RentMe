namespace RentMe.UserControls
{
    partial class ViewReturns
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
            this.returnListView = new System.Windows.Forms.ListView();
            this.RentalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduledReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fineDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refundDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // returnListView
            // 
            this.returnListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.returnID,
            this.RentalID,
            this.returnDate,
            this.scheduledReturn,
            this.employeeFullName,
            this.itemDescription,
            this.itemQuantity,
            this.fineDue,
            this.refundDue});
            this.returnListView.HideSelection = false;
            this.returnListView.Location = new System.Drawing.Point(3, 3);
            this.returnListView.Name = "returnListView";
            this.returnListView.Size = new System.Drawing.Size(752, 282);
            this.returnListView.TabIndex = 1;
            this.returnListView.UseCompatibleStateImageBehavior = false;
            this.returnListView.View = System.Windows.Forms.View.Details;
            // 
            // RentalID
            // 
            this.RentalID.Text = "Rental ID";
            // 
            // returnDate
            // 
            this.returnDate.Text = "Return Date";
            this.returnDate.Width = 100;
            // 
            // scheduledReturn
            // 
            this.scheduledReturn.Text = "Scheduled Return";
            this.scheduledReturn.Width = 100;
            // 
            // employeeFullName
            // 
            this.employeeFullName.Text = "Employee";
            this.employeeFullName.Width = 90;
            // 
            // itemDescription
            // 
            this.itemDescription.Text = "Item Description";
            this.itemDescription.Width = 158;
            // 
            // fineDue
            // 
            this.fineDue.Text = "Fine";
            // 
            // itemQuantity
            // 
            this.itemQuantity.Text = "Quantity";
            // 
            // refundDue
            // 
            this.refundDue.Text = "Refund";
            // 
            // returnID
            // 
            this.returnID.Text = "Return ID";
            // 
            // ViewReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnListView);
            this.Name = "ViewReturns";
            this.Size = new System.Drawing.Size(758, 288);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView returnListView;
        private System.Windows.Forms.ColumnHeader RentalID;
        private System.Windows.Forms.ColumnHeader returnDate;
        private System.Windows.Forms.ColumnHeader scheduledReturn;
        private System.Windows.Forms.ColumnHeader employeeFullName;
        private System.Windows.Forms.ColumnHeader itemDescription;
        private System.Windows.Forms.ColumnHeader fineDue;
        private System.Windows.Forms.ColumnHeader itemQuantity;
        private System.Windows.Forms.ColumnHeader refundDue;
        private System.Windows.Forms.ColumnHeader returnID;
    }
}
