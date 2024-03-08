using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace app
{

    public partial class HR_Employees : Form
    {
        private string ConnectionString = "Data Source=HR.db;Version=3;";
        public HR_Employees()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showEmployees();
        }

        private void showEmployees()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Employees";

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



        private void AddEmployee()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();
            string id = tbID.Text;
            string name = tbName.Text;
            string age = tbAge.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            string dep = tbDept.Text;
            string salary = tbSalary.Text;
            string status = tbStatus.Text;

            string query = "INSERT INTO Employees(Id, Name, Age, Email, Phone, Department, Salary, Status) " +
                            "VALUES (@id, @name, @age, @email, @phone, @dep, @salary, @status)";

            try 
            { 
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@dep", dep);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Employee!");
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            con.Close();
        }

        private void DeleteEmployee()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    string id = tbID.Text;

                    string query = "DELETE FROM Employees WHERE Id = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee has been Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Employee not found!");
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

        private void UpdateEmployee()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string id = tbID.Text;
            string name = tbName.Text;
            string age = tbAge.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            string dep = tbDept.Text;
            string salary = tbSalary.Text;
            string status = tbStatus.Text;

            string query = "UPDATE Employees SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(name))
                columnsToUpdate.Add("Name = @name");
            if (!string.IsNullOrEmpty(age))
                columnsToUpdate.Add("Age = @age");
            if (!string.IsNullOrEmpty(email))
                columnsToUpdate.Add("Email = @email");
            if (!string.IsNullOrEmpty(phone))
                columnsToUpdate.Add("Phone = @phone");
            if (!string.IsNullOrEmpty(dep))
                columnsToUpdate.Add("Department = @dep");
            if (!string.IsNullOrEmpty(salary))
                columnsToUpdate.Add("Salary = @salary");
            if (!string.IsNullOrEmpty(status))
                columnsToUpdate.Add("Status = @status");

            query += string.Join(", ", columnsToUpdate);

            query += " WHERE Id = @id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@id", id);
                    if (!string.IsNullOrEmpty(name))
                        cmd.Parameters.AddWithValue("@name", name);
                    if (!string.IsNullOrEmpty(age))
                        cmd.Parameters.AddWithValue("@age", age);
                    if (!string.IsNullOrEmpty(email))
                        cmd.Parameters.AddWithValue("@email", email);
                    if (!string.IsNullOrEmpty(phone))
                        cmd.Parameters.AddWithValue("@phone", phone);
                    if (!string.IsNullOrEmpty(dep))
                        cmd.Parameters.AddWithValue("@dep", dep);
                    if (!string.IsNullOrEmpty(salary))
                        cmd.Parameters.AddWithValue("@salary", salary);
                    if (!string.IsNullOrEmpty(status))
                        cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee has been updated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Employee!");
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
            AddEmployee();
            showEmployees();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
      
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else
                DeleteEmployee();

            showEmployees();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else
                UpdateEmployee();

            showEmployees();
        }
    }
}
