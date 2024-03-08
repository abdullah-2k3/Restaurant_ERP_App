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
    public partial class frmAddFeedback : Form
    {
        private string ConnectionString = "Data Source=Customer.db;Version=3;";

        public frmAddFeedback()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFb_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();


            string C_Id = tbId.Text;
            string phone = tbPhone.Text;
            string feedback = tbFb.Text;


            string Query = "INSERT INTO FeedbackTbl(Feedback, C_Id, Contact) VALUES ('" + feedback + "', '" + C_Id + "','" + phone + "')";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Feedback has been added!");
        }
    }
}
