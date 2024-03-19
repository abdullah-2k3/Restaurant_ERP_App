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
    public partial class frmHome : Form
    {

        string connectionstringMenu = "Data Source = Menu.db; Version = 3";
        string connectionstringCustomers = "Data Source = Customer.db; Version = 3";
        public frmHome()
        {
            InitializeComponent();
            InitializeRevenueChart();
            InitializeMenuChart();
            string query = "SELECT Count(*) FROM Items";
            lblMenu.Text = getItemCount(connectionstringMenu, query).ToString();
            query = "SELECT Count(*) FROM CustomerProfTbl";
            lblCustomers.Text = getItemCount(connectionstringCustomers, query).ToString();
        }


        private int getItemCount(string connection, string query)
        {
            int count;
            using (SQLiteConnection con = new SQLiteConnection(connection))
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

        private void InitializeMenuChart()
        {

            chartMenu.Series.Clear();
            chartMenu.Titles.Clear();


            Title title = new Title("Menu Items per Category");
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            chartMenu.Titles.Add(title);


            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            int fastfoodcount, desicount, continentalcount, dessertcount, juicescount;

            string query = "SELECT Count(*) FROM Items WHERE Category = 'Fast Food'";
            fastfoodcount = getItemCount(connectionstringMenu, query);

            query = "SELECT Count(*) FROM Items WHERE Category = 'Desi'";
            desicount = getItemCount(connectionstringMenu, query);

            query = "SELECT Count(*) FROM Items WHERE Category = 'Continental'";
            continentalcount =  getItemCount(connectionstringMenu, query);

            query = "SELECT Count(*) FROM Items WHERE Category = 'Dessert'";
            dessertcount = getItemCount(connectionstringMenu, query);

            query = "SELECT Count(*) FROM Items WHERE Category = 'Juices'";
            juicescount = getItemCount(connectionstringMenu, query);
           

            series.Points.AddXY("Fast Food", fastfoodcount);
            series.Points.AddXY("Desi", desicount);
            series.Points.AddXY("Continental", continentalcount);
            series.Points.AddXY("Dessert", dessertcount);
            series.Points.AddXY("Juices", juicescount);


            chartMenu.Series.Add(series);

            chartMenu.ChartAreas[0].AxisX.Title = "Category";
            chartMenu.ChartAreas[0].AxisY.Title = "Items";
            chartMenu.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chartMenu.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold);



            chartMenu.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartMenu.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                 
            chartMenu.Legends[0].Enabled = false;

        }

        private void InitializeRevenueChart()
        {

            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();


            Title title = new Title("Monthly Revenue 2024");
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            chartRevenue.Titles.Add(title);


            Series series = new Series();
            series.ChartType = SeriesChartType.Column;


            series.Points.AddXY("January", 56000);
            series.Points.AddXY("February", 72000);
            series.Points.AddXY("March", 21000);



            chartRevenue.Series.Add(series);

            chartRevenue.ChartAreas[0].AxisX.Title = "Month";
            chartRevenue.ChartAreas[0].AxisY.Title = "Amount $";
            chartRevenue.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chartRevenue.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold);



            chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chartRevenue.Legends[0].Enabled = false;

        }
    }
}
