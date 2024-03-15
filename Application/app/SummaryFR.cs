using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace app
{
    public partial class SummaryFR : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public SummaryFR()
        {
            InitializeComponent();
            DisplayDistinctMonthsAndYears();
        }

        private void DisplayDistinctMonthsAndYears()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    // Construct SQL query to fetch distinct months and years
                    string query = "SELECT DISTINCT SUBSTR(date, 1, 7) AS month_year FROM transactions";

                    // Execute the query to fetch distinct months and years
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string monthYear = reader["month_year"].ToString();
                            options.Items.Add(monthYear);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_Reports frmFb = new FR_Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void SummaryFR_Load(object sender, EventArgs e)
        {

        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            if (options.SelectedItem == null)
            {
                MessageBox.Show("Please select a month and year");
                return;
            }

            string selectedMonthYear = options.SelectedItem.ToString();
            DateTime previousMonth = DateTime.ParseExact(selectedMonthYear, "yyyy-MM", CultureInfo.InvariantCulture).AddMonths(-1);
            string previousMonthYear = previousMonth.ToString("yyyy-MM");
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string incomeQuery = "SELECT SUM(Amount) AS total_income FROM Transactions WHERE Type = 'INFLOW' AND SUBSTR(date, 1, 7) = @MonthYear";

                    string expenseQuery = "SELECT SUM(Amount) AS total_expense FROM Transactions WHERE Type = 'OUTFLOW' AND SUBSTR(date, 1, 7) = @MonthYear";

                    
                    string previousIncomeQuery = "SELECT SUM(Amount) AS total_income FROM Transactions WHERE Type = 'INFLOW' AND SUBSTR(date, 1, 7) = @MonthYear";
                    string previousExpenseQuery = "SELECT SUM(Amount) AS total_expense FROM Transactions WHERE Type = 'OUTFLOW' AND SUBSTR(date, 1, 7) = @MonthYear";

                    // Execute the queries to calculate total income and total expense
                    double totalIncome = 0;
                    double previousIncome = 0;
                    double previousExpense = 0;
                    double previousProfit = 0;

                    double totalExpense = 0;
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        // Calculate total income
                        command.CommandText = incomeQuery;
                        command.Parameters.AddWithValue("@MonthYear", selectedMonthYear);
                        object incomeResult = command.ExecuteScalar();
                        if (incomeResult != DBNull.Value)
                        {
                            totalIncome = Convert.ToDouble(incomeResult);
                        }

                        // Calculate total expense
                        command.CommandText = expenseQuery;
                        object expenseResult = command.ExecuteScalar();
                        if (expenseResult != DBNull.Value)
                        {
                            totalExpense = Convert.ToDouble(expenseResult);
                        }


                        command.CommandText = previousIncomeQuery;
                        command.Parameters.AddWithValue("@MonthYear", previousMonthYear);
                        object previousIncomeResult = command.ExecuteScalar();
                        if (previousIncomeResult != DBNull.Value)
                        {
                            previousIncome = Convert.ToDouble(previousIncomeResult);
                        }

                        command.CommandText = previousExpenseQuery;
                        object previousExpenseResult = command.ExecuteScalar();
                        if (previousExpenseResult != DBNull.Value)
                        {
                            previousExpense = Convert.ToDouble(previousExpenseResult);
                        }

                        previousProfit = previousIncome - previousExpense;


                    }

                    // Calculate net profit
                    double netProfit = totalIncome - totalExpense;
                    double incomeChange = (totalIncome - previousIncome) / (previousIncome == 0 ? totalIncome : previousIncome) * 100;
                    double expenseChange = (totalExpense - previousExpense) / (previousExpense == 0 ? totalExpense : previousExpense) * 100;
                    double profitChange = (netProfit - previousProfit) / (previousProfit == 0 ? netProfit : previousProfit) * 100;

                    income.Text = totalIncome.ToString();
                    expense.Text = totalExpense.ToString();
                    Profit.Text = netProfit.ToString();
                    percentageincome.Text = incomeChange.ToString("0.##") + "%";
                    percentageexpense.Text = expenseChange.ToString("0.##") + "%";
                    percentageprofit.Text = profitChange.ToString("0.##") + "%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            

           
            












        }
    }
}
