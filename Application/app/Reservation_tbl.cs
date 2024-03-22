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
    public partial class Reservation_tbl : Form
    {

        private string ConnectionString = "Data Source=Table.db;Version=3;";

        public Reservation_tbl()
        {
            InitializeComponent();
            PopulateDropdown();
            show();
        }


        private void PopulateDropdown()
        {
            string[] optionscategory = { "Family", "Couple", "VIP", "Corner", "Outdoor", "Large Group", "Private Dining", "High-top" };

            categorydrop.Items.AddRange(optionscategory);
        }


        private void show()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from reservations";

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;
            string name = namebox.Text;
            string persons = personsbox.Text;
            string category = categorydrop.SelectedItem?.ToString();
            string description = descriptionbox.Text;
            string time = timebox.Text;

            string date = datebox.Value.Date.ToString("yyyy-MM-dd");

           
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(persons) ||
                string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "INSERT INTO reservations (Id, name, persons, category, description, time, date) " +
                                   "VALUES (@Id, @Name, @Persons, @Category, @Description, @Time, @Date)";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Persons", persons);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.Parameters.AddWithValue("@Date", date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reservation added successfully.");
                    show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;


            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the Reservation to delete.");
                return;
            }


            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "DELETE FROM reservations where Id= @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reservation deleted successfully.");
                    show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;
            string name = namebox.Text;
            string persons = personsbox.Text;
            string category = categorydrop.SelectedItem?.ToString();
            string description = descriptionbox.Text;
            string time = timebox.Text;

            string date = datebox.Value.Date.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the reservation to update.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    StringBuilder queryBuilder = new StringBuilder("UPDATE reservations SET ");
                    List<SQLiteParameter> parameters = new List<SQLiteParameter>();

                    if (!string.IsNullOrEmpty(name))
                    {
                        queryBuilder.Append("name = @Name, ");
                        parameters.Add(new SQLiteParameter("@Name", name));
                    }

                    if (!string.IsNullOrEmpty(persons))
                    {
                        queryBuilder.Append("persons = @Persons, ");
                        parameters.Add(new SQLiteParameter("@Persons", persons));
                    }

                    if (!string.IsNullOrEmpty(category))
                    {
                        queryBuilder.Append("category = @Category, ");
                        parameters.Add(new SQLiteParameter("@Category", category));
                    }

                    if (!string.IsNullOrEmpty(description))
                    {
                        queryBuilder.Append("description = @Description, ");
                        parameters.Add(new SQLiteParameter("@Description", description));
                    }

                    if (!string.IsNullOrEmpty(time))
                    {
                        queryBuilder.Append("time = @Time, ");
                        parameters.Add(new SQLiteParameter("@Time", time));
                    }

                    queryBuilder.Append("date = @Date WHERE id = @Id");
                    parameters.Add(new SQLiteParameter("@Date", date));
                    parameters.Add(new SQLiteParameter("@Id", id));

                    string query = queryBuilder.ToString();

                    if (parameters.Count > 0)
                    {
                        query = query.TrimEnd(',', ' '); // Remove the trailing comma and space
                        SQLiteCommand cmd = new SQLiteCommand(query, con);
                        cmd.Parameters.AddRange(parameters.ToArray());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Reservation updated successfully.");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("No fields provided to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
