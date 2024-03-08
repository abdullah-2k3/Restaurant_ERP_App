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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace app
{
    public partial class HR_Timecards : Form
    {

        private string ConnectionString = "Data Source=HR.db;Version=3;";
        public HR_Timecards()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showTimecards();
        }


        private void showTimecards()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Timecards";

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
            string id = tbID.Text;
            string name = tbName.Text;
            string date = tbDate.Text;
            string ETime = tbEnterTime.Text;
            string THours = tbTotalHours.Text;
            string BHours = tbBreakHours.Text;
            string status = tbStatus.Text;

            string query = "INSERT INTO Timecards(Employee_Id, Name, Date, EntryTime, TotalHours, BreakHours, ApprovalStatus) " +
                            "VALUES (@id, @name, @date, @ETime, @THours, @BHours, @status)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@ETime", ETime);
                    cmd.Parameters.AddWithValue("@THours", THours);
                    cmd.Parameters.AddWithValue("@BHours", BHours);
                    cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Timecard has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Timecard!");
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

            string id = tbID.Text;
            string name = tbName.Text;
            string date = tbDate.Text;
            string ETime = tbEnterTime.Text;
            string THours = tbTotalHours.Text;
            string BHours = tbBreakHours.Text;
            string status = tbStatus.Text;

            string query = "UPDATE Timecards SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(name))
                columnsToUpdate.Add("Name = @name");
            if (!string.IsNullOrEmpty(date))
                columnsToUpdate.Add("Date = @date");
            if (!string.IsNullOrEmpty(ETime))
                columnsToUpdate.Add("EntryTime = @ETime");
            if (!string.IsNullOrEmpty(THours))
                columnsToUpdate.Add("TotalHours = @THours");
            if (!string.IsNullOrEmpty(BHours))
                columnsToUpdate.Add("BreakHours = @BHours");
            if (!string.IsNullOrEmpty(status))
                columnsToUpdate.Add("ApprovalStatus = @status");
            query += string.Join(", ", columnsToUpdate);

            query += " WHERE Employee_ID = @id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (!string.IsNullOrEmpty(name))
                        cmd.Parameters.AddWithValue("@name", name);
                    if (!string.IsNullOrEmpty(date))
                        cmd.Parameters.AddWithValue("@date", date);
                    if (!string.IsNullOrEmpty(ETime))
                        cmd.Parameters.AddWithValue("@ETime", ETime);
                    if (!string.IsNullOrEmpty(THours))
                        cmd.Parameters.AddWithValue("@THours", THours);
                    if (!string.IsNullOrEmpty(BHours))
                        cmd.Parameters.AddWithValue("@BHours", BHours);
                    if (!string.IsNullOrEmpty(status))
                        cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Timecard has been updated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Timecard!");
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
                    string id = tbID.Text;

                    string query = "DELETE FROM Timecards WHERE Employee_ID = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Timecard has been Deleted!");
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
            showTimecards();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else
                UpdateRecord();

            showTimecards();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {

            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else
                DeleteRecord();

            showTimecards();
        }
    }
}
