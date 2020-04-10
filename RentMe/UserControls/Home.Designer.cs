namespace RentMe.UserControls
{
    partial class Home
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
            this.SerialNumberSearchButton = new System.Windows.Forms.Button();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.StyleSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StyleComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategorySearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FurnitureListView = new System.Windows.Forms.ListView();
            this.SerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Style = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DialyRentalRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FineRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DailyRateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FineRateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.QuantityAvailableLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.QuantityRequiredComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerialNumberSearchButton
            // 
            this.SerialNumberSearchButton.Location = new System.Drawing.Point(425, 12);
            this.SerialNumberSearchButton.Name = "SerialNumberSearchButton";
            this.SerialNumberSearchButton.Size = new System.Drawing.Size(96, 23);
            this.SerialNumberSearchButton.TabIndex = 2;
            this.SerialNumberSearchButton.Text = "Search";
            this.SerialNumberSearchButton.UseVisualStyleBackColor = true;
            this.SerialNumberSearchButton.Click += new System.EventHandler(this.SerialNumberSearchButton_Click);
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(210, 14);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(187, 20);
            this.SerialNumberTextBox.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(116, 17);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(76, 13);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "Serial Number:";
            // 
            // StyleSearchButton
            // 
            this.StyleSearchButton.Location = new System.Drawing.Point(425, 44);
            this.StyleSearchButton.Name = "StyleSearchButton";
            this.StyleSearchButton.Size = new System.Drawing.Size(96, 23);
            this.StyleSearchButton.TabIndex = 4;
            this.StyleSearchButton.Text = "Search";
            this.StyleSearchButton.UseVisualStyleBackColor = true;
            this.StyleSearchButton.Click += new System.EventHandler(this.StyleSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Style:";
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.DisplayMember = "Text";
            this.StyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.Location = new System.Drawing.Point(210, 46);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(187, 21);
            this.StyleComboBox.TabIndex = 3;
            this.StyleComboBox.ValueMember = "Value";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DisplayMember = "Text";
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(210, 81);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(187, 21);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.ValueMember = "Value";
            // 
            // CategorySearchButton
            // 
            this.CategorySearchButton.Location = new System.Drawing.Point(425, 79);
            this.CategorySearchButton.Name = "CategorySearchButton";
            this.CategorySearchButton.Size = new System.Drawing.Size(96, 23);
            this.CategorySearchButton.TabIndex = 6;
            this.CategorySearchButton.Text = "Search";
            this.CategorySearchButton.UseVisualStyleBackColor = true;
            this.CategorySearchButton.Click += new System.EventHandler(this.CategorySearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Category:";
            // 
            // FurnitureListView
            // 
            this.FurnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerialNumber,
            this.Description,
            this.Style,
            this.Category,
            this.Quantity,
            this.DialyRentalRate,
            this.FineRate});
            this.FurnitureListView.FullRowSelect = true;
            this.FurnitureListView.HideSelection = false;
            this.FurnitureListView.Location = new System.Drawing.Point(14, 125);
            this.FurnitureListView.Name = "FurnitureListView";
            this.FurnitureListView.Size = new System.Drawing.Size(661, 200);
            this.FurnitureListView.TabIndex = 29;
            this.FurnitureListView.TabStop = false;
            this.FurnitureListView.UseCompatibleStateImageBehavior = false;
            this.FurnitureListView.View = System.Windows.Forms.View.Details;
            this.FurnitureListView.SelectedIndexChanged += new System.EventHandler(this.FurnitureListView_SelectedIndexChanged);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Text = "Serial #";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 140;
            // 
            // Style
            // 
            this.Style.Text = "Style";
            this.Style.Width = 105;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 90;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity Available";
            this.Quantity.Width = 103;
            // 
            // DialyRentalRate
            // 
            this.DialyRentalRate.Text = "Daily Rate";
            this.DialyRentalRate.Width = 72;
            // 
            // FineRate
            // 
            this.FineRate.Text = "Fine Rate";
            this.FineRate.Width = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Serial # :";
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(161, 340);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.SerialNumberLabel.TabIndex = 31;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(480, 340);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.DescriptionLabel.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Description :";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Location = new System.Drawing.Point(161, 363);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(0, 13);
            this.StyleLabel.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Style :";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(492, 363);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(0, 13);
            this.CategoryLabel.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Category :";
            // 
            // DailyRateLabel
            // 
            this.DailyRateLabel.AutoSize = true;
            this.DailyRateLabel.Location = new System.Drawing.Point(179, 386);
            this.DailyRateLabel.Name = "DailyRateLabel";
            this.DailyRateLabel.Size = new System.Drawing.Size(0, 13);
            this.DailyRateLabel.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Daily Rate :";
            // 
            // FineRateLabel
            // 
            this.FineRateLabel.AutoSize = true;
            this.FineRateLabel.Location = new System.Drawing.Point(501, 386);
            this.FineRateLabel.Name = "FineRateLabel";
            this.FineRateLabel.Size = new System.Drawing.Size(0, 13);
            this.FineRateLabel.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fine Rate :";
            // 
            // QuantityAvailableLabel
            // 
            this.QuantityAvailableLabel.AutoSize = true;
            this.QuantityAvailableLabel.Location = new System.Drawing.Point(179, 409);
            this.QuantityAvailableLabel.Name = "QuantityAvailableLabel";
            this.QuantityAvailableLabel.Size = new System.Drawing.Size(0, 13);
            this.QuantityAvailableLabel.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Quantity Available :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Quantity Required :";
            // 
            // QuantityRequiredComboBox
            // 
            this.QuantityRequiredComboBox.DisplayMember = "Text";
            this.QuantityRequiredComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityRequiredComboBox.FormattingEnabled = true;
            this.QuantityRequiredComboBox.Location = new System.Drawing.Point(154, 512);
            this.QuantityRequiredComboBox.Name = "QuantityRequiredComboBox";
            this.QuantityRequiredComboBox.Size = new System.Drawing.Size(51, 21);
            this.QuantityRequiredComboBox.TabIndex = 45;
            this.QuantityRequiredComboBox.ValueMember = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date From :";
            // 
            // DateFromDateTimePicker
            // 
            this.DateFromDateTimePicker.Location = new System.Drawing.Point(154, 478);
            this.DateFromDateTimePicker.Name = "DateFromDateTimePicker";
            this.DateFromDateTimePicker.Size = new System.Drawing.Size(181, 20);
            this.DateFromDateTimePicker.TabIndex = 47;
            // 
            // DateToDateTimePicker
            // 
            this.DateToDateTimePicker.Location = new System.Drawing.Point(435, 479);
            this.DateToDateTimePicker.Name = "DateToDateTimePicker";
            this.DateToDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.DateToDateTimePicker.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(359, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Date To :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "Rental Details";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(284, 512);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(136, 23);
            this.AddToCartButton.TabIndex = 51;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(451, 512);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(136, 23);
            this.ClearButton.TabIndex = 52;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DateToDateTimePicker);
            this.Controls.Add(this.DateFromDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityRequiredComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.QuantityAvailableLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FineRateLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DailyRateLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StyleLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FurnitureListView);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategorySearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StyleComboBox);
            this.Controls.Add(this.StyleSearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SerialNumberSearchButton);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.Label7);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(689, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SerialNumberSearchButton;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button StyleSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StyleComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button CategorySearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView FurnitureListView;
        private System.Windows.Forms.ColumnHeader SerialNumber;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Style;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader DialyRentalRate;
        private System.Windows.Forms.ColumnHeader FineRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DailyRateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FineRateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label QuantityAvailableLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox QuantityRequiredComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker DateToDateTimePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button ClearButton;
    }
}
