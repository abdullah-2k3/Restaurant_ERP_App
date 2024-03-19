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
            UpdateProgressChart();


        }


        private int getItemCount(string query)
        {
            int count;
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());

                }
                con.Close();
            }
            return count;
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


            float mondaycount, tuesdaycount, wednesdaycount, thursdaycount, fridaycount, saturdaycount, sundaycount;

            string query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Monday'";
            mondaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Monday'";
            mondaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Tuesday'";
            tuesdaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Wednesday'";
            wednesdaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Thursday'";
            thursdaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Friday'";
            fridaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Saturday'";
            saturdaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits WHERE Visitday = 'Sunday'";
            sundaycount = getItemCount(query);

            query = "SELECT Count(*) FROM Visits";
            float totalcount = getItemCount(query);

            mondaycount = mondaycount / totalcount * 100;
            tuesdaycount =  tuesdaycount / totalcount * 100;
            wednesdaycount =  wednesdaycount / totalcount * 100;
            thursdaycount =  thursdaycount / totalcount * 100;
            fridaycount =  fridaycount / totalcount * 100;
            saturdaycount =  saturdaycount / totalcount * 100;
            sundaycount =  sundaycount / totalcount * 100;


            series.Points.AddXY("Monday", mondaycount);
            series.Points.AddXY("Tuesday", tuesdaycount);
            series.Points.AddXY("Wednesday", wednesdaycount);
            series.Points.AddXY("Thursday", thursdaycount);
            series.Points.AddXY("Friday", fridaycount);
            series.Points.AddXY("Saturday", saturdaycount);
            series.Points.AddXY("Sunday", sundaycount);



            customerFlowChart.Series.Add(series);

            customerFlowChart.ChartAreas[0].AxisX.Title = "Days";
            customerFlowChart.ChartAreas[0].AxisY.Title = "Average Customers";
            customerFlowChart.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold); 
            customerFlowChart.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold); 
                                                                                                    
                                                                                                    

            customerFlowChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            customerFlowChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            customerFlowChart.Legends[0].Enabled = false;

        }



        public void UpdateProgressChart()
        {
            int totalCustomers = GetTotalCustomers();
            int membershipCustomers = GetSatisfiedCustomers();

            // Calculate the percentage of satisfied customers
            double percentage = totalCustomers > 0 ? ((double)membershipCustomers / totalCustomers) * 100 : 0;

            // Clear any existing series from the chart
            chart.Series.Clear();
            chart.Legends.Clear();

            // Add a new series for the donut chart
            Series series = chart.Series.Add("Donut");
            series.ChartType = SeriesChartType.Doughnut;
            series["PieLabelStyle"] = "Outside";

            // Add data points to the series
            DataPoint point1 = series.Points.Add(percentage);

            DataPoint point2 = series.Points.Add(100 - percentage);

            // Set the palette for the chart
            chart.Palette = ChartColorPalette.BrightPastel;

            // Set the chart title
            Title title = new Title("Membership Percentage");
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            chart.Titles.Add(title);

            // Set the color of the donut chart
            series.Points[0].Color = Color.DarkBlue; // Outer color
            series.Points[1].Color = Color.Aqua; // Inner color

            
            chart.ChartAreas[0].InnerPlotPosition.Auto = false;
            chart.ChartAreas[0].InnerPlotPosition.Width = 90; 
            chart.ChartAreas[0].InnerPlotPosition.Height = 90;
            chart.ChartAreas[0].InnerPlotPosition.X = 5; 
            chart.ChartAreas[0].InnerPlotPosition.Y = 5; 


            chart.Invalidate();

            lblProgress.Text = $"Membership Customers: {percentage:F2}%";
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
