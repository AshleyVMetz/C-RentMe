namespace RentMe
{
    partial class Form1
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
            this.AddCustomer = new System.Windows.Forms.TabPage();
            this.EditCustomer = new System.Windows.Forms.TabPage();
            this.addCustomer1 = new RentMe.UserControls.AddStoreMember();
            this.tabControl1.SuspendLayout();
            this.AddCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddCustomer);
            this.tabControl1.Controls.Add(this.EditCustomer);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // AddCustomer
            // 
            this.AddCustomer.Controls.Add(this.addCustomer1);
            this.AddCustomer.Location = new System.Drawing.Point(4, 22);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.AddCustomer.Size = new System.Drawing.Size(641, 491);
            this.AddCustomer.TabIndex = 0;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            // 
            // EditCustomer
            // 
            this.EditCustomer.Location = new System.Drawing.Point(4, 22);
            this.EditCustomer.Name = "EditCustomer";
            this.EditCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.EditCustomer.Size = new System.Drawing.Size(641, 491);
            this.EditCustomer.TabIndex = 1;
            this.EditCustomer.Text = "Edit Customer";
            this.EditCustomer.UseVisualStyleBackColor = true;
            // 
            // addCustomer1
            // 
            this.addCustomer1.Location = new System.Drawing.Point(0, 6);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(437, 449);
            this.addCustomer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.AddCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddCustomer;
        private System.Windows.Forms.TabPage EditCustomer;
        private UserControls.AddStoreMember addCustomer1;
    }
}

