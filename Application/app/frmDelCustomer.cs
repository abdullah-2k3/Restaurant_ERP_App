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
using System.Xml.Linq;

namespace app
{
    public partial class frmDelCustomer : Form
    {

        private string ConnectionString = "Data Source=Customer.db;Version=3;";

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
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string deleteQuery = "DELETE FROM CustomerProfTbl WHERE ID = @ID";
            string query = "DELETE FROM CustomerLoyaltyTbl WHERE C_ID = @ID";
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

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", tbID.Text);
            cmd.ExecuteNonQuery();
                     
            
            con.Close();
        }

    }
}
