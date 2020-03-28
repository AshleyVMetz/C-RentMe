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
            this.addEmployeeUserControl = new RentMe.UserControls.AddEmployee();
            this.updateEmployeeTabPage = new System.Windows.Forms.TabPage();
            this.updateEmployeeUserControl = new RentMe.UserControls.UpdateEmployee();
            this.labeluser = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.addEmployeeTabPage.SuspendLayout();
            this.updateEmployeeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.addEmployeeTabPage);
            this.adminTabControl.Controls.Add(this.updateEmployeeTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(12, 40);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(451, 660);
            this.adminTabControl.TabIndex = 1;
            // 
            // addEmployeeTabPage
            // 
            this.addEmployeeTabPage.Controls.Add(this.addEmployeeUserControl);
            this.addEmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.addEmployeeTabPage.Name = "addEmployeeTabPage";
            this.addEmployeeTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.addEmployeeTabPage.Size = new System.Drawing.Size(443, 634);
            this.addEmployeeTabPage.TabIndex = 0;
            this.addEmployeeTabPage.Text = "Add Employee";
            this.addEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // addEmployeeUserControl
            // 
            this.addEmployeeUserControl.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeUserControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEmployeeUserControl.Name = "addEmployeeUserControl";
            this.addEmployeeUserControl.Size = new System.Drawing.Size(443, 634);
            this.addEmployeeUserControl.TabIndex = 2;
            // 
            // updateEmployeeTabPage
            // 
            this.updateEmployeeTabPage.Controls.Add(this.updateEmployeeUserControl);
            this.updateEmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateEmployeeTabPage.Name = "updateEmployeeTabPage";
            this.updateEmployeeTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.updateEmployeeTabPage.Size = new System.Drawing.Size(443, 634);
            this.updateEmployeeTabPage.TabIndex = 1;
            this.updateEmployeeTabPage.Text = "Update Employee";
            this.updateEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // updateEmployeeUserControl
            // 
            this.updateEmployeeUserControl.Location = new System.Drawing.Point(0, 0);
            this.updateEmployeeUserControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateEmployeeUserControl.Name = "updateEmployeeUserControl";
            this.updateEmployeeUserControl.Size = new System.Drawing.Size(443, 634);
            this.updateEmployeeUserControl.TabIndex = 0;
            // 
            // labeluser
            // 
            this.labeluser.Location = new System.Drawing.Point(12, 11);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(370, 23);
            this.labeluser.TabIndex = 1;
            this.labeluser.Text = "Logged in user";
            this.labeluser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(388, 11);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 712);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.adminTabControl.ResumeLayout(false);
            this.addEmployeeTabPage.ResumeLayout(false);
            this.updateEmployeeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage addEmployeeTabPage;
        private UserControls.AddEmployee addEmployeeUserControl;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TabPage updateEmployeeTabPage;
        private UserControls.UpdateEmployee updateEmployeeUserControl;
    }
}