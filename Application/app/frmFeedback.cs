using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmFeedback : Form
    {
        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\abdullah\\Documents\\CustomerDb.mdf;Integrated Security=True;Connect Timeout=30;";
        public frmFeedback()
        {
            InitializeComponent();
        }

        private void showFeedback()
        {

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "select * from CustomerProfTbl";

            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
