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
    public partial class DeleteInvoice : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public DeleteInvoice()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            int Id;
            if (!int.TryParse(idbox.Text, out Id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM invoice WHERE id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Invoice deleted successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No invoice found with the specified ID.");
                    }
                }
            }
            idbox.Clear();

        }
    }
}
