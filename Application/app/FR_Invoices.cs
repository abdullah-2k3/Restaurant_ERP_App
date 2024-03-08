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
    public partial class FR_Invoices : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public FR_Invoices()
        {
            InitializeComponent();
            showCustomers();
        }


        private void showCustomers()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Invoice";

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
            AddInvoiceForm frmFb = new AddInvoiceForm();
            frmFb.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DeleteInvoice frmFb = new DeleteInvoice();
            frmFb.ShowDialog();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            OpenInvoice frmFb = new OpenInvoice();
            frmFb.ShowDialog();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
