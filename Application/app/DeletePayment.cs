﻿using System;
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
    public partial class DeletePayment : Form
    {
        private string ConnectionString = "Data Source=Finance.db;Version=3;";

        public DeletePayment()
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

                string query = "DELETE FROM Payments WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Transaction deleted successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Transaction found with the specified ID.");
                    }
                }
            }
            idbox.Clear();
        }
    }
}