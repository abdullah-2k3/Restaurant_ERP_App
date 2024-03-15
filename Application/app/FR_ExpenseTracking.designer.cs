namespace app
{
    partial class FR_ExpenseTracking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_ExpenseTracking));
            this.label1 = new System.Windows.Forms.Label();
            this.monthly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.areavsmoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.monthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areavsmoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(373, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Tracking";
            // 
            // monthly
            // 
            chartArea3.Name = "ChartArea1";
            this.monthly.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.monthly.Legends.Add(legend3);
            this.monthly.Location = new System.Drawing.Point(544, 178);
            this.monthly.Name = "monthly";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.monthly.Series.Add(series3);
            this.monthly.Size = new System.Drawing.Size(398, 240);
            this.monthly.TabIndex = 1;
            this.monthly.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(593, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Trend in Expense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Slab Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(92, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "area of spenditure vs money";
            // 
            // areavsmoney
            // 
            this.areavsmoney.BorderlineColor = System.Drawing.Color.Black;
            this.areavsmoney.BorderlineWidth = 3;
            chartArea4.Name = "ChartArea1";
            this.areavsmoney.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.areavsmoney.Legends.Add(legend4);
            this.areavsmoney.Location = new System.Drawing.Point(74, 178);
            this.areavsmoney.Name = "areavsmoney";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.areavsmoney.Series.Add(series4);
            this.areavsmoney.Size = new System.Drawing.Size(387, 240);
            this.areavsmoney.TabIndex = 4;
            this.areavsmoney.Text = "chart2";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 20;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(1, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 11;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // FR_ExpenseTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1058, 463);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.areavsmoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthly);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_ExpenseTracking";
            this.Text = "FR_ExpenseTracking";
            this.Load += new System.EventHandler(this.FR_ExpenseTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areavsmoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart areavsmoney;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}