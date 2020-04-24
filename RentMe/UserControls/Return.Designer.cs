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
            this.labelDirections = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.serialNumber = new System.Windows.Forms.Label();
            this.QuantityAvailableLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ComboBoxRequiredQuantity = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.listViewReturnableItems = new System.Windows.Forms.ListView();
            this.serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.style = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddToReturn = new System.Windows.Forms.Button();
            this.listViewItemsToReturn = new System.Windows.Forms.ListView();
            this.columnHeaderSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRental = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelReturnInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStoreMemberID
            // 
            this.textBoxStoreMemberID.Location = new System.Drawing.Point(150, 54);
            this.textBoxStoreMemberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStoreMemberID.Name = "textBoxStoreMemberID";
            this.textBoxStoreMemberID.Size = new System.Drawing.Size(242, 20);
            this.textBoxStoreMemberID.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(227, 432);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(122, 19);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "Return Listed Items";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(420, 54);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(59, 19);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(386, 432);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 19);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelReturns
            // 
            this.labelReturns.AutoSize = true;
            this.labelReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturns.Location = new System.Drawing.Point(234, 14);
            this.labelReturns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReturns.Name = "labelReturns";
            this.labelReturns.Size = new System.Drawing.Size(88, 26);
            this.labelReturns.TabIndex = 8;
            this.labelReturns.Text = "Returns";
            // 
            // labelStoreMember
            // 
            this.labelStoreMember.AutoSize = true;
            this.labelStoreMember.Location = new System.Drawing.Point(37, 54);
            this.labelStoreMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStoreMember.Name = "labelStoreMember";
            this.labelStoreMember.Size = new System.Drawing.Size(90, 13);
            this.labelStoreMember.TabIndex = 9;
            this.labelStoreMember.Text = "Store Member ID:";
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirections.Location = new System.Drawing.Point(14, 87);
            this.labelDirections.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(182, 17);
            this.labelDirections.TabIndex = 16;
            this.labelDirections.Text = "Click on a row to return.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(95, 254);
            this.SerialNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.SerialNumberLabel.TabIndex = 23;
            this.SerialNumberLabel.Text = "0";
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSize = true;
            this.serialNumber.Location = new System.Drawing.Point(14, 254);
            this.serialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(76, 13);
            this.serialNumber.TabIndex = 24;
            this.serialNumber.Text = "Serial Number:";
            // 
            // QuantityAvailableLabel
            // 
            this.QuantityAvailableLabel.AutoSize = true;
            this.QuantityAvailableLabel.Location = new System.Drawing.Point(261, 254);
            this.QuantityAvailableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityAvailableLabel.Name = "QuantityAvailableLabel";
            this.QuantityAvailableLabel.Size = new System.Drawing.Size(13, 13);
            this.QuantityAvailableLabel.TabIndex = 25;
            this.QuantityAvailableLabel.Text = "0";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(162, 254);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(95, 13);
            this.QuantityLabel.TabIndex = 26;
            this.QuantityLabel.Text = "Quantity Available:";
            // 
            // ComboBoxRequiredQuantity
            // 
            this.ComboBoxRequiredQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRequiredQuantity.FormattingEnabled = true;
            this.ComboBoxRequiredQuantity.Location = new System.Drawing.Point(396, 249);
            this.ComboBoxRequiredQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxRequiredQuantity.Name = "ComboBoxRequiredQuantity";
            this.ComboBoxRequiredQuantity.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxRequiredQuantity.TabIndex = 2;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(296, 254);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(97, 13);
            this.amountLabel.TabIndex = 28;
            this.amountLabel.Text = "Amount To Return:";
            // 
            // listViewReturnableItems
            // 
            this.listViewReturnableItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serial,
            this.description,
            this.style,
            this.category,
            this.quantity,
            this.rentalID});
            this.listViewReturnableItems.HideSelection = false;
            this.listViewReturnableItems.Location = new System.Drawing.Point(16, 106);
            this.listViewReturnableItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewReturnableItems.Name = "listViewReturnableItems";
            this.listViewReturnableItems.Size = new System.Drawing.Size(654, 126);
            this.listViewReturnableItems.TabIndex = 29;
            this.listViewReturnableItems.TabStop = false;
            this.listViewReturnableItems.UseCompatibleStateImageBehavior = false;
            this.listViewReturnableItems.View = System.Windows.Forms.View.Details;
            this.listViewReturnableItems.SelectedIndexChanged += new System.EventHandler(this.listViewReturnableItems_SelectedIndexChanged);
            // 
            // serial
            // 
            this.serial.Text = "Serial Number";
            this.serial.Width = 90;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 170;
            // 
            // style
            // 
            this.style.Text = "Style";
            this.style.Width = 130;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 135;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // rentalID
            // 
            this.rentalID.Text = "Rental ID";
            this.rentalID.Width = 80;
            // 
            // buttonAddToReturn
            // 
            this.buttonAddToReturn.Location = new System.Drawing.Point(510, 249);
            this.buttonAddToReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddToReturn.Name = "buttonAddToReturn";
            this.buttonAddToReturn.Size = new System.Drawing.Size(100, 19);
            this.buttonAddToReturn.TabIndex = 3;
            this.buttonAddToReturn.Text = "Add to Return";
            this.buttonAddToReturn.UseVisualStyleBackColor = true;
            this.buttonAddToReturn.Click += new System.EventHandler(this.buttonAddToReturn_Click);
            // 
            // listViewItemsToReturn
            // 
            this.listViewItemsToReturn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSerial,
            this.columnHeaderDescription,
            this.columnHeaderStyle,
            this.columnHeaderCategory,
            this.columnHeaderQuantity,
            this.columnHeaderRental});
            this.listViewItemsToReturn.HideSelection = false;
            this.listViewItemsToReturn.Location = new System.Drawing.Point(16, 296);
            this.listViewItemsToReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewItemsToReturn.Name = "listViewItemsToReturn";
            this.listViewItemsToReturn.Size = new System.Drawing.Size(654, 132);
            this.listViewItemsToReturn.TabIndex = 31;
            this.listViewItemsToReturn.TabStop = false;
            this.listViewItemsToReturn.UseCompatibleStateImageBehavior = false;
            this.listViewItemsToReturn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSerial
            // 
            this.columnHeaderSerial.Text = "Serial Number";
            this.columnHeaderSerial.Width = 90;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 170;
            // 
            // columnHeaderStyle
            // 
            this.columnHeaderStyle.Text = "Style";
            this.columnHeaderStyle.Width = 130;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 135;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            // 
            // columnHeaderRental
            // 
            this.columnHeaderRental.Text = "RentalID";
            this.columnHeaderRental.Width = 80;
            // 
            // labelReturnInstructions
            // 
            this.labelReturnInstructions.AutoSize = true;
            this.labelReturnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnInstructions.Location = new System.Drawing.Point(14, 280);
            this.labelReturnInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReturnInstructions.Name = "labelReturnInstructions";
            this.labelReturnInstructions.Size = new System.Drawing.Size(280, 15);
            this.labelReturnInstructions.TabIndex = 32;
            this.labelReturnInstructions.Text = "These are the items you selected to return:";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelReturnInstructions);
            this.Controls.Add(this.listViewItemsToReturn);
            this.Controls.Add(this.buttonAddToReturn);
            this.Controls.Add(this.listViewReturnableItems);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.ComboBoxRequiredQuantity);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityAvailableLabel);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.labelStoreMember);
            this.Controls.Add(this.labelReturns);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBoxStoreMemberID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Return";
            this.Size = new System.Drawing.Size(731, 477);
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
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.Label serialNumber;
        private System.Windows.Forms.Label QuantityAvailableLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.ComboBox ComboBoxRequiredQuantity;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ListView listViewReturnableItems;
        private System.Windows.Forms.ColumnHeader serial;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader style;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.Button buttonAddToReturn;
        private System.Windows.Forms.ListView listViewItemsToReturn;
        private System.Windows.Forms.ColumnHeader columnHeaderSerial;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderStyle;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader rentalID;
        private System.Windows.Forms.ColumnHeader columnHeaderRental;
        private System.Windows.Forms.Label labelReturnInstructions;
    }
}
