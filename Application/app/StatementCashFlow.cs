using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class StatementCashFlow : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public StatementCashFlow()
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

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void getbtn_Click(object sender, EventArgs e)
        {

            string startDate = startdate.Value.ToString("yyyy-MM-dd");
            string endDate = enddate.Value.ToString("yyyy-MM-dd");

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string inflowQuery = "SELECT SUM(Amount) AS total_inflow FROM Transactions WHERE Type = 'INFLOW' AND date BETWEEN @StartDate AND @EndDate";

                    string outflowQuery = "SELECT SUM(Amount) AS total_outflow FROM Transactions WHERE Type = 'OUTFLOW' AND date BETWEEN @StartDate AND @EndDate";

                    string operatingQuery = "SELECT SUM(Amount) AS total_operating FROM Transactions WHERE ExpenseArea = 'OPERATING' AND date BETWEEN @StartDate AND @EndDate";

                    string investingQuery = "SELECT SUM(Amount) AS total_investing FROM Transactions WHERE ExpenseArea = 'INVESTING' AND date BETWEEN @StartDate AND @EndDate";

                    double totalInflow = 0;
                    double totalOutflow = 0;
                    double totalOperating = 0;
                    double totalInvesting = 0;
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = inflowQuery;
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        object inflowResult = command.ExecuteScalar();
                        if (inflowResult != DBNull.Value)
                        {
                            totalInflow = Convert.ToDouble(inflowResult);
                        }

                        command.CommandText = outflowQuery;
                        object outflowResult = command.ExecuteScalar();
                        if (outflowResult != DBNull.Value)
                        {
                            totalOutflow = Convert.ToDouble(outflowResult);
                        }

                        command.CommandText = operatingQuery;
                        object operatingResult = command.ExecuteScalar();
                        if (operatingResult != DBNull.Value)
                        {
                            totalOperating = Convert.ToDouble(operatingResult);
                        }

                        command.CommandText = investingQuery;
                        object investingResult = command.ExecuteScalar();
                        if (investingResult != DBNull.Value)
                        {
                            totalInvesting = Convert.ToDouble(investingResult);
                        }
                    }

                    double netCashFlow = totalInflow - totalOutflow;
                    inflow.Text = totalInflow.ToString();
                    outflow.Text = totalOutflow.ToString();
                    operating.Text = totalOperating.ToString();
                    investing.Text = totalInvesting.ToString();
                    netchange.Text = netCashFlow.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
