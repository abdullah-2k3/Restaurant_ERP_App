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
    public partial class frmDelFeedback : Form
    {

        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\abdullah\\Semester 4\\Software Engineering\\project app\\CustomerDb.mdf;Integrated Security=True;Connect Timeout=30;";
        public frmDelFeedback()
        {
            InitializeComponent();
        }

        private void btnDelFeedback_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            int id = int.Parse(tbID.Text);

            

            string Query = "DELETE FROM FeedbackTbl WHERE FId = " + id;

            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Customer has been deleted!");
        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
