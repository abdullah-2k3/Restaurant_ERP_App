using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Linq;

namespace app
{
    public partial class HR_Attendance : Form
    {

        private string ConnectionString = "Data Source=HR.db;Version=3;";

        public HR_Attendance()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showAttendance();
        }


        private void showAttendance()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Attendance";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }


        private void InitializeAttendance()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string[] names = {
            "Ali", "Ahmed", "Ameer", "Ahsan", "Usman",
            "Bilal", "Hassan", "Farhan", "Saad", "Imran"
        };

            string[] departments = { "Servings", "Delivery", "Kitchen", "Reception", "Sales" };


            for (int i = 0; i < names.Length; i++)
            {
                string query = "INSERT INTO Attendance(Name, Department, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday) VALUES ('" + names[i] +"' , '" + departments[i%5] +"',1,1,1,1,1,1,1)";

                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {

                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    break;
                }
            }


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

        private bool attendancAction()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string id = tbID.Text;
                    string status = tbStatus.Text;


                    int index = int.Parse(tbDay.Text);

                    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                    string query = $"UPDATE Attendance SET [{days[index-1]}] = @status WHERE Employee_Id = @id";


                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", id);


                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }




        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if (attendancAction())
                MessageBox.Show("Attendance Added");
            else
                MessageBox.Show("Could not add attendance");

            showAttendance();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {

                lblDate.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                MessageBox.Show("Week Date Upadted");
        }
    }
}
