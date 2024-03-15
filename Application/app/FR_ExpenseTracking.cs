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
    public partial class FR_ExpenseTracking : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public FR_ExpenseTracking()
        {
            InitializeComponent();
            PlotExpenditureData();
            PlotExpenseTrend();
        }



        private void PlotExpenseTrend()
        {
            monthly.Series.Clear();

            Series series = new Series("Expense Trend");
            series.ChartType = SeriesChartType.Line;

            Dictionary<string, double> expenseData = GetMonthlyExpenses();

            double previousExpense = 0;
            foreach (KeyValuePair<string, double> entry in expenseData)
            {
                double difference = entry.Value - previousExpense;

                series.Points.AddXY(entry.Key, difference);

                previousExpense = entry.Value;
            }

            monthly.Series.Add(series);

            monthly.ChartAreas[0].AxisX.Interval = 1; 
            monthly.ChartAreas[0].AxisX.IsLabelAutoFit = true;  
            monthly.ChartAreas[0].AxisX.LabelStyle.Angle = -45; 

            monthly.Refresh();
        }

        private Dictionary<string, double> GetMonthlyExpenses()
        {
            Dictionary<string, double> expenseData = new Dictionary<string, double>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT SUBSTR(date, 1, 7) AS month, SUM(Amount) AS total_expense " +
                                   "FROM Transactions WHERE Type = 'OUTFLOW' " +
                                   "AND ExpenseArea IN ('INVESTING', 'OPERATING', 'TAXES & Others','GOODS BUY') " +
                                   "GROUP BY month ORDER BY month";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string month = reader["month"].ToString();
                                double totalExpense = Convert.ToDouble(reader["total_expense"]);
                                expenseData.Add(month, totalExpense);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return expenseData;
        }

        private void PlotExpenditureData()
        {
            string[] areas = { "INVESTING", "OPERATING", "TAXES & Others" ,"GOODS BUY" };
            Dictionary<string, double> expenditureData = new Dictionary<string, double>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    foreach (string area in areas)
                    {
                        string query = "SELECT SUM(Amount) FROM Transactions WHERE ExpenseArea = @Area";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Area", area);
                            object result = command.ExecuteScalar();
                            double totalSpent = result != DBNull.Value ? Convert.ToDouble(result) : 0;
                            expenditureData.Add(area, totalSpent);
                        }
                    }
                }

                areavsmoney.Series.Clear();

                Series series = new Series("Expenditure");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.DarkCyan;
                
                foreach (KeyValuePair<string, double> entry in expenditureData)
                {
                    series.Points.AddXY(entry.Key, entry.Value);
                }

                areavsmoney.Series.Add(series);

                areavsmoney.ChartAreas[0].AxisX.Interval = 1; 
                areavsmoney.ChartAreas[0].AxisX.IsLabelAutoFit = true; 
                areavsmoney.ChartAreas[0].AxisX.LabelStyle.Angle = -90;

                areavsmoney.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmFR frmFb = new frmFR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void FR_ExpenseTracking_Load(object sender, EventArgs e)
        {

        }
    }
}
