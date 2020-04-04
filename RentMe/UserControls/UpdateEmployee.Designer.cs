namespace RentMe.UserControls
{
    partial class UpdateEmployee
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
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address1Label = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.phoneSearchTextBox = new System.Windows.Forms.TextBox();
            this.phoneSearchLabel = new System.Windows.Forms.Label();
            this.employeeIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDSearchLabel = new System.Windows.Forms.Label();
            this.fullNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.fullNameSearchLabel = new System.Windows.Forms.Label();
            this.firstOrLabel = new System.Windows.Forms.Label();
            this.secondOrLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.passwordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneFormatLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(179, 415);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(187, 21);
            this.stateComboBox.TabIndex = 14;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(179, 258);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(187, 21);
            this.sexComboBox.TabIndex = 8;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Location = new System.Drawing.Point(179, 285);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.dobDateTimePicker.TabIndex = 9;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(179, 540);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(15, 14);
            this.adminCheckBox.TabIndex = 19;
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(179, 520);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activeCheckBox.TabIndex = 18;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(296, 125);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(70, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.Enabled = false;
            this.updateEmployeeButton.Location = new System.Drawing.Point(220, 560);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(146, 23);
            this.updateEmployeeButton.TabIndex = 20;
            this.updateEmployeeButton.Text = "Update Employee";
            this.updateEmployeeButton.UseVisualStyleBackColor = true;
            this.updateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(71, 540);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(42, 13);
            this.adminLabel.TabIndex = 56;
            this.adminLabel.Text = "Admin?";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(71, 520);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(43, 13);
            this.activeLabel.TabIndex = 55;
            this.activeLabel.Text = "Active?";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(71, 497);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 13);
            this.passwordLabel.TabIndex = 54;
            this.passwordLabel.Text = "Password: *";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(179, 468);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(187, 20);
            this.usernameTextBox.TabIndex = 16;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(71, 471);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 13);
            this.usernameLabel.TabIndex = 53;
            this.usernameLabel.Text = "Username: *";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(179, 442);
            this.zipCodeTextBox.MaxLength = 9;
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(187, 20);
            this.zipCodeTextBox.TabIndex = 15;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(71, 445);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(60, 13);
            this.zipCodeLabel.TabIndex = 52;
            this.zipCodeLabel.Text = "Zip Code: *";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(71, 415);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(42, 13);
            this.stateLabel.TabIndex = 50;
            this.stateLabel.Text = "State: *";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(179, 389);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(187, 20);
            this.cityTextBox.TabIndex = 13;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(71, 392);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(34, 13);
            this.cityLabel.TabIndex = 47;
            this.cityLabel.Text = "City: *";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(179, 363);
            this.address2TextBox.MaxLength = 50;
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(187, 20);
            this.address2TextBox.TabIndex = 12;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(71, 366);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(80, 13);
            this.address2Label.TabIndex = 44;
            this.address2Label.Text = "Address Line 2:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(179, 337);
            this.address1TextBox.MaxLength = 50;
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(187, 20);
            this.address1TextBox.TabIndex = 11;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(71, 340);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(87, 13);
            this.address1Label.TabIndex = 41;
            this.address1Label.Text = "Address Line 1: *";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(71, 285);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(76, 13);
            this.dobLabel.TabIndex = 38;
            this.dobLabel.Text = "Date of Birth: *";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(179, 311);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(187, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(71, 314);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(48, 13);
            this.phoneLabel.TabIndex = 35;
            this.phoneLabel.Text = "Phone: *";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(71, 258);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(35, 13);
            this.sexLabel.TabIndex = 33;
            this.sexLabel.Text = "Sex: *";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(179, 232);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(187, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(71, 235);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(68, 13);
            this.lastNameLabel.TabIndex = 29;
            this.lastNameLabel.Text = "Last Name: *";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(179, 206);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(187, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(71, 209);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 13);
            this.firstNameLabel.TabIndex = 27;
            this.firstNameLabel.Text = "First Name: *";
            // 
            // phoneSearchTextBox
            // 
            this.phoneSearchTextBox.Location = new System.Drawing.Point(179, 73);
            this.phoneSearchTextBox.Name = "phoneSearchTextBox";
            this.phoneSearchTextBox.Size = new System.Drawing.Size(187, 20);
            this.phoneSearchTextBox.TabIndex = 2;
            // 
            // phoneSearchLabel
            // 
            this.phoneSearchLabel.AutoSize = true;
            this.phoneSearchLabel.Location = new System.Drawing.Point(71, 73);
            this.phoneSearchLabel.Name = "phoneSearchLabel";
            this.phoneSearchLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneSearchLabel.TabIndex = 57;
            this.phoneSearchLabel.Text = "Phone:";
            // 
            // employeeIDSearchTextBox
            // 
            this.employeeIDSearchTextBox.Location = new System.Drawing.Point(179, 47);
            this.employeeIDSearchTextBox.Name = "employeeIDSearchTextBox";
            this.employeeIDSearchTextBox.Size = new System.Drawing.Size(187, 20);
            this.employeeIDSearchTextBox.TabIndex = 1;
            // 
            // employeeIDSearchLabel
            // 
            this.employeeIDSearchLabel.AutoSize = true;
            this.employeeIDSearchLabel.Location = new System.Drawing.Point(71, 50);
            this.employeeIDSearchLabel.Name = "employeeIDSearchLabel";
            this.employeeIDSearchLabel.Size = new System.Drawing.Size(70, 13);
            this.employeeIDSearchLabel.TabIndex = 59;
            this.employeeIDSearchLabel.Text = "Employee ID:";
            // 
            // fullNameSearchTextBox
            // 
            this.fullNameSearchTextBox.Location = new System.Drawing.Point(179, 99);
            this.fullNameSearchTextBox.Name = "fullNameSearchTextBox";
            this.fullNameSearchTextBox.Size = new System.Drawing.Size(187, 20);
            this.fullNameSearchTextBox.TabIndex = 3;
            // 
            // fullNameSearchLabel
            // 
            this.fullNameSearchLabel.AutoSize = true;
            this.fullNameSearchLabel.Location = new System.Drawing.Point(71, 102);
            this.fullNameSearchLabel.Name = "fullNameSearchLabel";
            this.fullNameSearchLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameSearchLabel.TabIndex = 61;
            this.fullNameSearchLabel.Text = "Full Name:";
            // 
            // firstOrLabel
            // 
            this.firstOrLabel.AutoSize = true;
            this.firstOrLabel.Location = new System.Drawing.Point(372, 50);
            this.firstOrLabel.Name = "firstOrLabel";
            this.firstOrLabel.Size = new System.Drawing.Size(23, 13);
            this.firstOrLabel.TabIndex = 63;
            this.firstOrLabel.Text = "OR";
            // 
            // secondOrLabel
            // 
            this.secondOrLabel.AutoSize = true;
            this.secondOrLabel.Location = new System.Drawing.Point(372, 76);
            this.secondOrLabel.Name = "secondOrLabel";
            this.secondOrLabel.Size = new System.Drawing.Size(23, 13);
            this.secondOrLabel.TabIndex = 64;
            this.secondOrLabel.Text = "OR";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(220, 125);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // passwordMaskedTextBox
            // 
            this.passwordMaskedTextBox.HidePromptOnLeave = true;
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(179, 494);
            this.passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            this.passwordMaskedTextBox.PasswordChar = '*';
            this.passwordMaskedTextBox.Size = new System.Drawing.Size(187, 20);
            this.passwordMaskedTextBox.TabIndex = 17;
            // 
            // phoneFormatLabel
            // 
            this.phoneFormatLabel.AutoSize = true;
            this.phoneFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFormatLabel.Location = new System.Drawing.Point(72, 86);
            this.phoneFormatLabel.Name = "phoneFormatLabel";
            this.phoneFormatLabel.Size = new System.Drawing.Size(58, 7);
            this.phoneFormatLabel.TabIndex = 65;
            this.phoneFormatLabel.Text = "XXX-XXX-XXXX";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(71, 183);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.employeeIDLabel.TabIndex = 66;
            this.employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Enabled = false;
            this.employeeIDTextBox.Location = new System.Drawing.Point(179, 180);
            this.employeeIDTextBox.MaxLength = 50;
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(187, 20);
            this.employeeIDTextBox.TabIndex = 67;
            this.employeeIDTextBox.TabStop = false;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.phoneFormatLabel);
            this.Controls.Add(this.passwordMaskedTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.secondOrLabel);
            this.Controls.Add(this.firstOrLabel);
            this.Controls.Add(this.fullNameSearchTextBox);
            this.Controls.Add(this.fullNameSearchLabel);
            this.Controls.Add(this.employeeIDSearchTextBox);
            this.Controls.Add(this.employeeIDSearchLabel);
            this.Controls.Add(this.phoneSearchTextBox);
            this.Controls.Add(this.phoneSearchLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateEmployeeButton);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "UpdateEmployee";
            this.Size = new System.Drawing.Size(443, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox phoneSearchTextBox;
        private System.Windows.Forms.Label phoneSearchLabel;
        private System.Windows.Forms.TextBox employeeIDSearchTextBox;
        private System.Windows.Forms.Label employeeIDSearchLabel;
        private System.Windows.Forms.TextBox fullNameSearchTextBox;
        private System.Windows.Forms.Label fullNameSearchLabel;
        private System.Windows.Forms.Label firstOrLabel;
        private System.Windows.Forms.Label secondOrLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MaskedTextBox passwordMaskedTextBox;
        private System.Windows.Forms.Label phoneFormatLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.TextBox employeeIDTextBox;
    }
}
