using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            srcCode.Click += OpenWebsite;
        }

        private void OpenWebsite(object sender, EventArgs e)
        {
            string url = "https://github.com/abdullah-2k3/Restaurant_ERP_App"; 
            Process.Start(url);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }

        private void srcCode_Click(object sender, EventArgs e)
        {
           
        }
    }
}
