namespace app
{
    partial class frmCRM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRM));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.customerFlowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PnlChart = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnVisits = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFeedback = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLoyalty = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCustomers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.customerFlowChart)).BeginInit();
            this.PnlChart.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // customerFlowChart
            // 
            this.customerFlowChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.customerFlowChart.BorderlineColor = System.Drawing.Color.DarkRed;
            chartArea1.Name = "ChartArea1";
            this.customerFlowChart.ChartAreas.Add(chartArea1);
            this.customerFlowChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.customerFlowChart.Legends.Add(legend1);
            this.customerFlowChart.Location = new System.Drawing.Point(0, 0);
            this.customerFlowChart.Name = "customerFlowChart";
            this.customerFlowChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.customerFlowChart.Series.Add(series1);
            this.customerFlowChart.Size = new System.Drawing.Size(648, 363);
            this.customerFlowChart.TabIndex = 8;
            this.customerFlowChart.Text = "CustomerFlow";
            // 
            // PnlChart
            // 
            this.PnlChart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlChart.Controls.Add(this.customerFlowChart);
            this.PnlChart.Location = new System.Drawing.Point(798, 445);
            this.PnlChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlChart.Name = "PnlChart";
            this.PnlChart.Size = new System.Drawing.Size(652, 367);
            this.PnlChart.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(1268, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 163);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(864, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 163);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProgress.Location = new System.Drawing.Point(154, 782);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(235, 28);
            this.lblProgress.TabIndex = 18;
            this.lblProgress.Text = "Membership Customers";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(75, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 163);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(453, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 163);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(262, 163);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // btnVisits
            // 
            this.btnVisits.AllowAnimations = true;
            this.btnVisits.AllowMouseEffects = true;
            this.btnVisits.AllowToggling = false;
            this.btnVisits.AnimationSpeed = 200;
            this.btnVisits.AutoGenerateColors = false;
            this.btnVisits.AutoRoundBorders = false;
            this.btnVisits.AutoSizeLeftIcon = true;
            this.btnVisits.AutoSizeRightIcon = true;
            this.btnVisits.BackColor = System.Drawing.Color.Transparent;
            this.btnVisits.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnVisits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisits.BackgroundImage")));
            this.btnVisits.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVisits.ButtonText = "Visits";
            this.btnVisits.ButtonTextMarginLeft = 0;
            this.btnVisits.ColorContrastOnClick = 45;
            this.btnVisits.ColorContrastOnHover = 45;
            this.btnVisits.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnVisits.CustomizableEdges = borderEdges1;
            this.btnVisits.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVisits.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVisits.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVisits.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVisits.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisits.ForeColor = System.Drawing.Color.White;
            this.btnVisits.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisits.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnVisits.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnVisits.IconMarginLeft = 11;
            this.btnVisits.IconPadding = 10;
            this.btnVisits.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisits.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnVisits.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnVisits.IconSize = 25;
            this.btnVisits.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnVisits.IdleBorderRadius = 25;
            this.btnVisits.IdleBorderThickness = 1;
            this.btnVisits.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnVisits.IdleIconLeftImage = null;
            this.btnVisits.IdleIconRightImage = null;
            this.btnVisits.IndicateFocus = false;
            this.btnVisits.Location = new System.Drawing.Point(476, 298);
            this.btnVisits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVisits.OnDisabledState.BorderRadius = 25;
            this.btnVisits.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVisits.OnDisabledState.BorderThickness = 1;
            this.btnVisits.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVisits.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVisits.OnDisabledState.IconLeftImage = null;
            this.btnVisits.OnDisabledState.IconRightImage = null;
            this.btnVisits.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnVisits.onHoverState.BorderRadius = 25;
            this.btnVisits.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVisits.onHoverState.BorderThickness = 1;
            this.btnVisits.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnVisits.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnVisits.onHoverState.IconLeftImage = null;
            this.btnVisits.onHoverState.IconRightImage = null;
            this.btnVisits.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVisits.OnIdleState.BorderRadius = 25;
            this.btnVisits.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVisits.OnIdleState.BorderThickness = 1;
            this.btnVisits.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnVisits.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnVisits.OnIdleState.IconLeftImage = null;
            this.btnVisits.OnIdleState.IconRightImage = null;
            this.btnVisits.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnVisits.OnPressedState.BorderRadius = 25;
            this.btnVisits.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVisits.OnPressedState.BorderThickness = 1;
            this.btnVisits.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnVisits.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnVisits.OnPressedState.IconLeftImage = null;
            this.btnVisits.OnPressedState.IconRightImage = null;
            this.btnVisits.Size = new System.Drawing.Size(225, 60);
            this.btnVisits.TabIndex = 37;
            this.btnVisits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVisits.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVisits.TextMarginLeft = 0;
            this.btnVisits.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnVisits.UseDefaultRadiusAndThickness = true;
            this.btnVisits.Click += new System.EventHandler(this.btnVisits_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.AllowAnimations = true;
            this.btnFeedback.AllowMouseEffects = true;
            this.btnFeedback.AllowToggling = false;
            this.btnFeedback.AnimationSpeed = 200;
            this.btnFeedback.AutoGenerateColors = false;
            this.btnFeedback.AutoRoundBorders = false;
            this.btnFeedback.AutoSizeLeftIcon = true;
            this.btnFeedback.AutoSizeRightIcon = true;
            this.btnFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedback.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFeedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFeedback.BackgroundImage")));
            this.btnFeedback.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFeedback.ButtonText = "Feedback";
            this.btnFeedback.ButtonTextMarginLeft = 0;
            this.btnFeedback.ColorContrastOnClick = 45;
            this.btnFeedback.ColorContrastOnHover = 45;
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnFeedback.CustomizableEdges = borderEdges2;
            this.btnFeedback.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFeedback.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFeedback.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFeedback.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFeedback.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFeedback.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFeedback.IconMarginLeft = 11;
            this.btnFeedback.IconPadding = 10;
            this.btnFeedback.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFeedback.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFeedback.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFeedback.IconSize = 25;
            this.btnFeedback.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnFeedback.IdleBorderRadius = 25;
            this.btnFeedback.IdleBorderThickness = 1;
            this.btnFeedback.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFeedback.IdleIconLeftImage = null;
            this.btnFeedback.IdleIconRightImage = null;
            this.btnFeedback.IndicateFocus = false;
            this.btnFeedback.Location = new System.Drawing.Point(878, 298);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFeedback.OnDisabledState.BorderRadius = 25;
            this.btnFeedback.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFeedback.OnDisabledState.BorderThickness = 1;
            this.btnFeedback.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFeedback.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFeedback.OnDisabledState.IconLeftImage = null;
            this.btnFeedback.OnDisabledState.IconRightImage = null;
            this.btnFeedback.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFeedback.onHoverState.BorderRadius = 25;
            this.btnFeedback.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFeedback.onHoverState.BorderThickness = 1;
            this.btnFeedback.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFeedback.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.onHoverState.IconLeftImage = null;
            this.btnFeedback.onHoverState.IconRightImage = null;
            this.btnFeedback.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFeedback.OnIdleState.BorderRadius = 25;
            this.btnFeedback.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFeedback.OnIdleState.BorderThickness = 1;
            this.btnFeedback.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFeedback.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.OnIdleState.IconLeftImage = null;
            this.btnFeedback.OnIdleState.IconRightImage = null;
            this.btnFeedback.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFeedback.OnPressedState.BorderRadius = 25;
            this.btnFeedback.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFeedback.OnPressedState.BorderThickness = 1;
            this.btnFeedback.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFeedback.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.OnPressedState.IconLeftImage = null;
            this.btnFeedback.OnPressedState.IconRightImage = null;
            this.btnFeedback.Size = new System.Drawing.Size(225, 60);
            this.btnFeedback.TabIndex = 36;
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFeedback.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFeedback.TextMarginLeft = 0;
            this.btnFeedback.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFeedback.UseDefaultRadiusAndThickness = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnLoyalty
            // 
            this.btnLoyalty.AllowAnimations = true;
            this.btnLoyalty.AllowMouseEffects = true;
            this.btnLoyalty.AllowToggling = false;
            this.btnLoyalty.AnimationSpeed = 200;
            this.btnLoyalty.AutoGenerateColors = false;
            this.btnLoyalty.AutoRoundBorders = false;
            this.btnLoyalty.AutoSizeLeftIcon = true;
            this.btnLoyalty.AutoSizeRightIcon = true;
            this.btnLoyalty.BackColor = System.Drawing.Color.Transparent;
            this.btnLoyalty.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLoyalty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoyalty.BackgroundImage")));
            this.btnLoyalty.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoyalty.ButtonText = "Loyalty";
            this.btnLoyalty.ButtonTextMarginLeft = 0;
            this.btnLoyalty.ColorContrastOnClick = 45;
            this.btnLoyalty.ColorContrastOnHover = 45;
            this.btnLoyalty.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnLoyalty.CustomizableEdges = borderEdges3;
            this.btnLoyalty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoyalty.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoyalty.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoyalty.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoyalty.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLoyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoyalty.ForeColor = System.Drawing.Color.White;
            this.btnLoyalty.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoyalty.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoyalty.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLoyalty.IconMarginLeft = 11;
            this.btnLoyalty.IconPadding = 10;
            this.btnLoyalty.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoyalty.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoyalty.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLoyalty.IconSize = 25;
            this.btnLoyalty.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnLoyalty.IdleBorderRadius = 25;
            this.btnLoyalty.IdleBorderThickness = 1;
            this.btnLoyalty.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLoyalty.IdleIconLeftImage = null;
            this.btnLoyalty.IdleIconRightImage = null;
            this.btnLoyalty.IndicateFocus = false;
            this.btnLoyalty.Location = new System.Drawing.Point(1282, 298);
            this.btnLoyalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoyalty.Name = "btnLoyalty";
            this.btnLoyalty.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoyalty.OnDisabledState.BorderRadius = 25;
            this.btnLoyalty.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoyalty.OnDisabledState.BorderThickness = 1;
            this.btnLoyalty.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoyalty.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoyalty.OnDisabledState.IconLeftImage = null;
            this.btnLoyalty.OnDisabledState.IconRightImage = null;
            this.btnLoyalty.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLoyalty.onHoverState.BorderRadius = 25;
            this.btnLoyalty.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoyalty.onHoverState.BorderThickness = 1;
            this.btnLoyalty.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLoyalty.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLoyalty.onHoverState.IconLeftImage = null;
            this.btnLoyalty.onHoverState.IconRightImage = null;
            this.btnLoyalty.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoyalty.OnIdleState.BorderRadius = 25;
            this.btnLoyalty.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoyalty.OnIdleState.BorderThickness = 1;
            this.btnLoyalty.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLoyalty.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLoyalty.OnIdleState.IconLeftImage = null;
            this.btnLoyalty.OnIdleState.IconRightImage = null;
            this.btnLoyalty.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnLoyalty.OnPressedState.BorderRadius = 25;
            this.btnLoyalty.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoyalty.OnPressedState.BorderThickness = 1;
            this.btnLoyalty.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnLoyalty.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLoyalty.OnPressedState.IconLeftImage = null;
            this.btnLoyalty.OnPressedState.IconRightImage = null;
            this.btnLoyalty.Size = new System.Drawing.Size(225, 60);
            this.btnLoyalty.TabIndex = 35;
            this.btnLoyalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoyalty.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLoyalty.TextMarginLeft = 0;
            this.btnLoyalty.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLoyalty.UseDefaultRadiusAndThickness = true;
            this.btnLoyalty.Click += new System.EventHandler(this.btnLoyalty_Click_1);
            // 
            // btnCustomers
            // 
            this.btnCustomers.AllowAnimations = true;
            this.btnCustomers.AllowMouseEffects = true;
            this.btnCustomers.AllowToggling = false;
            this.btnCustomers.AnimationSpeed = 200;
            this.btnCustomers.AutoGenerateColors = false;
            this.btnCustomers.AutoRoundBorders = false;
            this.btnCustomers.AutoSizeLeftIcon = true;
            this.btnCustomers.AutoSizeRightIcon = true;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.BackgroundImage")));
            this.btnCustomers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.ButtonText = "Customers";
            this.btnCustomers.ButtonTextMarginLeft = 0;
            this.btnCustomers.ColorContrastOnClick = 45;
            this.btnCustomers.ColorContrastOnHover = 45;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnCustomers.CustomizableEdges = borderEdges4;
            this.btnCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCustomers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomers.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCustomers.IconMarginLeft = 11;
            this.btnCustomers.IconPadding = 10;
            this.btnCustomers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCustomers.IconSize = 25;
            this.btnCustomers.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnCustomers.IdleBorderRadius = 25;
            this.btnCustomers.IdleBorderThickness = 1;
            this.btnCustomers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCustomers.IdleIconLeftImage = null;
            this.btnCustomers.IdleIconRightImage = null;
            this.btnCustomers.IndicateFocus = false;
            this.btnCustomers.Location = new System.Drawing.Point(94, 298);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomers.OnDisabledState.BorderRadius = 25;
            this.btnCustomers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.OnDisabledState.BorderThickness = 1;
            this.btnCustomers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCustomers.OnDisabledState.IconLeftImage = null;
            this.btnCustomers.OnDisabledState.IconRightImage = null;
            this.btnCustomers.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCustomers.onHoverState.BorderRadius = 25;
            this.btnCustomers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.onHoverState.BorderThickness = 1;
            this.btnCustomers.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCustomers.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.onHoverState.IconLeftImage = null;
            this.btnCustomers.onHoverState.IconRightImage = null;
            this.btnCustomers.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCustomers.OnIdleState.BorderRadius = 25;
            this.btnCustomers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.OnIdleState.BorderThickness = 1;
            this.btnCustomers.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCustomers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.OnIdleState.IconLeftImage = null;
            this.btnCustomers.OnIdleState.IconRightImage = null;
            this.btnCustomers.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCustomers.OnPressedState.BorderRadius = 25;
            this.btnCustomers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.OnPressedState.BorderThickness = 1;
            this.btnCustomers.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCustomers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.OnPressedState.IconLeftImage = null;
            this.btnCustomers.OnPressedState.IconRightImage = null;
            this.btnCustomers.Size = new System.Drawing.Size(225, 60);
            this.btnCustomers.TabIndex = 34;
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCustomers.TextMarginLeft = 0;
            this.btnCustomers.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCustomers.UseDefaultRadiusAndThickness = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.MintCream;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(160, 445);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(370, 315);
            this.chart.TabIndex = 38;
            this.chart.Text = "chart";
            // 
            // frmCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1622, 842);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVisits);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnLoyalty);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.PnlChart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCRM";
            ((System.ComponentModel.ISupportInitialize)(this.customerFlowChart)).EndInit();
            this.PnlChart.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart customerFlowChart;
        private System.Windows.Forms.Panel PnlChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCustomers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFeedback;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLoyalty;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnVisits;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}