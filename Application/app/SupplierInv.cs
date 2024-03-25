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
    public partial class SupplierInv : Form
    {
        private string ConnectionString = "Data Source=inventory.db;Version=3;";

        public SupplierInv()
        {
            InitializeComponent();
            show();
        }


        private void show()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from suppliers";

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
            frmInv frmFb = new frmInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string id = IDbox.Text;
            string name = Namebox.Text;
            string brand = brandbox.Text;
            string description = descriptionbox.Text;
            string phone = phonebox.Text;
            
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||  string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "INSERT INTO suppliers (Id, name, phone, brand, description) " +
                                   "VALUES (@Id, @Name, @Phone, @Brand, @Description)";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier added successfully.");
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
            string name = Namebox.Text;
            string brand = brandbox.Text;
            string description = descriptionbox.Text;
            string phone = phonebox.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the Supplier to update.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    StringBuilder queryBuilder = new StringBuilder("UPDATE suppliers SET");
                    List<SQLiteParameter> parameters = new List<SQLiteParameter>();

                    if (!string.IsNullOrEmpty(name))
                    {
                        queryBuilder.Append(" name = @Name,");
                        parameters.Add(new SQLiteParameter("@Name", name));
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
                    if (!string.IsNullOrEmpty(phone))
                    {
                        queryBuilder.Append(" phone = @phone");
                        parameters.Add(new SQLiteParameter("@phone", phone));
                    }


                    queryBuilder.Append(" WHERE Id = @Id");
                    parameters.Add(new SQLiteParameter("@Id", id));

                    SQLiteCommand cmd = new SQLiteCommand(queryBuilder.ToString(), con);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Supplier updated successfully.");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("No Supplier found with the provided ID.");
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
                MessageBox.Show("Please provide the ID of the supplier to delete.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string query = "DELETE FROM suppliers WHERE id = @Id";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("supplier deleted successfully.");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("No supplier found with the provided ID.");
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
