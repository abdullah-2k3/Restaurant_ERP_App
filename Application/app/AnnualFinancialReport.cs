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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace app
{
    public partial class AnnualFinancialReport : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public AnnualFinancialReport()
        {
            InitializeComponent();
            PopulateYearsDropdown();
        }

        private void PopulateYearsDropdown()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT DISTINCT SUBSTR(date, 1, 4) AS year FROM transactions";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string year = reader["year"].ToString();
                            options.Items.Add(year);
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

        private void AnnualFinancialReport_Load(object sender, EventArgs e)
        {

        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            if (options.SelectedItem == null)
            {
                MessageBox.Show("Please select a year");
                return;
            }
            string selectedYear = options.SelectedItem.ToString();

            string incomeQuery = $"SELECT SUM(Amount) FROM Transactions WHERE Type = 'INFLOW' AND SUBSTR(date, 1, 4) = '{selectedYear}'";
            string expenseQuery = $"SELECT SUM(Amount) FROM Transactions WHERE Type = 'OUTFLOW' AND SUBSTR(date, 1, 4) = '{selectedYear}'";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    double totalIncome, totalExpense;
                    using (SQLiteCommand incomeCommand = new SQLiteCommand(incomeQuery, connection))
                    using (SQLiteCommand expenseCommand = new SQLiteCommand(expenseQuery, connection))
                    {
                        totalIncome = Convert.ToDouble(incomeCommand.ExecuteScalar());
                        totalExpense = Convert.ToDouble(expenseCommand.ExecuteScalar());
                    }

                    double netProfit = totalIncome - totalExpense;

                    annualincome.Text = totalIncome.ToString();
                    annualexpense.Text = totalExpense.ToString();
                    netprofit.Text = netProfit.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
