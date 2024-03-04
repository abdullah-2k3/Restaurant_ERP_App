using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\abdullah\\Documents\\CustomerDb.mdf;Integrated Security=True;Connect Timeout=30;";
        public frmCustomerProfile()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showCustomers();
        }

        private void showCustomers()
        {    

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "select * from CustomerProfTbl";

            SqlCommand cmd = new SqlCommand(Query, con);

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

        public void ResizeForm(int width, int height)
        {
            this.Size = new Size(width, height);
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
