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
            this.EditStoreMember = new System.Windows.Forms.TabPage();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWelcomeMain = new System.Windows.Forms.Label();
            this.home1 = new RentMe.UserControls.Home();
            this.addCustomer1 = new RentMe.UserControls.AddStoreMember();
            this.editStoreMember2 = new RentMe.UserControls.EditStoreMember();
            this.logoutButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.AddStoreMember.SuspendLayout();
            this.EditStoreMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.AddStoreMember);
            this.tabControl1.Controls.Add(this.EditStoreMember);
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 817);
            this.tabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.home1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Size = new System.Drawing.Size(851, 788);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // AddStoreMember
            // 
            this.AddStoreMember.Controls.Add(this.addCustomer1);
            this.AddStoreMember.Location = new System.Drawing.Point(4, 25);
            this.AddStoreMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStoreMember.Name = "AddStoreMember";
            this.AddStoreMember.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStoreMember.Size = new System.Drawing.Size(851, 788);
            this.AddStoreMember.TabIndex = 0;
            this.AddStoreMember.Text = "Add Store Member";
            this.AddStoreMember.UseVisualStyleBackColor = true;
            // 
            // EditStoreMember
            // 
            this.EditStoreMember.Controls.Add(this.editStoreMember2);
            this.EditStoreMember.Location = new System.Drawing.Point(4, 25);
            this.EditStoreMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditStoreMember.Name = "EditStoreMember";
            this.EditStoreMember.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditStoreMember.Size = new System.Drawing.Size(851, 788);
            this.EditStoreMember.TabIndex = 1;
            this.EditStoreMember.Text = "Edit Store Member";
            this.EditStoreMember.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(653, 17);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 17);
            this.labelUser.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(88, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelWelcomeMain
            // 
            this.labelWelcomeMain.AutoSize = true;
            this.labelWelcomeMain.Location = new System.Drawing.Point(12, 9);
            this.labelWelcomeMain.Name = "labelWelcomeMain";
            this.labelWelcomeMain.Size = new System.Drawing.Size(70, 17);
            this.labelWelcomeMain.TabIndex = 3;
            this.labelWelcomeMain.Text = "Welcome:";
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(12, 4);
            this.home1.Margin = new System.Windows.Forms.Padding(5);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(831, 598);
            this.home1.TabIndex = 0;
            // 
            // addCustomer1
            // 
            this.addCustomer1.Location = new System.Drawing.Point(119, 87);
            this.addCustomer1.Margin = new System.Windows.Forms.Padding(5);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(583, 553);
            this.addCustomer1.TabIndex = 0;
            // 
            // editStoreMember2
            // 
            this.editStoreMember2.Location = new System.Drawing.Point(77, 4);
            this.editStoreMember2.Margin = new System.Windows.Forms.Padding(5);
            this.editStoreMember2.Name = "editStoreMember2";
            this.editStoreMember2.Size = new System.Drawing.Size(631, 748);
            this.editStoreMember2.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(747, 9);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 28);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 858);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.labelWelcomeMain);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeDashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.AddStoreMember.ResumeLayout(false);
            this.EditStoreMember.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddStoreMember;
        private System.Windows.Forms.TabPage EditStoreMember;
        private UserControls.AddStoreMember addCustomer1;
        private System.Windows.Forms.Label labelUser;
        private UserControls.EditStoreMember editStoreMember2;
        private System.Windows.Forms.TabPage Home;
        private UserControls.Home home1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWelcomeMain;
        private System.Windows.Forms.Button logoutButton;
    }
}

