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
            this.AddStoreMember = new System.Windows.Forms.TabPage();
            this.addCustomer1 = new RentMe.UserControls.AddStoreMember();
            this.EditStoreMember = new System.Windows.Forms.TabPage();
            this.labelUser = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.AddStoreMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddStoreMember);
            this.tabControl1.Controls.Add(this.EditStoreMember);
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // AddStoreMember
            // 
            this.AddStoreMember.Controls.Add(this.addCustomer1);
            this.AddStoreMember.Location = new System.Drawing.Point(4, 25);
            this.AddStoreMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStoreMember.Name = "AddStoreMember";
            this.AddStoreMember.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStoreMember.Size = new System.Drawing.Size(857, 607);
            this.AddStoreMember.TabIndex = 0;
            this.AddStoreMember.Text = "Add Store Member";
            this.AddStoreMember.UseVisualStyleBackColor = true;
            // 
            // addCustomer1
            // 
            this.addCustomer1.Location = new System.Drawing.Point(0, 7);
            this.addCustomer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(583, 553);
            this.addCustomer1.TabIndex = 0;
            // 
            // EditStoreMember
            // 
            this.EditStoreMember.Location = new System.Drawing.Point(4, 25);
            this.EditStoreMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditStoreMember.Name = "EditStoreMember";
            this.EditStoreMember.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditStoreMember.Size = new System.Drawing.Size(857, 607);
            this.EditStoreMember.TabIndex = 1;
            this.EditStoreMember.Text = "Edit Store Member";
            this.EditStoreMember.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(665, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 17);
            this.labelUser.TabIndex = 1;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 673);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeDashboard";
            this.Text = "Employee Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.AddStoreMember.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddStoreMember;
        private System.Windows.Forms.TabPage EditStoreMember;
        private UserControls.AddStoreMember addCustomer1;
        private System.Windows.Forms.Label labelUser;
    }
}

