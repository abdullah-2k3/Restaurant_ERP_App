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
    public partial class SupplierInv : Form
    {
        public SupplierInv()
        {
            InitializeComponent();
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
            MessageBox.Show("Supplier added.");
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supplier updated.");

        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supplier deleted.");

        }
    }
}
