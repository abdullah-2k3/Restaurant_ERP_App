using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace app
{
    public partial class frmAddOrder : Form
    {

        string connectionString = "Data Source = Menu.db; Version = 3";
        string connectionCustomer = "Data Source = Customer.db; Version = 3";
        private double totalprice = 0;
        public frmAddOrder()
        {
            InitializeComponent();
        }
        private void showItems()
        {
            cbItems.Items.Clear();

            string query = "SELECT ItemName FROM Items WHERE Category = @category";

            if (cbCategory.SelectedItem  == null)
            {
                query = "SELECT ItemName FROM Items";
                return;
            }

            string selectedCategory = cbCategory.SelectedItem.ToString();


            

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                connection.Open();

             
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
       
                    command.Parameters.AddWithValue("@category", selectedCategory);

                 
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbItems.Items.Add(reader["ItemName"].ToString());
                        }
                    }
                }
            }
        }

        private double getOrderAmount(string itemname, int quantity)
        {
            double amount = 0; 

            string query = "SELECT Price FROM Items WHERE ItemName = @itemname";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@itemname", itemname);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            amount = Convert.ToDouble(reader["Price"]);
                        }
                    }
                }
            }

            return amount*quantity;
        }

        private void AddOrder()
        {

            SQLiteConnection con = new SQLiteConnection(connectionCustomer);
            con.Open();

            string c_id = tbCustomerID.Text;
            string items = cbItems.Text;
            int quantity = int.Parse(tbQuantity.Text);
            DateTime selectedDate = datePicker.Value;
            string date = selectedDate.ToString("dd-MM-yyyy");
            double amount = getOrderAmount(items, quantity);

            lblPrice.Text = amount.ToString();

            string query = "INSERT INTO Orders(CustomerID, Items, OrderStatus, Amount, PaymentStatus, Date) " +
                            "VALUES (@c_id, @items, 'Active', @amount, 'Not Paid', @date)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@c_id", c_id);
                    cmd.Parameters.AddWithValue("@items", items);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@date", date);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item has been added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Item!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            con.Close();
        }

        private void buttonorder_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "" || tbQuantity.Text == "" || cbItems.Text == "")
            {
                MessageBox.Show("Enter all Details");
                return;
            }
            
            AddOrder();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (cbCategory.Text == "")
            {
                MessageBox.Show("Please Select Category");
            }
            showItems();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (cbItems.Text == "" || cbItems.Text == "Please Select Category")
            {
                return;
            }
            string itemName = cbItems.SelectedItem.ToString(); // Get the selected item name from the ComboBox

            // Query to retrieve the price of the selected item from the Items table
            string query = "SELECT Price FROM Items WHERE ItemName = @itemName";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@itemName", itemName);

                    // Execute the query and retrieve the price
                    object result = command.ExecuteScalar();

                    if (result != null) // Check if a price was retrieved
                    {
                        double price = Convert.ToDouble(result); // Convert the retrieved price to double
                        
                        int quantity = 1;

                        if (tbQuantity.Text != "")
                        {
                            quantity = int.Parse(tbQuantity.Text);
                        }

                        price *= quantity;

                        totalprice += price;
                        string itemInfo = $"{itemName} - Quantity: {quantity}, Price: {price:C}";


                        // Add the item information to the ListBox
                        listBox.Items.Add(itemInfo);

                        lblPrice.Text = totalprice.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Price not found for selected item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            lblPrice.Text = "";
            tbCustomerID.Text = "";
            cbCategory.Text = "";
            cbItems.Text = "";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string total = "Total Bill: " + totalprice.ToString();
            listBox.Items.Add(total);
        }
    }
}
