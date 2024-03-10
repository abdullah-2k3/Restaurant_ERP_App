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


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LoadForm(Form form, string text)
        {

            lblTitle2.Text = text;
            this.PnlFormLoader.Controls.Clear();
            Form newForm = (Form)Activator.CreateInstance(form.GetType());

            newForm.Dock = DockStyle.Fill;
            newForm.TopLevel = false;
            newForm.TopMost = true;
            newForm.FormBorderStyle = FormBorderStyle.None;

            this.PnlFormLoader.Controls.Add(newForm);

            newForm.Show();
        }


        private void buttonAbout_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmAbout(), "About Developers");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            LoadForm(new frmHome(), "Home");
        }



        private void buttonCRM_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmCRM(), "Customer Response Management");

        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmMenu(), "Menu");
        }

        private void buttonOrders_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmOrders(), "Orders");
        }

        private void buttonTables_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmTables(), "Tables");
        }

        private void buttonInv_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmInv(), "Inventory");
        }

        private void buttonCS_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmCS(), "Cuisine Suggestions");
        }

        private void buttonFR_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmFR(), "Financial Records");
        }

        private void buttonHR_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmHR(), "Human Resource");
        }
    }
}
