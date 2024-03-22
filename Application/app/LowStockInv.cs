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
    public partial class LowStockInv : Form
    {
        private string ConnectionString = "Data Source=inventory.db;Version=3;";

        public LowStockInv()
        {
            InitializeComponent();

            showLow();
        }



        private void showLow()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "SELECT name, COUNT(*) AS count FROM items GROUP BY name HAVING count < 15";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            int count = Convert.ToInt32(reader["count"]);

                            chart1.Series["Items"].Points.AddXY(name, count);
                        }
                    }
                }

                chart1.Titles.Add("Items with Count Less Than 15");

                chart1.ChartAreas[0].AxisX.Title = "Name";
                chart1.ChartAreas[0].AxisY.Title = "Count";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmInv frmFb = new frmInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }
    }
}
