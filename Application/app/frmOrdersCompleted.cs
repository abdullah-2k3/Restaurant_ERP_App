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
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace app
{
    public partial class frmOrdersCompleted : Form
    {

        string ConnectionString = "Data Source = Customer.db; Version = 3";
        public frmOrdersCompleted()
        {
            InitializeComponent();
            showOrders();
        }

        private void showOrders()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from Orders WHERE OrderStatus = 'Completed'";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }



        private void DeleteOrder()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    string id = tbOrderID.Text;

                    string query = "DELETE FROM Orders WHERE OrderId = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order has been Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Order not found!");
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

        private void UpdateOrder()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();

            string o_id = tbOrderID.Text;
            string c_id = tbCustomerID.Text;
            string items = tbItems.Text;
            string o_status = cbOrderStatus.Text;
            string amount = tbAmount.Text;
            string payment = cbPayStatus.Text;
            string date = tbDate.Text;

            string query = "UPDATE Orders SET ";

            List<string> columnsToUpdate = new List<string>();

            if (!string.IsNullOrEmpty(c_id))
                columnsToUpdate.Add("CustomerID = @c_id");
            if (!string.IsNullOrEmpty(items))
                columnsToUpdate.Add("Items = @items");
            if (!string.IsNullOrEmpty(o_status))
                columnsToUpdate.Add("OrderStatus = @o_status");
            if (!string.IsNullOrEmpty(amount))
                columnsToUpdate.Add("Amount = @amount");
            if (!string.IsNullOrEmpty(payment))
                columnsToUpdate.Add("PaymentStatus = @payment");
            if (!string.IsNullOrEmpty(date))
                columnsToUpdate.Add("Date = @date");

            query += string.Join(", ", columnsToUpdate);

            query += " WHERE OrderID = @o_id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@o_id", o_id);
                    if (!string.IsNullOrEmpty(c_id))
                        cmd.Parameters.AddWithValue("@c_id", c_id);
                    if (!string.IsNullOrEmpty(items))
                        cmd.Parameters.AddWithValue("@items", items);
                    if (!string.IsNullOrEmpty(o_status))
                        cmd.Parameters.AddWithValue("@o_status", o_status);
                    if (!string.IsNullOrEmpty(amount))
                        cmd.Parameters.AddWithValue("@amount", amount);
                    if (!string.IsNullOrEmpty(payment))
                        cmd.Parameters.AddWithValue("@payment", payment);
                    if (!string.IsNullOrEmpty(date))
                        cmd.Parameters.AddWithValue("@date", date);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order has been updated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Order!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbOrderID.Text == "")
            {
                MessageBox.Show("Enter Order ID");
                return;
            }
            UpdateOrder();
            showOrders();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbOrderID.Text == "")
            {
                MessageBox.Show("Enter Order ID");
                return;
            }
            DeleteOrder();
            showOrders();
        }
    }
}
