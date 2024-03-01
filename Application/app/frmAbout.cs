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

            srcCode.Click += new EventHandler(srcCode_Click);

            //srcCode.Location = new System.Drawing.Point(50, 50); // Adjust the X and Y coordinates as needed

            this.Controls.Add(srcCode);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }

        private void srcCode_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ahmddbilall/Resturent_ERP_Csharp");
        }
    }
}
