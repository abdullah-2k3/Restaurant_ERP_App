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
    public partial class Inv_item : Form
    {


        private string ConnectionString = "Data Source=inventory.db;Version=3;";

        public Inv_item()
        {
            InitializeComponent();
            PopulateDropdown();
            show();
        }


        private void PopulateDropdown()
        {
            string[] optionscategory = { "Food Item", "Beverages", "Kitchen Supplies", "Bar Supplies", "Disposable Items", "Miscellaneous"};


            categorydrop.Items.AddRange(optionscategory);
        }


        private void show()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from items";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
           frmInv frmFb = new frmInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = IDbox.Text;
            string name = namebox.Text;
            string quantity = quantitybox.Text;
            string category = categorydrop.SelectedItem?.ToString();
            string brand = brandbox.Text;
            string description = descriptionbox.Text;
            string price = pricebox.Text;
           
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(quantity) ||
                string.IsNullOrEmpty(category) || string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "INSERT INTO items (Id, name, quantity, category, brand, description, price) " +
                                   "VALUES (@Id, @Name, @Quantity, @Category, @Brand, @Description, @Price)";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Item added successfully.");
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
            string id = IDbox.Text;
            string name = namebox.Text;
            string quantity = quantitybox.Text;
            string category = categorydrop.SelectedItem?.ToString();
            string brand = brandbox.Text;
            string description = descriptionbox.Text;
            string price = pricebox.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the item to update.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    StringBuilder queryBuilder = new StringBuilder("UPDATE items SET");
                    List<SQLiteParameter> parameters = new List<SQLiteParameter>();

                    if (!string.IsNullOrEmpty(name))
                    {
                        queryBuilder.Append(" name = @Name,");
                        parameters.Add(new SQLiteParameter("@Name", name));
                    }
                    if (!string.IsNullOrEmpty(quantity))
                    {
                        queryBuilder.Append(" quantity = @Quantity,");
                        parameters.Add(new SQLiteParameter("@Quantity", quantity));
                    }
                    if (!string.IsNullOrEmpty(category))
                    {
                        queryBuilder.Append(" category = @Category,");
                        parameters.Add(new SQLiteParameter("@Category", category));
                    }
                    if (!string.IsNullOrEmpty(brand))
                    {
                        queryBuilder.Append(" brand = @Brand,");
                        parameters.Add(new SQLiteParameter("@Brand", brand));
                    }
                    if (!string.IsNullOrEmpty(description))
                    {
                        queryBuilder.Append(" description = @Description,");
                        parameters.Add(new SQLiteParameter("@Description", description));
                    }
                    if (!string.IsNullOrEmpty(price))
                    {
                        queryBuilder.Append(" price = @Price,");
                        parameters.Add(new SQLiteParameter("@Price", price));
                    }

                    if (queryBuilder[queryBuilder.Length - 1] == ',')
                    {
                        queryBuilder.Remove(queryBuilder.Length - 1, 1);
                    }

                    queryBuilder.Append(" WHERE Id = @Id");
                    parameters.Add(new SQLiteParameter("@Id", id));

                    SQLiteCommand cmd = new SQLiteCommand(queryBuilder.ToString(), con);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item updated successfully.");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("No item found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = IDbox.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the item to delete.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "DELETE FROM items WHERE id = @Id";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item deleted successfully.");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("No item found with the provided ID.");
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
