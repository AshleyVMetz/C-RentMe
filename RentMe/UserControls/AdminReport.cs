using System;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// This class models a user control for the admin report.
    /// </summary>
    public partial class AdminReport : UserControl
    {
        /// <summary>
        /// Constructor method.
        /// </summary>
        public AdminReport()
        {
            InitializeComponent();
            this.startDateTimePicker.Value = DateTime.Now.AddYears(-1);
            this.endDateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// This method refreshes the report with the latest data when the Generate Report button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateReportButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.adminReportDataSet.Reset();
                this.getMostPopularFurnitureBetweenDatesTableAdapter.Fill(this.adminReportDataSet.GetMostPopularFurnitureBetweenDates, this.startDateTimePicker.Value, this.endDateTimePicker.Value);
                this.adminReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input or database connection. " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
