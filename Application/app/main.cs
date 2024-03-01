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
    public partial class main : Form
    {
        public main() 
        {
            InitializeComponent();


        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            // Show the home form
            homeForm.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            frmAbout homeForm = new frmAbout();
            // Show the home form
            homeForm.Show();
        }
    }
}
