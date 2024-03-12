using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class AddInvoiceForm : Form
    {

        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public AddInvoiceForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

           
            int id;
            if (!int.TryParse(idbox.Text, out id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }
            string title = titlebox.Text.Trim();
            string description = descriptionbox.Text.Trim();
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter valid title and description.");
                return;
            }
            
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            byte[] imageBytes = null;
            if (pictureBox.Image != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
                    imageBytes = memoryStream.ToArray();
                }
            }


            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Check if the ID already exists in the table
                string checkQuery = "SELECT COUNT(*) FROM Invoice WHERE id = @Id";
                using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Id", id);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("ID already exists in the invoice table.");
                        return;
                    }
                }

                // Insert data into the invoice table
                string insertQuery = "INSERT INTO Invoice (id, title, description, image) VALUES (@Id, @Title, @Description, @Image)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Id", id);
                    insertCommand.Parameters.AddWithValue("@Title", title);
                    insertCommand.Parameters.AddWithValue("@Description", description);
                    if (imageBytes == null)
                        insertCommand.Parameters.AddWithValue("@Image", DBNull.Value);
                    else
                        insertCommand.Parameters.AddWithValue("@Image", imageBytes);

                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Invoice Added");

            }
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";
            open.ShowDialog();
            if (open.FileName != "")
            {

                pictureBox.ImageLocation = open.FileName;

            }
        }
    }
}
