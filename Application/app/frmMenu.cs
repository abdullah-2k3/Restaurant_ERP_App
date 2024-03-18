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
    public partial class frmMenu : Form
    {
        private frmViewMenu view = new frmViewMenu();
        private frmEditMenu edit = new frmEditMenu();
        public frmMenu()
        {
            InitializeComponent();
        }

        public void LoadForm(Form form)
        {

            this.Controls.Clear();

            Form newForm = (Form)Activator.CreateInstance(form.GetType());

            newForm.Dock = DockStyle.Fill;
            newForm.TopLevel = false;
            newForm.TopMost = true;
            newForm.FormBorderStyle = FormBorderStyle.None;

            this.Controls.Add(newForm);

            newForm.Show();
        }




        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            LoadForm(view);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadForm(edit);
        }
    }
}
