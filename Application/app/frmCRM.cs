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
    public partial class frmCRM : Form
    {

        
        
        private frmLoyalty frmLyl = new frmLoyalty() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public frmCRM()
        {
            InitializeComponent();
        }

        private void customerProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmCustomerProfile frmCus_Vrb = new frmCustomerProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCus_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmCus_Vrb);
            frmCus_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmFeedback frmFb = new frmFeedback() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnLoyalty_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmLoyalty frmLyl = new frmLoyalty() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLyl.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmLyl);
            frmLyl.Show();
        }

    }
}
