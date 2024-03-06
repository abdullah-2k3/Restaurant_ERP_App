using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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

            frmLogin login = new frmLogin();
            login.ShowDialog();

            lblTitle2.Text = "Home";
            this.PnlFormLoader.Controls.Clear();
            frmHome frmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHome_Vrb);
            frmHome_Vrb.Show();


        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {
           
        }

 


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAbout_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "About Developers";
            this.PnlFormLoader.Controls.Clear();
            frmAbout frmAbout_Vrb = new frmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAbout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmAbout_Vrb);
            frmAbout_Vrb.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmHome frmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHome_Vrb);
            frmHome_Vrb.Show();
        }

        private void buttonCRM_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Customer Resource Management";
            this.PnlFormLoader.Controls.Clear();
            frmCRM frmCRM_Vrb = new frmCRM() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCRM_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmCRM_Vrb);
            frmCRM_Vrb.Show();
        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Menu";
            this.PnlFormLoader.Controls.Clear();
            frmMenu frmMenu_Vrb = new frmMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMenu_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmMenu_Vrb);
            frmMenu_Vrb.Show();
        }

        private void buttonOrders_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Orders";
            this.PnlFormLoader.Controls.Clear();
            frmOrders frmOrders_Vrb = new frmOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmOrders_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmOrders_Vrb);
            frmOrders_Vrb.Show();
        }

        private void buttonTables_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Tables";
            this.PnlFormLoader.Controls.Clear();
            frmTables frmTables_Vrb = new frmTables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTables_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmTables_Vrb);
            frmTables_Vrb.Show();
        }

        private void buttonInv_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Inventory";
            this.PnlFormLoader.Controls.Clear();
            frmInv frmInv_Vrb = new frmInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInv_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmInv_Vrb);
            frmInv_Vrb.Show();
        }

        private void buttonCS_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Cuisine Suggestions";
            this.PnlFormLoader.Controls.Clear();
            frmCS frmCS_Vrb = new frmCS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCS_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmCS_Vrb);
            frmCS_Vrb.Show();
        }

        private void buttonFR_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Financial Records";
            this.PnlFormLoader.Controls.Clear();
            frmFR frmFR_Vrb = new frmFR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFR_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmFR_Vrb);
            frmFR_Vrb.Show();
        }

        private void buttonHR_Click_1(object sender, EventArgs e)
        {
            lblTitle2.Text = "Human Resource";
            this.PnlFormLoader.Controls.Clear();
            frmHR frmHR_Vrb = new frmHR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHR_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHR_Vrb);
            frmHR_Vrb.Show();
        }
    }
}
