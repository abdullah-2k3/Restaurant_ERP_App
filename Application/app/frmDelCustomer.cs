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
using System.Xml.Linq;

namespace app
{
    public partial class frmDelCustomer : Form
    {

        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\abdullah\\Documents\\CustomerDb.mdf;Integrated Security=True;Connect Timeout=30;";
        public frmDelCustomer()
        {
            InitializeComponent();
        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            int id = int.Parse(tbID.Text);
          

            string Query = "DELETE FROM CustomerProfTbl WHERE CustomerProfTbl.Id = " + id;

            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Customer has been deleted!");
        }
    }
}
