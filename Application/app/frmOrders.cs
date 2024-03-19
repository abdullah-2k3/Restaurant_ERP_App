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
    public partial class frmOrders : Form
    {

        private frmAddOrder add = new frmAddOrder();
        private frmOrdersActive active = new frmOrdersActive();
        private frmOrdersCompleted completed = new frmOrdersCompleted();
        public frmOrders()
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            LoadForm(add);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            LoadForm(active);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            LoadForm(completed);
        }
    }
}
