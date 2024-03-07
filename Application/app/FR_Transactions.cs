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
    public partial class FR_Transactions : Form
    {
        public FR_Transactions()
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
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UpdateTransaction updateTransaction = new UpdateTransaction();
            updateTransaction.ShowDialog();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteTransaction deleteTransaction = new DeleteTransaction();
            deleteTransaction.ShowDialog();
        }
    }
}
