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
    public partial class frmFeedback : Form
    {
        private string ConnectionString = "Data Source=Customer.db;Version=3;";

        private frmAddFeedback frmAddFb = new frmAddFeedback();
        private frmDelFeedback frmDelFb = new frmDelFeedback();

        public frmFeedback()
        {
            InitializeComponent();
            dataGridView2.CellPainting += dataGridView2_CellPainting;
            showFeedback();
        }

        private void showFeedback()
        {

            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select * from FeedbackTbl";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView2.DataSource = table;

            con.Close();
        }

        private void btnAddFeedback_Click(object sender, EventArgs e)
        {
            frmAddFb.ShowDialog();
            showFeedback();
        }


        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {

                using (Brush backColorBrush = new SolidBrush(Color.LightBlue))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                // Set the font of the header cell to bold
                e.CellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);

                // Draw the cell's text
                e.PaintContent(e.ClipBounds);

                e.Handled = true;
            }
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            frmDelFb.ShowDialog();
            showFeedback();
        }
    }
}
