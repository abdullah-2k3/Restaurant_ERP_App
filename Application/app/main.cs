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
            Load_FORMS(new frmHome());
            currentWindow = 0;
        }    

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (currentWindow != 0)
                Load_FORMS(new frmHome());
            currentWindow = 0;
        }

        private void Load_FORMS(object form)
        {
            if (this.bunifuPanel2.Controls.Count > 0)
                this.bunifuPanel2.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.bunifuPanel2.Controls.Add(fh);
            this.bunifuPanel2.Tag = fh;
            fh.Show();
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
            if (currentWindow != 9)
                Load_FORMS(new frmAbout());
            currentWindow = 9;
        }

        private void bunifuPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void bunifuPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        int currentWindow;
    
        
        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {

            if(currentWindow != 1)
               Load_FORMS(new frmCRM());
            currentWindow = 1;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (currentWindow != 2)
                Load_FORMS(new frmMenu());
            currentWindow = 2;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (currentWindow != 3)
                Load_FORMS(new frmMenu());
            currentWindow = 3;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            if (currentWindow != 4)
                Load_FORMS(new frmTables());
            currentWindow = 4;
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            if (currentWindow != 5)
                Load_FORMS(new frmInv());
            currentWindow = 5;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            if (currentWindow != 6)
                Load_FORMS(new frmCS());
            currentWindow = 6;
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            if (currentWindow != 7)
                Load_FORMS(new frmFR());
            currentWindow = 7;
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            if (currentWindow != 8)
                Load_FORMS(new frmHR());
            currentWindow = 8;
        }
    }
}
