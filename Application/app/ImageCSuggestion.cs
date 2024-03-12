using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class ImageCSuggestion : Form
    {
        private string ConnectionString = "Data Source=Cuisine.db;";

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

            Classifybtn.Visible = false;
            picture.Visible = false;

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

            Classifybtn.Visible = false;
            picture.Visible = false;
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
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";
            open.ShowDialog();
            if (open.FileName != "")
            {
                picture.ImageLocation = open.FileName;
                Classifybtn.Visible = true;
                picture.Visible = true;
            }

            

        }



        private void readDataFromDB(string name)
        {

            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                string query = "SELECT * FROM Image_info WHERE name = @Name";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nametext.Text = reader["name"].ToString();
                        ingredientstext.Text = reader["ingredients"].ToString();
                        preptext.Text = reader["prep_time"].ToString();
                        cooktext.Text = reader["cook_time"].ToString();
                        origintext.Text = reader["state"].ToString();
                        coursetext.Text = reader["course"].ToString();
                        peopletext.Text = reader["People_liked"].ToString();
                        demandtext.Text = reader["demand_increase_per_year"].ToString();
                        profittext.Text = reader["Profit_Per-Item"].ToString();
                        showContent();
                    }
                    else
                    {
                        notfound.Visible = true;
                    }
                }

            }

        }



    }
}
