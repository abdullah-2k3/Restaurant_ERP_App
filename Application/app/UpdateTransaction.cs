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
    public partial class UpdateTransaction : Form
    {

        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public UpdateTransaction()
        {
            InitializeComponent();
            PopulateDropdown();
        }

        private void PopulateDropdown()
        {
            string[] optionsType = { "INFLOW", "OUTFLOW" };
            string[] optionsarea = { "OPERATING", "INVESTING", "GOODS SOLD", "TAXES & Others" };

            typemenu.Items.AddRange(optionsType);

            areamenu.Items.AddRange(optionsarea);
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (idbox.Text == "" || titlebox.Text == "" || descriptionbox.Text == "" || typemenu.SelectedItem == null || areamenu.SelectedItem==null)
            {
                MessageBox.Show("Please enter the complete data.");
                return;
            }
            int id = Convert.ToInt32(idbox.Text);
            string title = titlebox.Text;
            string description = descriptionbox.Text;
            string type = typemenu.SelectedItem.ToString();
            string areaOfExpenditure = areamenu.SelectedItem.ToString();
            DateTime date = dateTime.Value;
            int amount = Convert.ToInt32(amountbox.Text);

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Transactions SET title = @Title, description = @Description, Type = @Type, ExpenseArea = @ExpenseArea, date = @Date , Amount = @Amount WHERE Id = @Id";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@ExpenseArea", areaOfExpenditure);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Transaction Updated Successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
