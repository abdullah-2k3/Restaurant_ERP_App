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

namespace app
{
    public partial class IncomeStatementFR : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public IncomeStatementFR()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_Reports frmFb = new FR_Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = startdate.Value;
            DateTime endDate = enddate.Value;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string[] optionsType = { "INFLOW", "OUTFLOW" };
                    string[] optionsarea = { "OPERATING", "INVESTING", "GOODS SOLD", "TAXES & Others", "TIPS" };


                    string inflowQuery = "SELECT SUM(Amount) AS total_inflow FROM Transactions WHERE Type = 'INFLOW' AND date BETWEEN @StartDate AND @EndDate";

                    string goodsSoldQuery = "SELECT SUM(Amount) AS total_goods_sold FROM Transactions WHERE Type = 'OUTFLOW' AND ExpenseArea = 'GOODS SOLD' AND date BETWEEN @StartDate AND @EndDate";

                    string operatingExpenseQuery = "SELECT SUM(Amount) AS total_operating_expense FROM Transactions WHERE Type = 'OUTFLOW' AND ExpenseArea = 'OPERATING' AND date BETWEEN @StartDate AND @EndDate";

                    string taxesOthersQuery = "SELECT SUM(Amount) AS total_taxes_others FROM Transactions WHERE Type = 'OUTFLOW' AND ExpenseArea = 'TAXES & Others' AND date BETWEEN @StartDate AND @EndDate";

                    double totalInflow = ExecuteScalar(connection, inflowQuery, startDate, endDate);
                    double totalGoodsSold = ExecuteScalar(connection, goodsSoldQuery, startDate, endDate);
                    double totalOperatingExpense = ExecuteScalar(connection, operatingExpenseQuery, startDate, endDate);
                    double totalTaxesOthers = ExecuteScalar(connection, taxesOthersQuery, startDate, endDate);

                    double grossProfit = totalInflow - totalGoodsSold;
                    double operatingProfit = grossProfit - totalOperatingExpense;
                    double netProfit = operatingProfit - totalTaxesOthers;
                    
                    revenue.Text = totalInflow.ToString();
                    costofgoods.Text = totalGoodsSold.ToString();
                    grossprofitans.Text = grossProfit.ToString();
                    grossprofit.Text = grossProfit.ToString();
                    operatingexpense.Text = totalOperatingExpense.ToString();
                    operatingprofitans.Text = operatingProfit.ToString();
                    operatingprofit.Text = operatingProfit.ToString();
                    taxes.Text = totalTaxesOthers.ToString();
                    netprofit.Text = netProfit.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double ExecuteScalar(SQLiteConnection connection, string query, DateTime startDate, DateTime endDate)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToDouble(result);
                }
                return 0;
            }
        }
    }
}
