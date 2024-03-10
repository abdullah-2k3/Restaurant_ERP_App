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
    public partial class DeleteTransaction : Form
    {
        public DeleteTransaction()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Deleted Successfully");
            this.Close();
        }
    }
}
