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
    public partial class FR_Transactions : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";


        public FR_Transactions()
        {
            InitializeComponent();
            show();
        }

        private void show()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Transactions";

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
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.ShowDialog();
            show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UpdateTransaction updateTransaction = new UpdateTransaction();
            updateTransaction.ShowDialog();
            show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteTransaction deleteTransaction = new DeleteTransaction();
            deleteTransaction.ShowDialog();
            show();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
