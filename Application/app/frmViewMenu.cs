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
    public partial class frmViewMenu : Form
    {
        public frmViewMenu()
        {
            InitializeComponent();

            
            LoadFormData();
        }


        private string connectionString = "Data Source=Menu.db;Version=3";


        private void LoadFormData()
        {
            string query = "SELECT itemName, Price FROM Items WHERE Category = 'Desi'";
            GetData(query, lstDesi, lstDesiPrice);
            query = "SELECT itemName, Price FROM Items WHERE Category = 'Fast Food'";
            GetData(query, lstfastfood, lstfastprice);
            query = "SELECT itemName, Price FROM Items WHERE Category = 'Continental'";
            GetData(query, lstContinental, lstContPrice);
            query = "SELECT itemName, Price FROM Items WHERE Category = 'Dessert'";
            GetData(query, lstDessert, lstdessertprice);
            query = "SELECT itemName, Price FROM Items WHERE Category = 'Juices'";
            GetData(query, lstJuices, lstjuicesprice);
        }
        private void GetData(string query, ListBox lst, ListBox price)
        {

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            
                            lst.Items.Clear();
                            price.Items.Clear();

                            
                            while (reader.Read())
                            {
                                if (reader.HasRows)
                                {
                                    string itemName = reader["itemName"].ToString();
                                    string itemPrice = reader["Price"].ToString();
                                    lst.Items.Add(itemName);
                                    price.Items.Add(itemPrice);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

          
        }

     

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Brugers_Click(object sender, EventArgs e)
        {

        }

        private void lstfastfood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
