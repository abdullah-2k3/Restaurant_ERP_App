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
    public partial class frmFR : Form
    {

        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public frmFR()
        {
            InitializeComponent();
            display();
        }


        private void display()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string incomeQuery = "SELECT SUM(Amount) AS total_income FROM Transactions WHERE Type = 'INFLOW'";

                    string expenseQuery = "SELECT SUM(Amount) AS total_expense FROM Transactions WHERE Type = 'OUTFLOW'";



                    double totalIncome = 0;
                    double totalExpense = 0;
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = incomeQuery;
                        object incomeResult = command.ExecuteScalar();
                        if (incomeResult != DBNull.Value)
                        {
                            totalIncome = Convert.ToDouble(incomeResult);
                        }

                        command.CommandText = expenseQuery;
                        object expenseResult = command.ExecuteScalar();
                        if (expenseResult != DBNull.Value)
                        {
                            totalExpense = Convert.ToDouble(expenseResult);
                        }
                    }

                    double netProfit = totalIncome - totalExpense;
                    
                    sales.Text = totalIncome.ToString();
                    purchase.Text = totalExpense.ToString();
                    profit.Text = netProfit.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_Transactions frmTr = new FR_Transactions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTr.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmTr);
            frmTr.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_Reports frmFb = new FR_Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_ExpenseTracking frmFb = new FR_ExpenseTracking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_Invoices frmFb = new FR_Invoices() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_Payments frmFb = new FR_Payments() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FR_Forcasting frmFb = new FR_Forcasting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void frmFR_Load(object sender, EventArgs e)
        {

        }
    }
}
