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
    public partial class AddPaymentForm : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";


        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (idbox.Text == "" || titlebox.Text == "" || descriptionbox.Text == "")
            {
                MessageBox.Show("Please enter the complete data.");
                return;
            }
            int id = Convert.ToInt32(idbox.Text);
            string title = titlebox.Text;
            string description = descriptionbox.Text;
            DateTime date = datebox.Value.Date;
            int amount = Convert.ToInt32(amountbox.Text);

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Payments (Id, Title, Description,Amount,DueDate) VALUES (@Id, @Title, @Description,@Amount,@DueDate)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@DueDate", date);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment Added Successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
