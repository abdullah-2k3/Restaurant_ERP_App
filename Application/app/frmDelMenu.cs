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
    public partial class frmDelMenu : Form
    {
        private string ConnectionString = "Data Source=Menu.db;Version=3;";

        public frmDelMenu()
        {
            InitializeComponent();
        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string deleteQuery = "DELETE FROM Items WHERE ID = @ID";
            using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, con))
            {
                deleteCmd.Parameters.AddWithValue("@ID", tbID.Text);
                int rowsAffected = deleteCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Item deleted");
                }
                else
                {
                    MessageBox.Show("Item not found");
                }
            }


            con.Close();
        }
    }
}
