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
    public partial class frmInv : Form
    {
        public frmInv()
        {
            InitializeComponent();
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

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
