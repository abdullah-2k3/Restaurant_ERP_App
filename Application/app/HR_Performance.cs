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
    public partial class HR_Performance : Form
    {

        private string ConnectionString = "Data Source=HR.db;Version=3;";
        public HR_Performance()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showPerformance();
        }

        private void showPerformance()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Performance";

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
            string mid = tbMID.Text;
            string dep = tbDep.Text;
            string rank = tbRank.Text;
            string ratings = tbRating.Text;
            string promo = tbPromo.Text;
            string bonus = tbBonus.Text;

            string query = "INSERT INTO Performance(Employee_Id, Name, Manager_Id, Department, Rank, [CustomerRatings(%)], Promotions, BonusSalary) " +
                            "VALUES (@id, @name, @mid, @dep, @rank, @ratings, @promo, @bonus)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@mid", mid);
                    cmd.Parameters.AddWithValue("@dep", dep);
                    cmd.Parameters.AddWithValue("@rank", rank);
                    cmd.Parameters.AddWithValue("@ratings", ratings);
                    cmd.Parameters.AddWithValue("@promo", promo);
                    cmd.Parameters.AddWithValue("@bonus", bonus);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Performance has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Performance!");
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
            string mid = tbMID.Text;
            string dep = tbDep.Text;
            string rank = tbRank.Text;
            string ratings = tbRating.Text;
            string promo = tbPromo.Text;
            string bonus = tbBonus.Text;

            string query = "UPDATE Performance SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(name))
                columnsToUpdate.Add("Name = @name");
            if (!string.IsNullOrEmpty(mid))
                columnsToUpdate.Add("Manager_ID = @mid");
            if (!string.IsNullOrEmpty(dep))
                columnsToUpdate.Add("Department = @dep");
            if (!string.IsNullOrEmpty(rank))
                columnsToUpdate.Add("Rank = @rank");
            if (!string.IsNullOrEmpty(ratings))
                columnsToUpdate.Add("[CustomerRatings(%)] = @ratings"); 
            if (!string.IsNullOrEmpty(promo))
                columnsToUpdate.Add("Promotions = @promo");
            if (!string.IsNullOrEmpty(bonus))
                columnsToUpdate.Add("BonusSalary = @bonus");

            query += string.Join(", ", columnsToUpdate);

            query += " WHERE Employee_ID = @id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (!string.IsNullOrEmpty(name))
                        cmd.Parameters.AddWithValue("@name", name);
                    if (!string.IsNullOrEmpty(mid))
                        cmd.Parameters.AddWithValue("@mid", mid);
                    if (!string.IsNullOrEmpty(dep))
                        cmd.Parameters.AddWithValue("@dep", dep);
                    if (!string.IsNullOrEmpty(rank))
                        cmd.Parameters.AddWithValue("@rank", rank);
                    if (!string.IsNullOrEmpty(ratings))
                        cmd.Parameters.AddWithValue("@ratings", ratings);
                    if (!string.IsNullOrEmpty(promo))
                        cmd.Parameters.AddWithValue("@promo", promo);
                    if (!string.IsNullOrEmpty(bonus))
                        cmd.Parameters.AddWithValue("@bonus", bonus);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Performance has been updated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Performance!");
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

                    string query = "DELETE FROM Performance WHERE Employee_ID = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Performance record has been Deleted!");
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
            showPerformance();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else
                UpdateRecord();

            showPerformance();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else
                DeleteRecord();

            showPerformance();
        }
    }
}
