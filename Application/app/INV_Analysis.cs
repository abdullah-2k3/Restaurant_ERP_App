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
    public partial class INV_Analysis : Form
    {
        private string ConnectionString = "Data Source=inventory.db;Version=3;";

        public INV_Analysis()
        {
            InitializeComponent();
            showcategory();
            showName();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmInv frmFb = new frmInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }


        private void showName()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "SELECT name, COUNT(*) AS count FROM items GROUP BY name";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            int count = Convert.ToInt32(reader["count"]);
                            if (chart2.Series.IndexOf("Items") == -1)
                            {
                                chart2.Series.Add("Items");
                            }
                            chart2.Series["Items"].Points.AddXY(name, count);
                        }
                    }
                    chart2.Titles.Add("Items by Name");

                    chart2.ChartAreas[0].AxisX.Title = "Name";
                    chart2.ChartAreas[0].AxisY.Title = "Count";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void showcategory()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "SELECT category, COUNT(*) AS count FROM items GROUP BY category";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string category = reader["category"].ToString();
                            int count = Convert.ToInt32(reader["count"]);

                            if (chart1.Series.IndexOf("Items") == -1)
                            {
                                chart1.Series.Add("Items");
                            }

                            chart1.Series["Items"].Points.AddXY(category, count);
                        }
                    }

                    chart1.Titles.Add("Items by Category");
                    chart1.ChartAreas[0].AxisX.Title = "Category";
                    chart1.ChartAreas[0].AxisY.Title = "Count";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void INV_Analysis_Load(object sender, EventArgs e)
        {

        }
    }
}
