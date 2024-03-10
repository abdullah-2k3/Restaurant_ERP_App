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
    public partial class frmCS : Form
    {
        public frmCS()
        {
            InitializeComponent();
        }

        private void frmCS_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SearchCsuggestion frmFb = new SearchCsuggestion() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ImageCSuggestion frmFb = new ImageCSuggestion() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }
    }
}
