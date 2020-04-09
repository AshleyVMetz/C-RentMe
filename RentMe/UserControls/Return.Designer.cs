namespace RentMe.UserControls
{
    partial class Return
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
            this.textBoxStoreMemberID = new System.Windows.Forms.TextBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelReturns = new System.Windows.Forms.Label();
            this.labelStoreMember = new System.Windows.Forms.Label();
            this.labelReturnEmployee = new System.Windows.Forms.Label();
            this.dataGridViewReturnableItems = new System.Windows.Forms.DataGridView();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.labelDirections = new System.Windows.Forms.Label();
            this.labelDirections2 = new System.Windows.Forms.Label();
            this.labelFineDue = new System.Windows.Forms.Label();
            this.labelAmountFineDue = new System.Windows.Forms.Label();
            this.labelRefundDue = new System.Windows.Forms.Label();
            this.label4AmountRefundDue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnableItems)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStoreMemberID
            // 
            this.textBoxStoreMemberID.Location = new System.Drawing.Point(200, 67);
            this.textBoxStoreMemberID.Name = "textBoxStoreMemberID";
            this.textBoxStoreMemberID.Size = new System.Drawing.Size(322, 22);
            this.textBoxStoreMemberID.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(223, 380);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 23);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(560, 67);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(79, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 380);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelReturns
            // 
            this.labelReturns.AutoSize = true;
            this.labelReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturns.Location = new System.Drawing.Point(312, 17);
            this.labelReturns.Name = "labelReturns";
            this.labelReturns.Size = new System.Drawing.Size(114, 32);
            this.labelReturns.TabIndex = 8;
            this.labelReturns.Text = "Returns";
            // 
            // labelStoreMember
            // 
            this.labelStoreMember.AutoSize = true;
            this.labelStoreMember.Location = new System.Drawing.Point(49, 67);
            this.labelStoreMember.Name = "labelStoreMember";
            this.labelStoreMember.Size = new System.Drawing.Size(118, 17);
            this.labelStoreMember.TabIndex = 9;
            this.labelStoreMember.Text = "Store Member ID:";
            // 
            // labelReturnEmployee
            // 
            this.labelReturnEmployee.AutoSize = true;
            this.labelReturnEmployee.Location = new System.Drawing.Point(50, 353);
            this.labelReturnEmployee.Name = "labelReturnEmployee";
            this.labelReturnEmployee.Size = new System.Drawing.Size(117, 17);
            this.labelReturnEmployee.TabIndex = 13;
            this.labelReturnEmployee.Text = "Return Employee";
            // 
            // dataGridViewReturnableItems
            // 
            this.dataGridViewReturnableItems.AllowUserToAddRows = false;
            this.dataGridViewReturnableItems.AllowUserToDeleteRows = false;
            this.dataGridViewReturnableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnableItems.Location = new System.Drawing.Point(52, 141);
            this.dataGridViewReturnableItems.Name = "dataGridViewReturnableItems";
            this.dataGridViewReturnableItems.RowHeadersWidth = 51;
            this.dataGridViewReturnableItems.RowTemplate.Height = 24;
            this.dataGridViewReturnableItems.Size = new System.Drawing.Size(587, 196);
            this.dataGridViewReturnableItems.TabIndex = 14;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(200, 350);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(334, 24);
            this.comboBoxEmployee.TabIndex = 15;
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(59, 104);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(558, 17);
            this.labelDirections.TabIndex = 16;
            this.labelDirections.Text = "Quantity Available To Return. Please enter the amount of each item you wish to re" +
    "turn. ";
            // 
            // labelDirections2
            // 
            this.labelDirections2.AutoSize = true;
            this.labelDirections2.Location = new System.Drawing.Point(59, 121);
            this.labelDirections2.Name = "labelDirections2";
            this.labelDirections2.Size = new System.Drawing.Size(352, 17);
            this.labelDirections2.TabIndex = 17;
            this.labelDirections2.Text = "If you do not wish to return an item put a 0 for quantity.";
            // 
            // labelFineDue
            // 
            this.labelFineDue.AutoSize = true;
            this.labelFineDue.Location = new System.Drawing.Point(197, 417);
            this.labelFineDue.Name = "labelFineDue";
            this.labelFineDue.Size = new System.Drawing.Size(69, 17);
            this.labelFineDue.TabIndex = 18;
            this.labelFineDue.Text = "Fine Due:";
            // 
            // labelAmountFineDue
            // 
            this.labelAmountFineDue.AutoSize = true;
            this.labelAmountFineDue.Location = new System.Drawing.Point(272, 417);
            this.labelAmountFineDue.Name = "labelAmountFineDue";
            this.labelAmountFineDue.Size = new System.Drawing.Size(16, 17);
            this.labelAmountFineDue.TabIndex = 19;
            this.labelAmountFineDue.Text = "0";
            // 
            // labelRefundDue
            // 
            this.labelRefundDue.AutoSize = true;
            this.labelRefundDue.Location = new System.Drawing.Point(338, 417);
            this.labelRefundDue.Name = "labelRefundDue";
            this.labelRefundDue.Size = new System.Drawing.Size(88, 17);
            this.labelRefundDue.TabIndex = 20;
            this.labelRefundDue.Text = "Refund Due:";
            // 
            // label4AmountRefundDue
            // 
            this.label4AmountRefundDue.AutoSize = true;
            this.label4AmountRefundDue.Location = new System.Drawing.Point(432, 417);
            this.label4AmountRefundDue.Name = "label4AmountRefundDue";
            this.label4AmountRefundDue.Size = new System.Drawing.Size(16, 17);
            this.label4AmountRefundDue.TabIndex = 21;
            this.label4AmountRefundDue.Text = "0";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4AmountRefundDue);
            this.Controls.Add(this.labelRefundDue);
            this.Controls.Add(this.labelAmountFineDue);
            this.Controls.Add(this.labelFineDue);
            this.Controls.Add(this.labelDirections2);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.dataGridViewReturnableItems);
            this.Controls.Add(this.labelReturnEmployee);
            this.Controls.Add(this.labelStoreMember);
            this.Controls.Add(this.labelReturns);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBoxStoreMemberID);
            this.Name = "Return";
            this.Size = new System.Drawing.Size(761, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnableItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStoreMemberID;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelReturns;
        private System.Windows.Forms.Label labelStoreMember;
        private System.Windows.Forms.Label labelReturnEmployee;
        private System.Windows.Forms.DataGridView dataGridViewReturnableItems;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label labelDirections2;
        private System.Windows.Forms.Label labelFineDue;
        private System.Windows.Forms.Label labelAmountFineDue;
        private System.Windows.Forms.Label labelRefundDue;
        private System.Windows.Forms.Label label4AmountRefundDue;
    }
}
