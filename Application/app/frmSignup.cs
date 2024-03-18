using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Xml.Linq;

namespace app
{
    public partial class frmSignup : Form
    {

        string connectionstring = "Data Source = HR.db; version = 3";
        public frmSignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string pass = tbPass.Text;

            if (name == "" || pass == "")
            {
                MessageBox.Show("Enter both username and password");
                return;
            }

            string query = "INSERT INTO Admin (Name, Password) VALUES  (@name,@pass)";

            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully!");
                        tbName.Clear();
                        tbPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.");
                    }

                }
                con.Close();
            }
        }

        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
