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
    public partial class frmAddLoyalty : Form
    {
        private string ConnectionString = "Data Source=Customer.db;Version=3;";
        public frmAddLoyalty()
        {
            InitializeComponent();
        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string id = tbID.Text;
                    string name = tbName.Text;
                    string visits = tbVisits.Text;
                    string date = tbreg.Text;
                    string mem = tbmembership.Text;
                    string email = tbEmail.Text;

                    string query = "INSERT INTO CustomerLoyaltyTbl(C_Id, Name, Visits, RegistrationDate, MembershipStatus, Email) VALUES (@id, @name, @visits, @date, @mem, @email)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@visits", visits);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@mem", mem);
                        cmd.Parameters.AddWithValue("@email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer has been added!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
