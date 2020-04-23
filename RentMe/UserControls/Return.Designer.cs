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
            this.buttonAddToReturn = new System.Windows.Forms.Button();
            this.listViewItemsToReturn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rental = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelReturnInstructions = new System.Windows.Forms.Label();
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
            this.buttonReturn.Location = new System.Drawing.Point(303, 532);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(163, 23);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return Listed Items";
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
            this.buttonCancel.Location = new System.Drawing.Point(514, 532);
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
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirections.Location = new System.Drawing.Point(18, 107);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(212, 20);
            this.labelDirections.TabIndex = 16;
            this.labelDirections.Text = "Click on a row to return.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 22;
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(127, 313);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(16, 17);
            this.SerialNumberLabel.TabIndex = 23;
            this.SerialNumberLabel.Text = "0";
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSize = true;
            this.serialNumber.Location = new System.Drawing.Point(19, 313);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(102, 17);
            this.serialNumber.TabIndex = 24;
            this.serialNumber.Text = "Serial Number:";
            // 
            // QuantityAvailableLabel
            // 
            this.QuantityAvailableLabel.AutoSize = true;
            this.QuantityAvailableLabel.Location = new System.Drawing.Point(348, 313);
            this.QuantityAvailableLabel.Name = "QuantityAvailableLabel";
            this.QuantityAvailableLabel.Size = new System.Drawing.Size(16, 17);
            this.QuantityAvailableLabel.TabIndex = 25;
            this.QuantityAvailableLabel.Text = "0";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(216, 313);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(126, 17);
            this.QuantityLabel.TabIndex = 26;
            this.QuantityLabel.Text = "Quantity Available:";
            // 
            // ComboBoxRequiredQuantity
            // 
            this.ComboBoxRequiredQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRequiredQuantity.FormattingEnabled = true;
            this.ComboBoxRequiredQuantity.Location = new System.Drawing.Point(528, 306);
            this.ComboBoxRequiredQuantity.Name = "ComboBoxRequiredQuantity";
            this.ComboBoxRequiredQuantity.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxRequiredQuantity.TabIndex = 27;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(394, 313);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(128, 17);
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
            this.listViewReturnableItems.Location = new System.Drawing.Point(22, 130);
            this.listViewReturnableItems.Name = "listViewReturnableItems";
            this.listViewReturnableItems.Size = new System.Drawing.Size(870, 154);
            this.listViewReturnableItems.TabIndex = 29;
            this.listViewReturnableItems.UseCompatibleStateImageBehavior = false;
            this.listViewReturnableItems.View = System.Windows.Forms.View.Details;
            this.listViewReturnableItems.SelectedIndexChanged += new System.EventHandler(this.listViewReturnableItems_SelectedIndexChanged);
            // 
            // serial
            // 
            this.serial.Text = "Serial Number";
            // 
            // description
            // 
            this.description.Text = "Description";
            // 
            // style
            // 
            this.style.Text = "Style";
            // 
            // category
            // 
            this.category.Text = "Category";
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // buttonAddToReturn
            // 
            this.buttonAddToReturn.Location = new System.Drawing.Point(680, 306);
            this.buttonAddToReturn.Name = "buttonAddToReturn";
            this.buttonAddToReturn.Size = new System.Drawing.Size(133, 23);
            this.buttonAddToReturn.TabIndex = 30;
            this.buttonAddToReturn.Text = "Add to Return";
            this.buttonAddToReturn.UseVisualStyleBackColor = true;
            this.buttonAddToReturn.Click += new System.EventHandler(this.buttonAddToReturn_Click);
            // 
            // listViewItemsToReturn
            // 
            this.listViewItemsToReturn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.rental});
            this.listViewItemsToReturn.HideSelection = false;
            this.listViewItemsToReturn.Location = new System.Drawing.Point(22, 364);
            this.listViewItemsToReturn.Name = "listViewItemsToReturn";
            this.listViewItemsToReturn.Size = new System.Drawing.Size(870, 162);
            this.listViewItemsToReturn.TabIndex = 31;
            this.listViewItemsToReturn.UseCompatibleStateImageBehavior = false;
            this.listViewItemsToReturn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial Number";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Style";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Category";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            // 
            // rentalID
            // 
            this.rentalID.Text = "Rental ID";
            // 
            // rental
            // 
            this.rental.Text = "RentalID";
            // 
            // labelReturnInstructions
            // 
            this.labelReturnInstructions.AutoSize = true;
            this.labelReturnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnInstructions.Location = new System.Drawing.Point(19, 344);
            this.labelReturnInstructions.Name = "labelReturnInstructions";
            this.labelReturnInstructions.Size = new System.Drawing.Size(331, 18);
            this.labelReturnInstructions.TabIndex = 32;
            this.labelReturnInstructions.Text = "These are the items you selected to return:";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Name = "Return";
            this.Size = new System.Drawing.Size(975, 587);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader rentalID;
        private System.Windows.Forms.ColumnHeader rental;
        private System.Windows.Forms.Label labelReturnInstructions;
    }
}
