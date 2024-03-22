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
    public partial class frmInv : Form
    {
        private string ConnectionString = "Data Source=inventory.db;Version=3;";

        public frmInv()
        {
            InitializeComponent();
            show();
        }


        private void show()
        {
            try
            {
                int totalSuppliers = 0;
                int totalItems = 0;

                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    string supplierQuery = "SELECT COUNT(*) FROM suppliers";
                    SQLiteCommand supplierCmd = new SQLiteCommand(supplierQuery, con);
                    totalSuppliers = Convert.ToInt32(supplierCmd.ExecuteScalar());

                    string itemQuery = "SELECT COUNT(*) FROM items";
                    SQLiteCommand itemCmd = new SQLiteCommand(itemQuery, con);
                    totalItems = Convert.ToInt32(itemCmd.ExecuteScalar());
                }
                
                totalsupplier.Text = totalSuppliers.ToString();
                totalitem.Text = totalItems.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmInv_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Inv_item frmFb = new Inv_item() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SupplierInv frmFb = new SupplierInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            INV_Analysis frmFb = new INV_Analysis() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            LowStockInv frmFb = new LowStockInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }
    }
}
