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

            lblTitle.Text = "Home";
            this.PnlFormLoader.Controls.Clear();
            frmHome frmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHome_Vrb);
            frmHome_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "CRM";
            this.PnlFormLoader.Controls.Clear();
            frmCRM frmCRM_Vrb = new frmCRM() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCRM_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmCRM_Vrb);
            frmCRM_Vrb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "About Us";
            this.PnlFormLoader.Controls.Clear();
            frmAbout frmAbout_Vrb = new frmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAbout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmAbout_Vrb);
            frmAbout_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(44, 44, 44);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Home";
            this.PnlFormLoader.Controls.Clear();
            frmHome frmHome_Vrb = new frmHome() { Dock  = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHome_Vrb);
            frmHome_Vrb.Show();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Menu";
            this.PnlFormLoader.Controls.Clear();
            frmMenu frmMenu_Vrb = new frmMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMenu_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmMenu_Vrb);
            frmMenu_Vrb.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Orders";
            this.PnlFormLoader.Controls.Clear();
            frmOrders frmOrders_Vrb = new frmOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmOrders_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmOrders_Vrb);
            frmOrders_Vrb.Show();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Tables";
            this.PnlFormLoader.Controls.Clear();
            frmTables frmTables_Vrb = new frmTables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTables_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmTables_Vrb);
            frmTables_Vrb.Show();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Inventory";
            this.PnlFormLoader.Controls.Clear();
            frmInv frmInv_Vrb = new frmInv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInv_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmInv_Vrb);
            frmInv_Vrb.Show();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Suggestions";
            this.PnlFormLoader.Controls.Clear();
            frmCS frmCS_Vrb = new frmCS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCS_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmCS_Vrb);
            frmCS_Vrb.Show();
        }

        private void btnFR_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Finance";
            this.PnlFormLoader.Controls.Clear();
            frmFR frmFR_Vrb = new frmFR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFR_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmFR_Vrb);
            frmFR_Vrb.Show();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Human Resource";
            this.PnlFormLoader.Controls.Clear();
            frmHR frmHR_Vrb = new frmHR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHR_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHR_Vrb);
            frmHR_Vrb.Show();
        }
    }
}
