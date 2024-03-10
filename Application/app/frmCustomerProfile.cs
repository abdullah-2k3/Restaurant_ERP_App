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
    public partial class frmCustomerProfile : Form
    {

        private frmAddCustomer frmAddCus = new frmAddCustomer();
        private frmDelCustomer frmDelCus = new frmDelCustomer();

        private string ConnectionString = "Data Source=Customer.db;Version=3;";

        public frmCustomerProfile()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            //InitializeCustomers();
            showCustomers();
        }

        private void InitializeCustomers()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string[] names = {
            "Ali", "Ahmed", "Ameer", "Ahsan", "Usman",
            "Bilal", "Hassan", "Farhan", "Saad", "Imran"
            };


            string[] gender = {
            "Male", "Male", "Male", "Male", "Male",
            "Male", "Male", "Male", "Male", "Male"
            };


            string[] city= {
            "Lahore", "Karachi", "Islamabad", "Multan", "LahoreUsman",
            "Sahiwal", "Lahore", "Lahore", "Multan", "Faisalabad"
            };

            string[] contact = { "0321001112", "0321300312", "03210120443", "032434212"};

            string[] email = { "email1", "email2", "email3", "email4" };


            for (int i = 0; i < names.Length; i++)
            {
                string query = "INSERT INTO CustomerProfTbl(Id, Name, Gender, City, Contact, Email)VALUES ('"+(i+1)+"', '" + names[i] + "' , '" + gender[i] + "', '" + city[i] + "', '" + contact[i % 4] + "', '" + email[i % 4] + "')";

                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {

                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    break;
                }
            }


            con.Close();
        }



        private void showCustomers()
        {    

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from CustomerProfTbl";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }



        private void btnAddCustomer_Click(object sender, EventArgs e)
        { 
            frmAddCus.ShowDialog();
            showCustomers() ;
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            frmDelCus.ShowDialog();
            showCustomers() ;   
        }

        private void frmCustomerProfile_Load(object sender, EventArgs e)
        {

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

                // Draw the cell's text
                e.PaintContent(e.ClipBounds);

                e.Handled = true;
            }
        }



    }
}
