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
    public partial class ImageCSuggestion : Form
    {
        public ImageCSuggestion()
        {
            InitializeComponent();
            hideAll();
        }


        private void hideAll()
        {
            nameheading.Visible = false;
            nametext.Visible = false;
            originheading.Visible = false;
            origintext.Visible = false;
            courseheading.Visible = false;
            coursetext.Visible = false;
            cookheading.Visible = false;
            cooktext.Visible = false;
            prepheading.Visible = false;
            preptext.Visible = false;
            ingredientsheading.Visible = false;
            ingredientstext.Visible = false;

            trends.Visible = false;

            peopleheading.Visible = false;
            peopletext.Visible = false;
            demandheading.Visible = false;
            demandtext.Visible = false;
            profitheading.Visible = false;
            profittext.Visible = false;

            notfound.Visible = false;

        }

        private void showContent()
        {
            nameheading.Visible = true;
            nametext.Visible = true;
            originheading.Visible = true;
            origintext.Visible = true;
            courseheading.Visible = true;
            coursetext.Visible = true;
            cookheading.Visible = true;
            cooktext.Visible = true;
            prepheading.Visible = true;
            preptext.Visible = true;
            ingredientsheading.Visible = true;
            ingredientstext.Visible = true;

            trends.Visible = true;

            peopleheading.Visible = true;
            peopletext.Visible = true;
            demandheading.Visible = true;
            demandtext.Visible = true;
            profitheading.Visible = true;
            profittext.Visible = true;
        }





        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmCS frmFb = new frmCS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //open and select
        }
    }
}
