using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Table_tbl : Form
    {
        public Table_tbl()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmTables frmFb = new frmTables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Table added.");
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Table deleted.");
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Table updated.");
        }
    }
}
