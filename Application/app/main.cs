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

        private frmHome home = new frmHome();
        private frmCRM crm = new frmCRM();  
        private frmMenu menu = new frmMenu();
        private frmOrders orders = new frmOrders(); 
        private frmTables tables = new frmTables();
        private frmCS cs = new frmCS();
        private frmInv inv = new frmInv();
        private frmFR fr = new frmFR();
        private frmHR hr = new frmHR();
        private frmAbout about = new frmAbout();
        public main() 
        {

            frmLogin login = new frmLogin();
            login.ShowDialog();
            
            InitializeComponent();

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
            LoadForm(about, "About Developers");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            LoadForm(home, "Home");
        }



        private void buttonCRM_Click_1(object sender, EventArgs e)
        {
            LoadForm(crm, "Customer Response Management");

        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {
            LoadForm(menu, "Menu");
        }

        private void buttonOrders_Click_1(object sender, EventArgs e)
        {
            LoadForm(orders, "Orders");
        }

        private void buttonTables_Click_1(object sender, EventArgs e)
        {
            LoadForm(tables, "Tables");
        }

        private void buttonInv_Click_1(object sender, EventArgs e)
        {
            LoadForm(inv, "Inventory");
        }

        private void buttonCS_Click_1(object sender, EventArgs e)
        {
            LoadForm(cs, "Cuisine Suggestions");
        }

        private void buttonFR_Click_1(object sender, EventArgs e)
        {
            LoadForm(fr, "Financial Records");
        }

        private void buttonHR_Click_1(object sender, EventArgs e)
        {
            LoadForm(hr, "Human Resource");
        }

        private void PnlFormLoader_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            main frm = new main();
            frm.Show();
        }
    }
}
