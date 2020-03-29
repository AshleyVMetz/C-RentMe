namespace RentMe.View
{
    partial class AdminDashboard
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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.addEmployeeTabPage = new System.Windows.Forms.TabPage();
            this.updateEmployeeTabPage = new System.Windows.Forms.TabPage();
            this.labeluser = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addEmployeeUserControl = new RentMe.UserControls.AddEmployee();
            this.updateEmployeeUserControl = new RentMe.UserControls.UpdateEmployee();
            this.adminTabControl.SuspendLayout();
            this.addEmployeeTabPage.SuspendLayout();
            this.updateEmployeeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.addEmployeeTabPage);
            this.adminTabControl.Controls.Add(this.updateEmployeeTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(16, 49);
            this.adminTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(601, 812);
            this.adminTabControl.TabIndex = 1;
            // 
            // addEmployeeTabPage
            // 
            this.addEmployeeTabPage.Controls.Add(this.addEmployeeUserControl);
            this.addEmployeeTabPage.Location = new System.Drawing.Point(4, 25);
            this.addEmployeeTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.addEmployeeTabPage.Name = "addEmployeeTabPage";
            this.addEmployeeTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.addEmployeeTabPage.Size = new System.Drawing.Size(593, 783);
            this.addEmployeeTabPage.TabIndex = 0;
            this.addEmployeeTabPage.Text = "Add Employee";
            this.addEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // updateEmployeeTabPage
            // 
            this.updateEmployeeTabPage.Controls.Add(this.updateEmployeeUserControl);
            this.updateEmployeeTabPage.Location = new System.Drawing.Point(4, 25);
            this.updateEmployeeTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.updateEmployeeTabPage.Name = "updateEmployeeTabPage";
            this.updateEmployeeTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.updateEmployeeTabPage.Size = new System.Drawing.Size(593, 783);
            this.updateEmployeeTabPage.TabIndex = 1;
            this.updateEmployeeTabPage.Text = "Update Employee";
            this.updateEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // labeluser
            // 
            this.labeluser.Location = new System.Drawing.Point(16, 14);
            this.labeluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(493, 28);
            this.labeluser.TabIndex = 1;
            this.labeluser.Text = "Logged in user";
            this.labeluser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(517, 14);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 28);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(93, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 17);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "name";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(17, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(70, 17);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome:";
            // 
            // addEmployeeUserControl
            // 
            this.addEmployeeUserControl.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.addEmployeeUserControl.Name = "addEmployeeUserControl";
            this.addEmployeeUserControl.Size = new System.Drawing.Size(591, 780);
            this.addEmployeeUserControl.TabIndex = 2;
            // 
            // updateEmployeeUserControl
            // 
            this.updateEmployeeUserControl.Location = new System.Drawing.Point(0, 0);
            this.updateEmployeeUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.updateEmployeeUserControl.Name = "updateEmployeeUserControl";
            this.updateEmployeeUserControl.Size = new System.Drawing.Size(591, 780);
            this.updateEmployeeUserControl.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 876);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.adminTabControl.ResumeLayout(false);
            this.addEmployeeTabPage.ResumeLayout(false);
            this.updateEmployeeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage addEmployeeTabPage;
        private UserControls.AddEmployee addEmployeeUserControl;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TabPage updateEmployeeTabPage;
        private UserControls.UpdateEmployee updateEmployeeUserControl;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}