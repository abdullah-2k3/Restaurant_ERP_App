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
    public partial class frmDelLoyalty : Form
    {

        private string ConnectionString = "Data Source=Customer.db;Version=3;";
        public frmDelLoyalty()
        {
            InitializeComponent();
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string deleteQuery = "DELETE FROM CustomerLoyaltyTbl WHERE C_ID = @ID";
            using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, con))
            {
                deleteCmd.Parameters.AddWithValue("@ID", tbID.Text);
                int rowsAffected = deleteCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Customer deleted");
                }
                else
                {
                    MessageBox.Show("Customer not found");
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
