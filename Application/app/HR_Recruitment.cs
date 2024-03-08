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
    public partial class HR_Recruitment : Form
    {

        private string ConnectionString = "Data Source=HR.db;Version=3;";
        public HR_Recruitment()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showRecruitments();
        }

        private void showRecruitments()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Recruitments";

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
            string title = tbTitle.Text;
            string Dept = tbDept.Text;
            string Des = tbDes.Text;
            string salary = tbSalary.Text;
            string deadline = tbDeadline.Text;
         

            string query = "INSERT INTO Recruitments(Job_ID, JobTitle, Department, Description, ExpectedSalary, Deadline) " +
                            "VALUES (@id, @title, @Dept, @Des, @salary, @deadline)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@Dept", Dept);
                    cmd.Parameters.AddWithValue("@Des", Des);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@deadline", deadline);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Recruitment has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Recruitment!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            con.Close();
        }

        private void DeleteRecords()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    string id = tbID.Text;

                    string query = "DELETE FROM Recruitments WHERE Job_ID = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record has been Deleted!");
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

        private void UpdateRecords()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string id = tbID.Text;
            string title = tbTitle.Text;
            string Dept = tbDept.Text;
            string Des = tbDes.Text;
            string salary = tbSalary.Text;
            string deadline = tbDeadline.Text;

            string query = "UPDATE Recruitments SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(title))
                columnsToUpdate.Add("JobTitle = @title");
            if (!string.IsNullOrEmpty(Dept))
                columnsToUpdate.Add("Department = @Dept");
            if (!string.IsNullOrEmpty(Des))
                columnsToUpdate.Add("Description = @Des");
            if (!string.IsNullOrEmpty(salary))
                columnsToUpdate.Add("ExpectedSalary = @salary");
            if (!string.IsNullOrEmpty(deadline))
                columnsToUpdate.Add("Deadline= @deadline");

            query += string.Join(", ", columnsToUpdate);

            query += " WHERE Job_ID = @id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@id", id);
                    if (!string.IsNullOrEmpty(title))
                        cmd.Parameters.AddWithValue("@title", title);
                    if (!string.IsNullOrEmpty(Dept))
                        cmd.Parameters.AddWithValue("@Dept", Dept);
                    if (!string.IsNullOrEmpty(Des))
                        cmd.Parameters.AddWithValue("@Des", Des);
                    if (!string.IsNullOrEmpty(salary))
                        cmd.Parameters.AddWithValue("@salary", salary);
                    if (!string.IsNullOrEmpty(deadline))
                        cmd.Parameters.AddWithValue("@deadline", deadline);
 

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Recruitment has been updated!");
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


        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
                MessageBox.Show("Enter Job ID!");

            else
                AddRecord();

            showRecruitments();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
                MessageBox.Show("Enter Job ID!");

            else
                UpdateRecords();

            showRecruitments();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
                MessageBox.Show("Enter Job ID!");

            else
                DeleteRecords();

            showRecruitments();
        }
    }
}
