﻿namespace RentMe
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
            this.AddStoreMember = new System.Windows.Forms.TabPage();
            this.EditStoreMember = new System.Windows.Forms.TabPage();
            this.labelUser = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.TabPage();
            this.addCustomer1 = new RentMe.UserControls.AddStoreMember();
            this.editStoreMember2 = new RentMe.UserControls.EditStoreMember();
            this.home1 = new RentMe.UserControls.Home();
            this.tabControl1.SuspendLayout();
            this.AddStoreMember.SuspendLayout();
            this.EditStoreMember.SuspendLayout();
            this.Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.AddStoreMember);
            this.tabControl1.Controls.Add(this.EditStoreMember);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 664);
            this.tabControl1.TabIndex = 0;
            // 
            // AddStoreMember
            // 
            this.AddStoreMember.Controls.Add(this.addCustomer1);
            this.AddStoreMember.Location = new System.Drawing.Point(4, 22);
            this.AddStoreMember.Name = "AddStoreMember";
            this.AddStoreMember.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.AddStoreMember.Size = new System.Drawing.Size(636, 638);
            this.AddStoreMember.TabIndex = 0;
            this.AddStoreMember.Text = "Add Store Member";
            this.AddStoreMember.UseVisualStyleBackColor = true;
            // 
            // EditStoreMember
            // 
            this.EditStoreMember.Controls.Add(this.editStoreMember2);
            this.EditStoreMember.Location = new System.Drawing.Point(4, 22);
            this.EditStoreMember.Name = "EditStoreMember";
            this.EditStoreMember.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.EditStoreMember.Size = new System.Drawing.Size(636, 638);
            this.EditStoreMember.TabIndex = 1;
            this.EditStoreMember.Text = "Edit Store Member";
            this.EditStoreMember.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(490, 14);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 13);
            this.labelUser.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.home1);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(636, 638);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // addCustomer1
            // 
            this.addCustomer1.Location = new System.Drawing.Point(0, 6);
            this.addCustomer1.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(437, 449);
            this.addCustomer1.TabIndex = 0;
            // 
            // editStoreMember2
            // 
            this.editStoreMember2.Location = new System.Drawing.Point(58, 3);
            this.editStoreMember2.Name = "editStoreMember2";
            this.editStoreMember2.Size = new System.Drawing.Size(473, 608);
            this.editStoreMember2.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(22, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(504, 542);
            this.home1.TabIndex = 0;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 666);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeDashboard";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.AddStoreMember.ResumeLayout(false);
            this.EditStoreMember.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddStoreMember;
        private System.Windows.Forms.TabPage EditStoreMember;
        private UserControls.AddStoreMember addCustomer1;
        private UserControls.EditStoreMember editStoreMember1;
        private System.Windows.Forms.Label labelUser;
        private UserControls.EditStoreMember editStoreMember2;
        private System.Windows.Forms.TabPage Home;
        private UserControls.Home home1;
    }
}
