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
    public partial class Inv_item : Form
    {
        public Inv_item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
           frmInv frmFb = new frmInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item added.");
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item updated.");
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item deleted.");
        }
    }
}
