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
    public partial class Reservation_tbl : Form
    {
        public Reservation_tbl()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmTables frmFb = new frmTables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservation added.");
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservation Updated.");
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservation deleted.");
        }
    }
}
