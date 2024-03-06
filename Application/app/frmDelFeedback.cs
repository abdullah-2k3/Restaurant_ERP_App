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
    public partial class frmDelFeedback : Form
    {

        private string ConnectionString = "Data Source=Customer.db;Version=3;";

        public frmDelFeedback()
        {
            InitializeComponent();
        }

        private void btnDelFeedback_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            int id = int.Parse(tbID.Text);

            

            string Query = "DELETE FROM FeedbackTbl WHERE F_Id = " + id;

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            using (SQLiteCommand deleteCmd = new SQLiteCommand(Query, con))
            {
                deleteCmd.Parameters.AddWithValue("@ID", tbID.Text);
                int rowsAffected = deleteCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Feedback deleted");
                }
                else
                {
                    MessageBox.Show("Feedback not found");
                }
            }

            con.Close();

        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
