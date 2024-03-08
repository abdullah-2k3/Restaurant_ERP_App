using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmHome()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
