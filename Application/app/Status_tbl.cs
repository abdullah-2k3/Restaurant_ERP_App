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
    public partial class Status_tbl : Form
    {
        private string ConnectionString = "Data Source=Table.db;Version=3;";

        public Status_tbl()
        {
            InitializeComponent();
            PopulateDropdown();
            show();
        }

        private void PopulateDropdown()
        {
            string[] optionsstatus = { "Ocupied", "Vacent", "Cleaning", "Reserved", "Ready", "Closed for Maintenance" };

            statusdrop.Items.AddRange(optionsstatus);

        }


        private void show()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select id,floor,status from tables";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmTables frmFb = new frmTables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the table to update the status.");
                return;
            }

            string status = statusdrop.SelectedItem?.ToString();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    StringBuilder queryBuilder = new StringBuilder("UPDATE tables SET status = @Status WHERE Id = @Id");
                    SQLiteCommand cmd = new SQLiteCommand(queryBuilder.ToString(), con);

                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status updated!");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("No table found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
