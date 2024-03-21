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
    public partial class Status_tbl : Form
    {
        public Status_tbl()
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

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
