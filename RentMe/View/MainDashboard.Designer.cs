namespace RentMe
{
    partial class EmployeeDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.AddStoreMember = new System.Windows.Forms.TabPage();
            this.ViewStoreMember = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWelcomeMain = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.home1 = new RentMe.UserControls.Home();
            this.addCustomer1 = new RentMe.UserControls.AddStoreMember();
            this.editStoreMemberUserControl = new RentMe.UserControls.EditStoreMember();
            this.return1 = new RentMe.UserControls.Return();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.AddStoreMember.SuspendLayout();
            this.ViewStoreMember.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.AddStoreMember);
            this.tabControl1.Controls.Add(this.ViewStoreMember);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 660);
            this.tabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.home1);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(772, 634);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // AddStoreMember
            // 
            this.AddStoreMember.Controls.Add(this.addCustomer1);
            this.AddStoreMember.Location = new System.Drawing.Point(4, 22);
            this.AddStoreMember.Name = "AddStoreMember";
            this.AddStoreMember.Padding = new System.Windows.Forms.Padding(3);
            this.AddStoreMember.Size = new System.Drawing.Size(772, 634);
            this.AddStoreMember.TabIndex = 0;
            this.AddStoreMember.Text = "Add Store Member";
            this.AddStoreMember.UseVisualStyleBackColor = true;
            // 
            // ViewStoreMember
            // 
            this.ViewStoreMember.Controls.Add(this.editStoreMemberUserControl);
            this.ViewStoreMember.Location = new System.Drawing.Point(4, 22);
            this.ViewStoreMember.Name = "ViewStoreMember";
            this.ViewStoreMember.Padding = new System.Windows.Forms.Padding(3);
            this.ViewStoreMember.Size = new System.Drawing.Size(772, 634);
            this.ViewStoreMember.TabIndex = 1;
            this.ViewStoreMember.Text = "View Store Member";
            this.ViewStoreMember.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.return1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(772, 634);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Return";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.Location = new System.Drawing.Point(419, 9);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(289, 23);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Username";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(69, 14);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelWelcomeMain
            // 
            this.labelWelcomeMain.AutoSize = true;
            this.labelWelcomeMain.Location = new System.Drawing.Point(13, 14);
            this.labelWelcomeMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcomeMain.Name = "labelWelcomeMain";
            this.labelWelcomeMain.Size = new System.Drawing.Size(52, 13);
            this.labelWelcomeMain.TabIndex = 3;
            this.labelWelcomeMain.Text = "Welcome";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(713, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(28, 4);
            this.home1.Margin = new System.Windows.Forms.Padding(4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(709, 574);
            this.home1.TabIndex = 0;
            // 
            // addCustomer1
            // 
            this.addCustomer1.Location = new System.Drawing.Point(220, 69);
            this.addCustomer1.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(351, 398);
            this.addCustomer1.TabIndex = 0;
            // 
            // editStoreMemberUserControl
            // 
            this.editStoreMemberUserControl.Location = new System.Drawing.Point(0, 0);
            this.editStoreMemberUserControl.Margin = new System.Windows.Forms.Padding(4);
            this.editStoreMemberUserControl.Name = "editStoreMemberUserControl";
            this.editStoreMemberUserControl.Size = new System.Drawing.Size(772, 622);
            this.editStoreMemberUserControl.TabIndex = 0;
            // 
            // return1
            // 
            this.return1.Location = new System.Drawing.Point(56, 10);
            this.return1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.return1.Name = "return1";
            this.return1.Size = new System.Drawing.Size(552, 372);
            this.return1.TabIndex = 0;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 702);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.labelWelcomeMain);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeDashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.AddStoreMember.ResumeLayout(false);
            this.ViewStoreMember.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddStoreMember;
        private System.Windows.Forms.TabPage ViewStoreMember;
        private UserControls.AddStoreMember addCustomer1;
        private System.Windows.Forms.Label labelUser;
        private UserControls.EditStoreMember editStoreMemberUserControl;
        private System.Windows.Forms.TabPage Home;
        private UserControls.Home home1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWelcomeMain;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControls.Return return1;
    }
}

