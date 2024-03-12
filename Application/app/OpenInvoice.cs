using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace app
{
    public partial class OpenInvoice : Form
    {

        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public OpenInvoice()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            int Id;
            if (!int.TryParse(id.Text, out Id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            byte[] imageData = null;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT image FROM invoice WHERE id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        imageData = (byte[])result;
                    }
                    else
                    {
                        MessageBox.Show("Image not found for the specified ID.");
                        return;
                    }
                }
            }

            // Display the image in the PictureBox control
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("No image data found for the specified ID.");
            }





        }

        private void OpenInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
