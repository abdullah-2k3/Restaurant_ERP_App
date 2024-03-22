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
    public partial class FR_Payments : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public FR_Payments()
        {
            InitializeComponent();
            show();
        }


        private void show()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Payments";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            bunifuDataGridView1.DataSource = table;

            con.Close();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmFR frmFb = new frmFR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddPaymentForm frmFb = new AddPaymentForm();
            frmFb.ShowDialog();
            show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DeletePayment frmFb = new DeletePayment();
            frmFb.ShowDialog();
            show();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FR_Payments_Load(object sender, EventArgs e)
        {

        }
    }

}
