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
    public partial class frmVisits : Form
    {

        private string ConnectionString = "Data Source=Customer.db;Version=3;";
        public frmVisits()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showVisits();
        }

        private void showVisits()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Visits";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {

                using (Brush backColorBrush = new SolidBrush(Color.LightBlue))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                // Set the font of the header cell to bold
                e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

                // Draw the cell's t
                // ext
                e.PaintContent(e.ClipBounds);

                e.Handled = true;
            }
        }


        private void AddVisit()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();
            string id = tbID.Text;
            string name = tbName.Text;
            string day = tbDay.Text;
            string bill = tbAmount.Text;

            string query = "INSERT INTO Visits(C_ID, Name, VisitDay, BillAmount) " +
                            "VALUES (@id, @name, @day, @bill)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@day", day);
                    cmd.Parameters.AddWithValue("@bill", bill);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Visit has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Visit!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            con.Close();
        }

        private void DeleteVisit()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    string id = tbID.Text;

                    string query = "DELETE FROM Visits WHERE C_ID = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Visit has been Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
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

        private void UpdateVisit()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string id = tbID.Text;
            string name = tbName.Text;
            string day = tbDay.Text;
            string bill = tbAmount.Text;

            string query = "UPDATE Visits SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(name))
                columnsToUpdate.Add("Name = @name");
            if (!string.IsNullOrEmpty(day))
                columnsToUpdate.Add("VisitDay = @day");
            if (!string.IsNullOrEmpty(bill))
                columnsToUpdate.Add("BillAmount = @bill");


            query += string.Join(", ", columnsToUpdate);

            query += " WHERE C_ID = @id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@id", id);
                    if (!string.IsNullOrEmpty(name))
                        cmd.Parameters.AddWithValue("@name", name);
                    if (!string.IsNullOrEmpty(day))
                        cmd.Parameters.AddWithValue("@day", day);
                    if (!string.IsNullOrEmpty(bill))
                        cmd.Parameters.AddWithValue("@bill", bill);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Visit has been updated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Visit!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            con.Close();
        }


        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Customer ID");
            }
            else
            {
                AddVisit();
            }
            showVisits();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Customer ID");
            }
            else
            {
                UpdateVisit();
            }
            showVisits();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Customer ID");
            }
            else
            {
                DeleteVisit();
            }
            showVisits();
        }
    }
}
