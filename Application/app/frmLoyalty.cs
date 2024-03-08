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
    public partial class frmLoyalty : Form
    {

        private string ConnectionString = "Data Source=Customer.db;Version=3;";
        public frmLoyalty()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            showLoyalty();

        }

        private void showLoyalty()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from CustomerLoyaltyTbl";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddLoyalty frmAddLyl = new frmAddLoyalty();
            frmAddLyl.ShowDialog();
            showLoyalty();
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            frmDelLoyalty frmDelLoyalty = new frmDelLoyalty();
            frmDelLoyalty.ShowDialog();
            showLoyalty(); ;
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
