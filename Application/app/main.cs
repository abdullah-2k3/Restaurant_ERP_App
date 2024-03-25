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

        private string current;
        private string Previous;
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

            current = "Home";
            Previous = "Home";

            changeColor();

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
            Previous = current;
            current = "About";
            changeColor();
            buttonAbout.BackColor1 = Color.Red;
            buttonAbout.Invalidate();
        }



        private void changeColor()
        {
            string previousButtonName = "button" + Previous;

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { changeColor(); }));
                return;
            }

            Bunifu.UI.WinForms.BunifuButton.BunifuButton previousButton = FindButtonByName<Bunifu.UI.WinForms.BunifuButton.BunifuButton>(previousButtonName, this);

            if (previousButton != null )
            {
                previousButton.IdleFillColor = Color.Transparent;
                previousButton.Invalidate();
                
            }
            else
            {
                MessageBox.Show("Button not found.");
            }
        }

        private T FindButtonByName<T>(string buttonName, Control parent) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T && control.Name.Equals(buttonName))
                {
                    return (T)control;
                }
                else if (control.HasChildren)
                {
                    T button = FindButtonByName<T>(buttonName, control);
                    if (button != null)
                    {
                        return button;
                    }
                }
            }
            return null;
        }






        private void buttonHome_Click(object sender, EventArgs e)
        {
            LoadForm(home, "Home");
            Previous = current;
            current = "Home";
            buttonHome.BackColor1 = Color.Red;

            changeColor();
        }



        private void buttonCRM_Click_1(object sender, EventArgs e)
        {
            LoadForm(crm, "Customer Response Management");
            Previous = current;
            current = "CRM";
            buttonCRM.BackColor1 = Color.Red;
            buttonCRM.Invalidate();
            changeColor();
        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {
            LoadForm(menu, "Menu");
            Previous = current;
            current = "Menu";
            buttonMenu.BackColor1 = Color.Red;
            buttonMenu.Invalidate();
            changeColor();
        }

        private void buttonOrders_Click_1(object sender, EventArgs e)
        {
            LoadForm(orders, "Orders");
            Previous = current;
            current = "Orders";
            buttonOrders.BackColor1 = Color.Red;
            buttonOrders.Invalidate();
            changeColor();
        }

        private void buttonTables_Click_1(object sender, EventArgs e)
        {
            LoadForm(tables, "Tables");
            Previous = current;
            current = "Tables";
            buttonTables.BackColor1 = Color.Red;
            buttonTables.Invalidate();
            changeColor();
        }

        private void buttonInv_Click_1(object sender, EventArgs e)
        {
            LoadForm(inv, "Inventory");
            Previous = current;
            current = "Inv";
            buttonInv.BackColor1 = Color.Red;
            buttonInv.Invalidate();
            changeColor();
        }

        private void buttonCS_Click_1(object sender, EventArgs e)
        {
            LoadForm(cs, "Cuisine Suggestions");
            Previous = current;
            current = "CS";
            buttonCS.BackColor1 = Color.Red;
            buttonCS.Invalidate();
            changeColor();
        }

        private void buttonFR_Click_1(object sender, EventArgs e)
        {
            LoadForm(fr, "Financial Records");
            Previous = current;
            current = "FR";
            buttonFR.BackColor1 = Color.Red;
            buttonFR.Invalidate();
            changeColor();
        }

        private void buttonHR_Click_1(object sender, EventArgs e)
        {
            LoadForm(hr, "Human Resource");
            Previous = current;
            current = "HR";
            buttonHR.BackColor1 = Color.Red;
            buttonHR.Invalidate();
            changeColor();
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
