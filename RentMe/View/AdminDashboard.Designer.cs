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
            this.addEmployee1 = new RentMe.UserControls.AddEmployee();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.addEmployeeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.addEmployeeTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(12, 40);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(451, 660);
            this.adminTabControl.TabIndex = 1;
            // 
            // addEmployeeTabPage
            // 
            this.addEmployeeTabPage.Controls.Add(this.addEmployee1);
            this.addEmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.addEmployeeTabPage.Name = "addEmployeeTabPage";
            this.addEmployeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addEmployeeTabPage.Size = new System.Drawing.Size(443, 634);
            this.addEmployeeTabPage.TabIndex = 0;
            this.addEmployeeTabPage.Text = "Add Employee";
            this.addEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(443, 634);
            this.addEmployee1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged in user";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(388, 11);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 712);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.adminTabControl.ResumeLayout(false);
            this.addEmployeeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage addEmployeeTabPage;
        private UserControls.AddEmployee addEmployee1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
    }
}