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
        string connectionstringFinance = "Data Source = Finance.db; Version = 3";
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
            query = "SELECT Count(*) FROM Orders";
            lblOrders.Text = getItemCount(connectionstringCustomers, query).ToString();
            query = "SELECT SUM(Amount) FROM Transactions where ExpenseArea = 'GOODS SOLD'";
            lblRevenue.Text = getItemCount(connectionstringFinance, query).ToString();
           
        }


        private int getItemCount(string connection, string query)
        {
            int count;
            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    try { 
                        count = Convert.ToInt32(cmd.ExecuteScalar()); 
                    }
                    catch (Exception ex) 
                    { 
                        count = 0; 
                    }
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

            chartRevenue.Series.Add(series);

            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chartRevenue.Refresh();
        }

        private Dictionary<string, double> GetMonthlyExpenses()
        {
            Dictionary<string, double> expenseData = new Dictionary<string, double>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionstringFinance))
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

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
