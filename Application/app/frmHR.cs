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
using System.Windows.Forms.DataVisualization.Charting;

namespace app
{
    public partial class frmHR : Form
    {

        private string ConnectionString = "Data Source=HR.db;Version=3;";

        public frmHR()
        {
            InitializeComponent();
            InitializeChart();

            lblEmployeeCount.Text = getEmployees().ToString();
        }


        private void InitializeChart()
        {
            customerFlowChart.Series.Clear();
            customerFlowChart.Titles.Clear();

            Title title = new Title("Department Employees");
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            customerFlowChart.Titles.Add(title);

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            // Add data points with custom colors
            series.Points.AddXY("Sales", 20);
            series.Points[0].Color = Color.Red;   // Customize color for the first sector
            series.Points[0].BorderColor = Color.Black; // Set border color for the first sector
            series.Points[0].BorderWidth = 1; // Set border width for the first sector
            series.Points.AddXY("Kitchen", 25);
            series.Points[1].Color = Color.Aqua;  // Customize color for the second sector
            series.Points[1].BorderColor = Color.Black; // Set border color for the second sector
            series.Points[1].BorderWidth = 1; // Set border width for the second sector
            series.Points.AddXY("Servings", 30);
            series.Points[2].Color = Color.Green; // Customize color for the third sector
            series.Points[2].BorderColor = Color.Black; // Set border color for the third sector
            series.Points[2].BorderWidth = 1; // Set border width for the third sector
            series.Points.AddXY("Rep", 15);
            series.Points[3].Color = Color.Yellow;// Customize color for the fourth sector
            series.Points[3].BorderColor = Color.Black; // Set border color for the fourth sector
            series.Points[3].BorderWidth = 1; // Set border width for the fourth sector
            series.Points.AddXY("Delivery", 10);
            series.Points[4].Color = Color.Orange;// Customize color for the fifth sector
            series.Points[4].BorderColor = Color.Black; // Set border color for the fifth sector
            series.Points[4].BorderWidth = 1; // Set border width for the fifth sector

            customerFlowChart.Series.Add(series);

            customerFlowChart.ChartAreas[0].AxisX.Title = "Days";
            customerFlowChart.ChartAreas[0].AxisY.Title = "Average Customers";
            customerFlowChart.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            customerFlowChart.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold);

            customerFlowChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            customerFlowChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            customerFlowChart.Legends[0].Enabled = false;
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

       
        private void btnPerformance_Click(object sender, EventArgs e)
        {
            LoadForm(new HR_Performance());
        }

        private void btnTiimecards_Click(object sender, EventArgs e)
        {
            LoadForm(new HR_Timecards());
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            LoadForm(new HR_PayJournal());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            LoadForm(new HR_Attendance());
        }

        private void btnRecruitment_Click(object sender, EventArgs e)
        {
            LoadForm(new HR_Recruitment());
        }

        private int getEmployees()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();

            string Query = "select Count(*) from Attendance";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            return count;
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            LoadForm(new HR_Employees());
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            if (tbManager.Text != "")
            {
                lblManagerName.Text = tbManager.Text;
                MessageBox.Show("Manager Changed");
            }
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            if (tbEvent.Text != "")
            {
                lblEvent.Text = tbEvent.Text;
                MessageBox.Show("Event Added");
            }
        }

        private void frmHR_Load(object sender, EventArgs e)
        {

        }
    }
}
