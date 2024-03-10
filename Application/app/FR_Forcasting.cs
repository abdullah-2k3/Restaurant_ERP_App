using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class FR_Forcasting : Form
    {
        public FR_Forcasting()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmFR frmFb = new frmFR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void FR_Forcasting_Load(object sender, EventArgs e)
        {

        }
        
        // Function to perform financial forecasting
        private List<double> FinancialForecast(List<double> salesData, int forecastPeriod, int numPeriods)
        {
            List<double> forecast = new List<double>();
            for (int i = 0; i < forecastPeriod; ++i)
            {
                double average = MovingAverage(salesData, numPeriods);
                forecast.Add(average);
                salesData.Add(average); // Append forecasted value to sales data for next iteration
            }
            return forecast;
        }
        private double MovingAverage(List<double> data, int n)
        {
            double sum = 0.0;
            for (int i = data.Count - n; i < data.Count; ++i)
            {
                sum += data[i];
            }
            return sum / n;
        }

        private void btnCalculateForecast_Click_1(object sender, EventArgs e)
        {
            // Parse historical sales data
            List<double> salesData = new List<double>();
            foreach (string saleStr in txtSalesData.Lines)
            {
                if (!string.IsNullOrWhiteSpace(saleStr))
                {
                    double sale;
                    if (double.TryParse(saleStr, out sale))
                    {
                        salesData.Add(sale);
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for historical sales data.");
                        return;
                    }
                }
            }

            // Input validation
            if (salesData.Count == 0)
            {
                MessageBox.Show("Please enter historical sales data.");
                return;
            }

            // Parse forecast parameters
            int forecastPeriod, numPeriods;
            if (!int.TryParse(txtForecastPeriod.Text, out forecastPeriod) || forecastPeriod <= 0)
            {
                MessageBox.Show("Invalid input for forecast period.");
                return;
            }
            if (!int.TryParse(txtNumPeriods.Text, out numPeriods) || numPeriods <= 0)
            {
                MessageBox.Show("Invalid input for number of previous periods.");
                return;
            }

            // Perform financial forecasting
            List<double> forecast = FinancialForecast(salesData, forecastPeriod, numPeriods);

            // Output forecasted sales
            txtForecastResults.Clear();
            for (int i = 0; i < forecast.Count; ++i)
            {
                txtForecastResults.AppendText($"Period {i + 1}: {forecast[i]}\n");
            }
        }
    }
}
