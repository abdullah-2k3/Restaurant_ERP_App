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
    public partial class frmLogin : Form
    {
        string connectionstring = "Data Source = HR.db; version = 3";
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string pass = tbPass.Text;

            if (name == "" ||  pass == "")
            {
                MessageBox.Show("Enter both username and password");
                return;
            } 
           
            string query = "SELECT COUNT(*) FROM Admin WHERE Name = @name AND Password = @pass";

            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Invalid username or password.");
                        tbName.Clear();
                        tbPass.Clear();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                con.Close();
            }
            
        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            frmSignup sForm = new frmSignup();
            this.Hide();
            sForm.ShowDialog();
            this.Show();
           
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                tbPass.PasswordChar = '\0';
                tbPass.Font = new Font(tbPass.Font.FontFamily, 10, FontStyle.Regular);
            }
            else
            {
                tbPass.PasswordChar = '*';
                tbPass.Font = new Font(tbPass.Font.FontFamily, 12, FontStyle.Bold);
            }
        }
    }
}
