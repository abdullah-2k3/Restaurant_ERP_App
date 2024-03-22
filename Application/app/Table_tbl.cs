using Bunifu.UI.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace app
{
    public partial class Table_tbl : Form
    {
        private string ConnectionString = "Data Source=Table.db;Version=3;";


        public Table_tbl()
        {
            InitializeComponent();
            PopulateDropdown();
            show();
        }


        private void PopulateDropdown()
        {
            string[] optionsstatus = { "Ocupied", "Vacent","Cleaning", "Reserved", "Ready", "Closed for Maintenance" };
            string[] optionscategory = { "Family", "Couple", "VIP", "Corner", "Outdoor", "Large Group", "Private Dining","High-top"};

            statusdrop.Items.AddRange(optionsstatus);

            categoriesdrop.Items.AddRange(optionscategory);
        }


        private void show()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from tables";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmTables frmFb = new frmTables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string id = idbox.Text;
            string floor = floorbox.Text;
            string chairs = chairsbox.Text;
            string category = categoriesdrop.SelectedItem?.ToString();
            string status = statusdrop.SelectedItem?.ToString();
            string description = descriptionbox.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(floor) || string.IsNullOrEmpty(chairs) ||
                string.IsNullOrEmpty(category) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "INSERT INTO tables (id, floor, chairs, category, status, description) " +
                                   "VALUES (@Id, @Floor, @Chairs, @Category, @Status, @Description)";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Floor", floor);
                    cmd.Parameters.AddWithValue("@Chairs", chairs);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Table added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            show();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;


            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the table to delete.");
                return;
            }


            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "DELETE FROM tables where Id= @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Table deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;


            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the table to update.");
                return;
            }

            string floor = floorbox.Text;
            string chairs = chairsbox.Text;
            string category = categoriesdrop.SelectedItem?.ToString();
            string status = statusdrop.SelectedItem?.ToString();
            string description = descriptionbox.Text;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    StringBuilder queryBuilder = new StringBuilder("UPDATE tables SET ");
                    List<SQLiteParameter> parameters = new List<SQLiteParameter>();

                    if (!string.IsNullOrEmpty(floor))
                    {
                        queryBuilder.Append("floor = @Floor, ");
                        parameters.Add(new SQLiteParameter("@Floor", floor));
                    }
                    if (!string.IsNullOrEmpty(chairs))
                    {
                        queryBuilder.Append("chairs = @Chairs, ");
                        parameters.Add(new SQLiteParameter("@Chairs", chairs));
                    }
                    if (!string.IsNullOrEmpty(category))
                    {
                        queryBuilder.Append("category = @Category, ");
                        parameters.Add(new SQLiteParameter("@Category", category));
                    }
                    if (!string.IsNullOrEmpty(status))
                    {
                        queryBuilder.Append("status = @Status, ");
                        parameters.Add(new SQLiteParameter("@Status", status));
                    }
                    if (!string.IsNullOrEmpty(description))
                    {
                        queryBuilder.Append("description = @Description");
                        parameters.Add(new SQLiteParameter("@Description", description));
                    }


                    queryBuilder.Append(" WHERE id = @Id");
                    parameters.Add(new SQLiteParameter("@Id", id));

                    string query = queryBuilder.ToString();
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Table updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No matching table found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            show();
        }

        private void Table_tbl_Load(object sender, EventArgs e)
        {

        }
    }
}
