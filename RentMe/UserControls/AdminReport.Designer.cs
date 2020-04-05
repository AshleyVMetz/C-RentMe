namespace RentMe.UserControls
{
    partial class AdminReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.adminReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.adminReportDataSet = new RentMe.AdminReportDataSet();
            this.getMostPopularFurnitureBetweenDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMostPopularFurnitureBetweenDatesTableAdapter = new RentMe.AdminReportDataSetTableAdapters.GetMostPopularFurnitureBetweenDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adminReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPopularFurnitureBetweenDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(132, 22);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(132, 48);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 2;
            // 
            // startLabel
            // 
            this.startLabel.Location = new System.Drawing.Point(90, 22);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(36, 20);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start:";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endLabel
            // 
            this.endLabel.Location = new System.Drawing.Point(90, 48);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(36, 20);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End:";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(220, 74);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(112, 23);
            this.generateReportButton.TabIndex = 3;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // adminReportViewer
            // 
            reportDataSource3.Name = "AdminReportDataSet";
            reportDataSource3.Value = this.getMostPopularFurnitureBetweenDatesBindingSource;
            this.adminReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.adminReportViewer.LocalReport.ReportEmbeddedResource = "RentMe.Util.AdminReport.rdlc";
            this.adminReportViewer.Location = new System.Drawing.Point(3, 117);
            this.adminReportViewer.Name = "adminReportViewer";
            this.adminReportViewer.ServerReport.BearerToken = null;
            this.adminReportViewer.Size = new System.Drawing.Size(437, 514);
            this.adminReportViewer.TabIndex = 5;
            this.adminReportViewer.TabStop = false;
            // 
            // adminReportDataSet
            // 
            this.adminReportDataSet.DataSetName = "AdminReportDataSet";
            this.adminReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMostPopularFurnitureBetweenDatesBindingSource
            // 
            this.getMostPopularFurnitureBetweenDatesBindingSource.DataMember = "GetMostPopularFurnitureBetweenDates";
            this.getMostPopularFurnitureBetweenDatesBindingSource.DataSource = this.adminReportDataSet;
            // 
            // getMostPopularFurnitureBetweenDatesTableAdapter
            // 
            this.getMostPopularFurnitureBetweenDatesTableAdapter.ClearBeforeFill = true;
            // 
            // AdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminReportViewer);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Name = "AdminReport";
            this.Size = new System.Drawing.Size(443, 634);
            ((System.ComponentModel.ISupportInitialize)(this.adminReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPopularFurnitureBetweenDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button generateReportButton;
        private Microsoft.Reporting.WinForms.ReportViewer adminReportViewer;
        private System.Windows.Forms.BindingSource getMostPopularFurnitureBetweenDatesBindingSource;
        private AdminReportDataSet adminReportDataSet;
        private AdminReportDataSetTableAdapters.GetMostPopularFurnitureBetweenDatesTableAdapter getMostPopularFurnitureBetweenDatesTableAdapter;
    }
}
