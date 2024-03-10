using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace app
{
    public partial class frmCRM : Form
    {



        private string ConnectionString = "Data Source=Customer.db;Version=3;";

        public frmCRM()
        {
            InitializeComponent();
            InitializeChart();
            UpdateCircularProgress();

        }

        private void InitializeChart()
        {
            
            customerFlowChart.Series.Clear();
            customerFlowChart.Titles.Clear();


            Title title = new Title("Customer Flow");
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            customerFlowChart.Titles.Add(title);

            
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;


            series.Points.AddXY("WeekDays", 25);
            series.Points.AddXY("WeekEnds", 56);


         
            customerFlowChart.Series.Add(series);

            customerFlowChart.ChartAreas[0].AxisX.Title = "Days";
            customerFlowChart.ChartAreas[0].AxisY.Title = "Average Customers";
            customerFlowChart.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold); 
            customerFlowChart.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold); 
                                                                                                    
                                                                                                    

            customerFlowChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            customerFlowChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            customerFlowChart.Legends[0].Enabled = false;

        }



        private void customerFlow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        public void UpdateCircularProgress()
        {
            int totalCustomers = GetTotalCustomers();
            int satisfiedCustomers = GetSatisfiedCustomers();

            // Calculate the percentage of satisfied customers
            double percentage = totalCustomers > 0 ? ((double)satisfiedCustomers / totalCustomers) * 100 : 0;


            // Update the Bunifu circular progress control with the calculated percentage
            circularBar.Value = (int)percentage; // Round the percentage to the nearest integer
            circularBar.Text = $"{percentage:F2}%"; // Update the center text
            lblProgress.Text = $"Satisfied Customers: {percentage:F2}%"; // Update the label text

        }



        private int GetTotalCustomers()
        {
            int totalCustomers = 0;

            string query = "SELECT COUNT(*) FROM CustomerProfTbl";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            totalCustomers = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving total customers: " + ex.Message);
                    }
                }
            }

            return totalCustomers;
        }


        private int GetSatisfiedCustomers()
        {
            int satisfiedCustomers = 0;

            string query = "SELECT COUNT(*) FROM CustomerLoyaltyTbl";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        satisfiedCustomers = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving satisfied customers: " + ex.Message);
                    }
                }
            }

            return satisfiedCustomers;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmCustomerProfile frmCus_Vrb = new frmCustomerProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCus_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmCus_Vrb);
            frmCus_Vrb.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmFeedback frmFb = new frmFeedback() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnLoyalty_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmLoyalty frmLyl = new frmLoyalty() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLyl.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmLyl);
            frmLyl.Show();
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmVisits frmLyl = new frmVisits() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLyl.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmLyl);
            frmLyl.Show();
        }
    }
}
