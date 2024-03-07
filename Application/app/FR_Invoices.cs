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
    public partial class FR_Invoices : Form
    {
        public FR_Invoices()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmFR frmFb = new frmFR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddInvoiceForm frmFb = new AddInvoiceForm();
            frmFb.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DeleteInvoice frmFb = new DeleteInvoice();
            frmFb.ShowDialog();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            OpenInvoice frmFb = new OpenInvoice();
            frmFb.ShowDialog();
        }
    }
}
