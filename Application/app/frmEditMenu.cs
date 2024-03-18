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
    public partial class frmEditMenu : Form
    {
        private string ConnectionString = "Data Source=Menu.db;Version=3;";

        public frmEditMenu()
        {
            InitializeComponent();
            showMenu();
        }

        private void showMenu()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Items";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }


        private void AddItem()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();
            string id = tbID.Text;
            string name = tbName.Text;
            string category = cbCategory.Text;
            string price = tbPrice.Text;

            string query = "INSERT INTO Items(Id, ItemName, Category, Price) " +
                            "VALUES (@id, @name, @category, @price)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@price", price);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Item!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            con.Close();
        }

        private void DeleteItem()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    string id = tbID.Text;

                    string query = "DELETE FROM Items WHERE Id = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item has been Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Item not found!");
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void UpdateItem()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string id = tbID.Text;
            string name = tbName.Text;
            string category = cbCategory.Text;
            string price = tbPrice.Text;

            string query = "UPDATE Items SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(name))
                columnsToUpdate.Add("ItemName = @name");
            if (!string.IsNullOrEmpty(category))
                columnsToUpdate.Add("Category = @category");
            if (!string.IsNullOrEmpty(price))
                columnsToUpdate.Add("Price = @price");
      
            query += string.Join(", ", columnsToUpdate);

            query += " WHERE Id = @id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@id", id);
                    if (!string.IsNullOrEmpty(name))
                        cmd.Parameters.AddWithValue("@name", name);
                    if (!string.IsNullOrEmpty(category))
                        cmd.Parameters.AddWithValue("@category", category);
                    if (!string.IsNullOrEmpty(price))
                        cmd.Parameters.AddWithValue("@price", price);
                    

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item has been updated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Item!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            con.Close();
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Item ID...");
                return;
            }
            DeleteItem();
            showMenu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPrice.Text == "" || cbCategory.Text == "")
            {
                MessageBox.Show("Enter Item Details...");
                return;
            }
            AddItem();
            showMenu();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateItem();
            showMenu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
