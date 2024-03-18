using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace app
{
    public partial class HR_PayJournal : Form
    {
        private string ConnectionString = "Data Source=HR.db;Version=3;";
        public HR_PayJournal()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            lblDate.Text = dateTimePicker1.Value.ToString("MMMM-yyyy");
            showPayroll();
        }

        private void showPayroll()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from PayrollJournal";

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

        private void AddRecord()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();
            string tid = tbTID.Text;
            string eid = tbEID.Text;
            string date = tbDate.Text;
            string amount = tbAmount.Text;
            string tax = tbTax.Text;
            string des = tbDes.Text;
            string status = tbStatus.Text;

            string query = "INSERT INTO PayrollJournal(Transaction_ID, Employee_Id, Date, Amount, TaxWithholding, Description, ApprovalStatus) " +
                            "VALUES (@tid, @eid, @date, @amount, @tax, @des, @status)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.Parameters.AddWithValue("@eid", eid);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@tax", tax);
                    cmd.Parameters.AddWithValue("@des", des);
                    cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Journal record has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add record!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            con.Close();
        }


        private void UpdateRecord()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string tid = tbTID.Text;
            string eid = tbEID.Text;
            string date = tbDate.Text;
            string amount = tbAmount.Text;
            string tax = tbTax.Text;
            string des = tbDes.Text;
            string status = tbStatus.Text;

            string query = "UPDATE PayrollJournal SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(eid))
                columnsToUpdate.Add("Employee_ID = @eid");
            if (!string.IsNullOrEmpty(date))
                columnsToUpdate.Add("Date = @date");
            if (!string.IsNullOrEmpty(amount))
                columnsToUpdate.Add("Amount = @amount");
            if (!string.IsNullOrEmpty(tax))
                columnsToUpdate.Add("TaxWithholding = @tax");
            if (!string.IsNullOrEmpty(des))
                columnsToUpdate.Add("Description = @des");
            if (!string.IsNullOrEmpty(status))
                columnsToUpdate.Add("ApprovalStatus = @status");

            query += string.Join(", ", columnsToUpdate);

            query += " WHERE Transaction_ID = @tid";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@tid", tid);
                    if (!string.IsNullOrEmpty(eid))
                        cmd.Parameters.AddWithValue("@eid", eid);
                    if (!string.IsNullOrEmpty(date))
                        cmd.Parameters.AddWithValue("@date", date);
                    if (!string.IsNullOrEmpty(amount))
                        cmd.Parameters.AddWithValue("@amount", amount);
                    if (!string.IsNullOrEmpty(tax))
                        cmd.Parameters.AddWithValue("@tax", tax);
                    if (!string.IsNullOrEmpty(des))
                        cmd.Parameters.AddWithValue("@des", des);
                    if (!string.IsNullOrEmpty(status))
                        cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Journal has been updated!");
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            con.Close();
        }



        private void DeleteRecord()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    string tid = tbTID.Text;

                    string query = "DELETE FROM PayrollJournal WHERE Transaction_ID = @tid";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tid", tid);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Journal record has been Deleted!");
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

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddRecord();
            showPayroll();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (tbTID.Text == "")
            {
                MessageBox.Show("Enter Transaction ID!");
            }
            else
                DeleteRecord();

            showPayroll();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (tbTID.Text == "")
            {
                MessageBox.Show("Enter Transaction ID!");
            }
            else
                UpdateRecord();

            showPayroll();
        }

        private void btnSetMonth_Click(object sender, EventArgs e)
        {
            lblDate.Text = dateTimePicker1.Value.ToString("MMMM-yyyy");

            MessageBox.Show("Month Upadted");
        }
    }
}
