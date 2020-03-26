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
            this.SuspendLayout();
            // 
            // SerialNumberSearchButton
            // 
            this.SerialNumberSearchButton.Location = new System.Drawing.Point(340, 30);
            this.SerialNumberSearchButton.Name = "SerialNumberSearchButton";
            this.SerialNumberSearchButton.Size = new System.Drawing.Size(96, 23);
            this.SerialNumberSearchButton.TabIndex = 5;
            this.SerialNumberSearchButton.Text = "Search";
            this.SerialNumberSearchButton.UseVisualStyleBackColor = true;
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(125, 34);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(187, 20);
            this.SerialNumberTextBox.TabIndex = 4;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(31, 37);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(76, 13);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "Serial Number:";
            // 
            // StyleSearchButton
            // 
            this.StyleSearchButton.Location = new System.Drawing.Point(340, 67);
            this.StyleSearchButton.Name = "StyleSearchButton";
            this.StyleSearchButton.Size = new System.Drawing.Size(96, 23);
            this.StyleSearchButton.TabIndex = 8;
            this.StyleSearchButton.Text = "Search";
            this.StyleSearchButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Style:";
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.Location = new System.Drawing.Point(125, 71);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(187, 21);
            this.StyleComboBox.TabIndex = 25;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(125, 108);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(187, 21);
            this.CategoryComboBox.TabIndex = 28;
            // 
            // CategorySearchButton
            // 
            this.CategorySearchButton.Location = new System.Drawing.Point(340, 104);
            this.CategorySearchButton.Name = "CategorySearchButton";
            this.CategorySearchButton.Size = new System.Drawing.Size(96, 23);
            this.CategorySearchButton.TabIndex = 27;
            this.CategorySearchButton.Text = "Search";
            this.CategorySearchButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Category:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(487, 482);
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
    }
}
