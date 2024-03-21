namespace app
{
    partial class frmHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHR));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customerFlowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmployeeCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEvent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnManager = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tbManager = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.btnEvent = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEmp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPerformance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTimecards = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAttendance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRecruitments = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPayroll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFlowChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // customerFlowChart
            // 
            this.customerFlowChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.customerFlowChart.BorderlineColor = System.Drawing.Color.DarkRed;
            chartArea2.Name = "ChartArea1";
            this.customerFlowChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.customerFlowChart.Legends.Add(legend2);
            this.customerFlowChart.Location = new System.Drawing.Point(625, 253);
            this.customerFlowChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerFlowChart.Name = "customerFlowChart";
            this.customerFlowChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.customerFlowChart.Series.Add(series2);
            this.customerFlowChart.Size = new System.Drawing.Size(347, 258);
            this.customerFlowChart.TabIndex = 30;
            this.customerFlowChart.Text = "CustomerFlow";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.lblManagerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(64, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 110);
            this.panel1.TabIndex = 31;
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerName.Location = new System.Drawing.Point(60, 61);
            this.lblManagerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(63, 25);
            this.lblManagerName.TabIndex = 16;
            this.lblManagerName.Text = "Nigga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "HR Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblEmployeeCount);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(376, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 110);
            this.panel2.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 30);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Employees";
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.AutoSize = true;
            this.lblEmployeeCount.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCount.Location = new System.Drawing.Point(75, 61);
            this.lblEmployeeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(46, 30);
            this.lblEmployeeCount.TabIndex = 15;
            this.lblEmployeeCount.Text = "250";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.panel3.Controls.Add(this.lblEvent);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(690, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 110);
            this.panel3.TabIndex = 32;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(61, 61);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(58, 25);
            this.lblEvent.TabIndex = 17;
            this.lblEvent.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Upcoming Event";
            // 
            // btnManager
            // 
            this.btnManager.AllowAnimations = true;
            this.btnManager.AllowMouseEffects = true;
            this.btnManager.AllowToggling = false;
            this.btnManager.AnimationSpeed = 200;
            this.btnManager.AutoGenerateColors = false;
            this.btnManager.AutoRoundBorders = false;
            this.btnManager.AutoSizeLeftIcon = true;
            this.btnManager.AutoSizeRightIcon = true;
            this.btnManager.BackColor = System.Drawing.Color.Transparent;
            this.btnManager.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManager.BackgroundImage")));
            this.btnManager.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnManager.ButtonText = "Save";
            this.btnManager.ButtonTextMarginLeft = 0;
            this.btnManager.ColorContrastOnClick = 45;
            this.btnManager.ColorContrastOnHover = 45;
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnManager.CustomizableEdges = borderEdges9;
            this.btnManager.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManager.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManager.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManager.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnManager.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManager.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnManager.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnManager.IconMarginLeft = 11;
            this.btnManager.IconPadding = 10;
            this.btnManager.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManager.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnManager.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnManager.IconSize = 25;
            this.btnManager.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnManager.IdleBorderRadius = 25;
            this.btnManager.IdleBorderThickness = 1;
            this.btnManager.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManager.IdleIconLeftImage = null;
            this.btnManager.IdleIconRightImage = null;
            this.btnManager.IndicateFocus = false;
            this.btnManager.Location = new System.Drawing.Point(222, 190);
            this.btnManager.Name = "btnManager";
            this.btnManager.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManager.OnDisabledState.BorderRadius = 25;
            this.btnManager.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnManager.OnDisabledState.BorderThickness = 1;
            this.btnManager.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManager.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnManager.OnDisabledState.IconLeftImage = null;
            this.btnManager.OnDisabledState.IconRightImage = null;
            this.btnManager.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnManager.onHoverState.BorderRadius = 25;
            this.btnManager.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnManager.onHoverState.BorderThickness = 1;
            this.btnManager.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnManager.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnManager.onHoverState.IconLeftImage = null;
            this.btnManager.onHoverState.IconRightImage = null;
            this.btnManager.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnManager.OnIdleState.BorderRadius = 25;
            this.btnManager.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnManager.OnIdleState.BorderThickness = 1;
            this.btnManager.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManager.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManager.OnIdleState.IconLeftImage = null;
            this.btnManager.OnIdleState.IconRightImage = null;
            this.btnManager.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManager.OnPressedState.BorderRadius = 25;
            this.btnManager.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnManager.OnPressedState.BorderThickness = 1;
            this.btnManager.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManager.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnManager.OnPressedState.IconLeftImage = null;
            this.btnManager.OnPressedState.IconRightImage = null;
            this.btnManager.Size = new System.Drawing.Size(69, 20);
            this.btnManager.TabIndex = 34;
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManager.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManager.TextMarginLeft = 0;
            this.btnManager.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnManager.UseDefaultRadiusAndThickness = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // tbManager
            // 
            this.tbManager.Location = new System.Drawing.Point(95, 190);
            this.tbManager.Name = "tbManager";
            this.tbManager.Size = new System.Drawing.Size(100, 20);
            this.tbManager.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Change Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(721, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Add Event";
            // 
            // tbEvent
            // 
            this.tbEvent.Location = new System.Drawing.Point(725, 190);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(100, 20);
            this.tbEvent.TabIndex = 38;
            // 
            // btnEvent
            // 
            this.btnEvent.AllowAnimations = true;
            this.btnEvent.AllowMouseEffects = true;
            this.btnEvent.AllowToggling = false;
            this.btnEvent.AnimationSpeed = 200;
            this.btnEvent.AutoGenerateColors = false;
            this.btnEvent.AutoRoundBorders = false;
            this.btnEvent.AutoSizeLeftIcon = true;
            this.btnEvent.AutoSizeRightIcon = true;
            this.btnEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnEvent.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEvent.BackgroundImage")));
            this.btnEvent.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEvent.ButtonText = "Save";
            this.btnEvent.ButtonTextMarginLeft = 0;
            this.btnEvent.ColorContrastOnClick = 45;
            this.btnEvent.ColorContrastOnHover = 45;
            this.btnEvent.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnEvent.CustomizableEdges = borderEdges10;
            this.btnEvent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEvent.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEvent.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEvent.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEvent.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEvent.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEvent.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEvent.IconMarginLeft = 11;
            this.btnEvent.IconPadding = 10;
            this.btnEvent.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvent.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEvent.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEvent.IconSize = 25;
            this.btnEvent.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnEvent.IdleBorderRadius = 25;
            this.btnEvent.IdleBorderThickness = 1;
            this.btnEvent.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.IdleIconLeftImage = null;
            this.btnEvent.IdleIconRightImage = null;
            this.btnEvent.IndicateFocus = false;
            this.btnEvent.Location = new System.Drawing.Point(856, 190);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEvent.OnDisabledState.BorderRadius = 25;
            this.btnEvent.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEvent.OnDisabledState.BorderThickness = 1;
            this.btnEvent.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEvent.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEvent.OnDisabledState.IconLeftImage = null;
            this.btnEvent.OnDisabledState.IconRightImage = null;
            this.btnEvent.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.onHoverState.BorderRadius = 25;
            this.btnEvent.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEvent.onHoverState.BorderThickness = 1;
            this.btnEvent.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEvent.onHoverState.IconLeftImage = null;
            this.btnEvent.onHoverState.IconRightImage = null;
            this.btnEvent.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEvent.OnIdleState.BorderRadius = 25;
            this.btnEvent.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEvent.OnIdleState.BorderThickness = 1;
            this.btnEvent.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEvent.OnIdleState.IconLeftImage = null;
            this.btnEvent.OnIdleState.IconRightImage = null;
            this.btnEvent.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.OnPressedState.BorderRadius = 25;
            this.btnEvent.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEvent.OnPressedState.BorderThickness = 1;
            this.btnEvent.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEvent.OnPressedState.IconLeftImage = null;
            this.btnEvent.OnPressedState.IconRightImage = null;
            this.btnEvent.Size = new System.Drawing.Size(69, 20);
            this.btnEvent.TabIndex = 37;
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEvent.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEvent.TextMarginLeft = 0;
            this.btnEvent.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEvent.UseDefaultRadiusAndThickness = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.AllowAnimations = true;
            this.btnEmp.AllowMouseEffects = true;
            this.btnEmp.AllowToggling = false;
            this.btnEmp.AnimationSpeed = 200;
            this.btnEmp.AutoGenerateColors = false;
            this.btnEmp.AutoRoundBorders = false;
            this.btnEmp.AutoSizeLeftIcon = true;
            this.btnEmp.AutoSizeRightIcon = true;
            this.btnEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnEmp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmp.BackgroundImage")));
            this.btnEmp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmp.ButtonText = "Employees";
            this.btnEmp.ButtonTextMarginLeft = 0;
            this.btnEmp.ColorContrastOnClick = 45;
            this.btnEmp.ColorContrastOnHover = 45;
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnEmp.CustomizableEdges = borderEdges11;
            this.btnEmp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.ForeColor = System.Drawing.Color.White;
            this.btnEmp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEmp.IconMarginLeft = 11;
            this.btnEmp.IconPadding = 10;
            this.btnEmp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEmp.IconSize = 25;
            this.btnEmp.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnEmp.IdleBorderRadius = 25;
            this.btnEmp.IdleBorderThickness = 1;
            this.btnEmp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmp.IdleIconLeftImage = null;
            this.btnEmp.IdleIconRightImage = null;
            this.btnEmp.IndicateFocus = false;
            this.btnEmp.Location = new System.Drawing.Point(91, 268);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmp.OnDisabledState.BorderRadius = 25;
            this.btnEmp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmp.OnDisabledState.BorderThickness = 1;
            this.btnEmp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmp.OnDisabledState.IconLeftImage = null;
            this.btnEmp.OnDisabledState.IconRightImage = null;
            this.btnEmp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnEmp.onHoverState.BorderRadius = 25;
            this.btnEmp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmp.onHoverState.BorderThickness = 1;
            this.btnEmp.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnEmp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEmp.onHoverState.IconLeftImage = null;
            this.btnEmp.onHoverState.IconRightImage = null;
            this.btnEmp.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmp.OnIdleState.BorderRadius = 25;
            this.btnEmp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmp.OnIdleState.BorderThickness = 1;
            this.btnEmp.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmp.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEmp.OnIdleState.IconLeftImage = null;
            this.btnEmp.OnIdleState.IconRightImage = null;
            this.btnEmp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEmp.OnPressedState.BorderRadius = 25;
            this.btnEmp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmp.OnPressedState.BorderThickness = 1;
            this.btnEmp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEmp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEmp.OnPressedState.IconLeftImage = null;
            this.btnEmp.OnPressedState.IconRightImage = null;
            this.btnEmp.Size = new System.Drawing.Size(150, 48);
            this.btnEmp.TabIndex = 55;
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmp.TextMarginLeft = 0;
            this.btnEmp.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEmp.UseDefaultRadiusAndThickness = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.AllowAnimations = true;
            this.btnPerformance.AllowMouseEffects = true;
            this.btnPerformance.AllowToggling = false;
            this.btnPerformance.AnimationSpeed = 200;
            this.btnPerformance.AutoGenerateColors = false;
            this.btnPerformance.AutoRoundBorders = false;
            this.btnPerformance.AutoSizeLeftIcon = true;
            this.btnPerformance.AutoSizeRightIcon = true;
            this.btnPerformance.BackColor = System.Drawing.Color.Transparent;
            this.btnPerformance.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPerformance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerformance.BackgroundImage")));
            this.btnPerformance.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerformance.ButtonText = "Performance";
            this.btnPerformance.ButtonTextMarginLeft = 0;
            this.btnPerformance.ColorContrastOnClick = 45;
            this.btnPerformance.ColorContrastOnHover = 45;
            this.btnPerformance.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btnPerformance.CustomizableEdges = borderEdges12;
            this.btnPerformance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPerformance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPerformance.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPerformance.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPerformance.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformance.ForeColor = System.Drawing.Color.White;
            this.btnPerformance.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformance.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPerformance.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPerformance.IconMarginLeft = 11;
            this.btnPerformance.IconPadding = 10;
            this.btnPerformance.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerformance.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPerformance.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPerformance.IconSize = 25;
            this.btnPerformance.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPerformance.IdleBorderRadius = 25;
            this.btnPerformance.IdleBorderThickness = 1;
            this.btnPerformance.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPerformance.IdleIconLeftImage = null;
            this.btnPerformance.IdleIconRightImage = null;
            this.btnPerformance.IndicateFocus = false;
            this.btnPerformance.Location = new System.Drawing.Point(412, 268);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPerformance.OnDisabledState.BorderRadius = 25;
            this.btnPerformance.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerformance.OnDisabledState.BorderThickness = 1;
            this.btnPerformance.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPerformance.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPerformance.OnDisabledState.IconLeftImage = null;
            this.btnPerformance.OnDisabledState.IconRightImage = null;
            this.btnPerformance.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPerformance.onHoverState.BorderRadius = 25;
            this.btnPerformance.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerformance.onHoverState.BorderThickness = 1;
            this.btnPerformance.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPerformance.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPerformance.onHoverState.IconLeftImage = null;
            this.btnPerformance.onHoverState.IconRightImage = null;
            this.btnPerformance.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPerformance.OnIdleState.BorderRadius = 25;
            this.btnPerformance.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerformance.OnIdleState.BorderThickness = 1;
            this.btnPerformance.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPerformance.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPerformance.OnIdleState.IconLeftImage = null;
            this.btnPerformance.OnIdleState.IconRightImage = null;
            this.btnPerformance.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnPerformance.OnPressedState.BorderRadius = 25;
            this.btnPerformance.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerformance.OnPressedState.BorderThickness = 1;
            this.btnPerformance.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnPerformance.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPerformance.OnPressedState.IconLeftImage = null;
            this.btnPerformance.OnPressedState.IconRightImage = null;
            this.btnPerformance.Size = new System.Drawing.Size(150, 48);
            this.btnPerformance.TabIndex = 56;
            this.btnPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPerformance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPerformance.TextMarginLeft = 0;
            this.btnPerformance.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPerformance.UseDefaultRadiusAndThickness = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // btnTimecards
            // 
            this.btnTimecards.AllowAnimations = true;
            this.btnTimecards.AllowMouseEffects = true;
            this.btnTimecards.AllowToggling = false;
            this.btnTimecards.AnimationSpeed = 200;
            this.btnTimecards.AutoGenerateColors = false;
            this.btnTimecards.AutoRoundBorders = false;
            this.btnTimecards.AutoSizeLeftIcon = true;
            this.btnTimecards.AutoSizeRightIcon = true;
            this.btnTimecards.BackColor = System.Drawing.Color.Transparent;
            this.btnTimecards.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimecards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimecards.BackgroundImage")));
            this.btnTimecards.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTimecards.ButtonText = "Timecards";
            this.btnTimecards.ButtonTextMarginLeft = 0;
            this.btnTimecards.ColorContrastOnClick = 45;
            this.btnTimecards.ColorContrastOnHover = 45;
            this.btnTimecards.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.btnTimecards.CustomizableEdges = borderEdges13;
            this.btnTimecards.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimecards.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTimecards.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTimecards.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTimecards.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTimecards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimecards.ForeColor = System.Drawing.Color.White;
            this.btnTimecards.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimecards.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTimecards.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTimecards.IconMarginLeft = 11;
            this.btnTimecards.IconPadding = 10;
            this.btnTimecards.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimecards.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTimecards.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTimecards.IconSize = 25;
            this.btnTimecards.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnTimecards.IdleBorderRadius = 25;
            this.btnTimecards.IdleBorderThickness = 1;
            this.btnTimecards.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimecards.IdleIconLeftImage = null;
            this.btnTimecards.IdleIconRightImage = null;
            this.btnTimecards.IndicateFocus = false;
            this.btnTimecards.Location = new System.Drawing.Point(91, 361);
            this.btnTimecards.Name = "btnTimecards";
            this.btnTimecards.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTimecards.OnDisabledState.BorderRadius = 25;
            this.btnTimecards.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTimecards.OnDisabledState.BorderThickness = 1;
            this.btnTimecards.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTimecards.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTimecards.OnDisabledState.IconLeftImage = null;
            this.btnTimecards.OnDisabledState.IconRightImage = null;
            this.btnTimecards.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnTimecards.onHoverState.BorderRadius = 25;
            this.btnTimecards.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTimecards.onHoverState.BorderThickness = 1;
            this.btnTimecards.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnTimecards.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTimecards.onHoverState.IconLeftImage = null;
            this.btnTimecards.onHoverState.IconRightImage = null;
            this.btnTimecards.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimecards.OnIdleState.BorderRadius = 25;
            this.btnTimecards.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTimecards.OnIdleState.BorderThickness = 1;
            this.btnTimecards.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimecards.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTimecards.OnIdleState.IconLeftImage = null;
            this.btnTimecards.OnIdleState.IconRightImage = null;
            this.btnTimecards.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTimecards.OnPressedState.BorderRadius = 25;
            this.btnTimecards.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTimecards.OnPressedState.BorderThickness = 1;
            this.btnTimecards.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTimecards.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTimecards.OnPressedState.IconLeftImage = null;
            this.btnTimecards.OnPressedState.IconRightImage = null;
            this.btnTimecards.Size = new System.Drawing.Size(150, 48);
            this.btnTimecards.TabIndex = 57;
            this.btnTimecards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimecards.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimecards.TextMarginLeft = 0;
            this.btnTimecards.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTimecards.UseDefaultRadiusAndThickness = true;
            this.btnTimecards.Click += new System.EventHandler(this.btnTimecards_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.AllowAnimations = true;
            this.btnAttendance.AllowMouseEffects = true;
            this.btnAttendance.AllowToggling = false;
            this.btnAttendance.AnimationSpeed = 200;
            this.btnAttendance.AutoGenerateColors = false;
            this.btnAttendance.AutoRoundBorders = false;
            this.btnAttendance.AutoSizeLeftIcon = true;
            this.btnAttendance.AutoSizeRightIcon = true;
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.BackgroundImage")));
            this.btnAttendance.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.ButtonText = "Attendance";
            this.btnAttendance.ButtonTextMarginLeft = 0;
            this.btnAttendance.ColorContrastOnClick = 45;
            this.btnAttendance.ColorContrastOnHover = 45;
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.btnAttendance.CustomizableEdges = borderEdges14;
            this.btnAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAttendance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAttendance.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAttendance.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAttendance.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAttendance.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAttendance.IconMarginLeft = 11;
            this.btnAttendance.IconPadding = 10;
            this.btnAttendance.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttendance.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAttendance.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAttendance.IconSize = 25;
            this.btnAttendance.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAttendance.IdleBorderRadius = 25;
            this.btnAttendance.IdleBorderThickness = 1;
            this.btnAttendance.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAttendance.IdleIconLeftImage = null;
            this.btnAttendance.IdleIconRightImage = null;
            this.btnAttendance.IndicateFocus = false;
            this.btnAttendance.Location = new System.Drawing.Point(91, 453);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAttendance.OnDisabledState.BorderRadius = 25;
            this.btnAttendance.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.OnDisabledState.BorderThickness = 1;
            this.btnAttendance.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAttendance.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAttendance.OnDisabledState.IconLeftImage = null;
            this.btnAttendance.OnDisabledState.IconRightImage = null;
            this.btnAttendance.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAttendance.onHoverState.BorderRadius = 25;
            this.btnAttendance.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.onHoverState.BorderThickness = 1;
            this.btnAttendance.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAttendance.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.onHoverState.IconLeftImage = null;
            this.btnAttendance.onHoverState.IconRightImage = null;
            this.btnAttendance.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAttendance.OnIdleState.BorderRadius = 25;
            this.btnAttendance.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.OnIdleState.BorderThickness = 1;
            this.btnAttendance.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAttendance.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.OnIdleState.IconLeftImage = null;
            this.btnAttendance.OnIdleState.IconRightImage = null;
            this.btnAttendance.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAttendance.OnPressedState.BorderRadius = 25;
            this.btnAttendance.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.OnPressedState.BorderThickness = 1;
            this.btnAttendance.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAttendance.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.OnPressedState.IconLeftImage = null;
            this.btnAttendance.OnPressedState.IconRightImage = null;
            this.btnAttendance.Size = new System.Drawing.Size(150, 48);
            this.btnAttendance.TabIndex = 58;
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttendance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAttendance.TextMarginLeft = 0;
            this.btnAttendance.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAttendance.UseDefaultRadiusAndThickness = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click_1);
            // 
            // btnRecruitments
            // 
            this.btnRecruitments.AllowAnimations = true;
            this.btnRecruitments.AllowMouseEffects = true;
            this.btnRecruitments.AllowToggling = false;
            this.btnRecruitments.AnimationSpeed = 200;
            this.btnRecruitments.AutoGenerateColors = false;
            this.btnRecruitments.AutoRoundBorders = false;
            this.btnRecruitments.AutoSizeLeftIcon = true;
            this.btnRecruitments.AutoSizeRightIcon = true;
            this.btnRecruitments.BackColor = System.Drawing.Color.Transparent;
            this.btnRecruitments.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecruitments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecruitments.BackgroundImage")));
            this.btnRecruitments.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecruitments.ButtonText = "Recruitments";
            this.btnRecruitments.ButtonTextMarginLeft = 0;
            this.btnRecruitments.ColorContrastOnClick = 45;
            this.btnRecruitments.ColorContrastOnHover = 45;
            this.btnRecruitments.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.btnRecruitments.CustomizableEdges = borderEdges15;
            this.btnRecruitments.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecruitments.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRecruitments.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRecruitments.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRecruitments.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRecruitments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecruitments.ForeColor = System.Drawing.Color.White;
            this.btnRecruitments.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruitments.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRecruitments.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRecruitments.IconMarginLeft = 11;
            this.btnRecruitments.IconPadding = 10;
            this.btnRecruitments.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecruitments.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRecruitments.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRecruitments.IconSize = 25;
            this.btnRecruitments.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnRecruitments.IdleBorderRadius = 25;
            this.btnRecruitments.IdleBorderThickness = 1;
            this.btnRecruitments.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecruitments.IdleIconLeftImage = null;
            this.btnRecruitments.IdleIconRightImage = null;
            this.btnRecruitments.IndicateFocus = false;
            this.btnRecruitments.Location = new System.Drawing.Point(412, 453);
            this.btnRecruitments.Name = "btnRecruitments";
            this.btnRecruitments.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRecruitments.OnDisabledState.BorderRadius = 25;
            this.btnRecruitments.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecruitments.OnDisabledState.BorderThickness = 1;
            this.btnRecruitments.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRecruitments.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRecruitments.OnDisabledState.IconLeftImage = null;
            this.btnRecruitments.OnDisabledState.IconRightImage = null;
            this.btnRecruitments.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRecruitments.onHoverState.BorderRadius = 25;
            this.btnRecruitments.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecruitments.onHoverState.BorderThickness = 1;
            this.btnRecruitments.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRecruitments.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRecruitments.onHoverState.IconLeftImage = null;
            this.btnRecruitments.onHoverState.IconRightImage = null;
            this.btnRecruitments.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRecruitments.OnIdleState.BorderRadius = 25;
            this.btnRecruitments.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecruitments.OnIdleState.BorderThickness = 1;
            this.btnRecruitments.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecruitments.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRecruitments.OnIdleState.IconLeftImage = null;
            this.btnRecruitments.OnIdleState.IconRightImage = null;
            this.btnRecruitments.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnRecruitments.OnPressedState.BorderRadius = 25;
            this.btnRecruitments.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecruitments.OnPressedState.BorderThickness = 1;
            this.btnRecruitments.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnRecruitments.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRecruitments.OnPressedState.IconLeftImage = null;
            this.btnRecruitments.OnPressedState.IconRightImage = null;
            this.btnRecruitments.Size = new System.Drawing.Size(150, 48);
            this.btnRecruitments.TabIndex = 59;
            this.btnRecruitments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecruitments.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRecruitments.TextMarginLeft = 0;
            this.btnRecruitments.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRecruitments.UseDefaultRadiusAndThickness = true;
            this.btnRecruitments.Click += new System.EventHandler(this.btnRecruitments_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.AllowAnimations = true;
            this.btnPayroll.AllowMouseEffects = true;
            this.btnPayroll.AllowToggling = false;
            this.btnPayroll.AnimationSpeed = 200;
            this.btnPayroll.AutoGenerateColors = false;
            this.btnPayroll.AutoRoundBorders = false;
            this.btnPayroll.AutoSizeLeftIcon = true;
            this.btnPayroll.AutoSizeRightIcon = true;
            this.btnPayroll.BackColor = System.Drawing.Color.Transparent;
            this.btnPayroll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayroll.BackgroundImage")));
            this.btnPayroll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayroll.ButtonText = "Payroll Journal";
            this.btnPayroll.ButtonTextMarginLeft = 0;
            this.btnPayroll.ColorContrastOnClick = 45;
            this.btnPayroll.ColorContrastOnHover = 45;
            this.btnPayroll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.btnPayroll.CustomizableEdges = borderEdges16;
            this.btnPayroll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPayroll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPayroll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPayroll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPayroll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayroll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPayroll.IconMarginLeft = 11;
            this.btnPayroll.IconPadding = 10;
            this.btnPayroll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayroll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayroll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPayroll.IconSize = 25;
            this.btnPayroll.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPayroll.IdleBorderRadius = 25;
            this.btnPayroll.IdleBorderThickness = 1;
            this.btnPayroll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayroll.IdleIconLeftImage = null;
            this.btnPayroll.IdleIconRightImage = null;
            this.btnPayroll.IndicateFocus = false;
            this.btnPayroll.Location = new System.Drawing.Point(412, 361);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPayroll.OnDisabledState.BorderRadius = 25;
            this.btnPayroll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayroll.OnDisabledState.BorderThickness = 1;
            this.btnPayroll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPayroll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPayroll.OnDisabledState.IconLeftImage = null;
            this.btnPayroll.OnDisabledState.IconRightImage = null;
            this.btnPayroll.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPayroll.onHoverState.BorderRadius = 25;
            this.btnPayroll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayroll.onHoverState.BorderThickness = 1;
            this.btnPayroll.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPayroll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.onHoverState.IconLeftImage = null;
            this.btnPayroll.onHoverState.IconRightImage = null;
            this.btnPayroll.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPayroll.OnIdleState.BorderRadius = 25;
            this.btnPayroll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayroll.OnIdleState.BorderThickness = 1;
            this.btnPayroll.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayroll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.OnIdleState.IconLeftImage = null;
            this.btnPayroll.OnIdleState.IconRightImage = null;
            this.btnPayroll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnPayroll.OnPressedState.BorderRadius = 25;
            this.btnPayroll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayroll.OnPressedState.BorderThickness = 1;
            this.btnPayroll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnPayroll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.OnPressedState.IconLeftImage = null;
            this.btnPayroll.OnPressedState.IconRightImage = null;
            this.btnPayroll.Size = new System.Drawing.Size(150, 48);
            this.btnPayroll.TabIndex = 60;
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayroll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPayroll.TextMarginLeft = 0;
            this.btnPayroll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPayroll.UseDefaultRadiusAndThickness = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // frmHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.btnRecruitments);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnTimecards);
            this.Controls.Add(this.btnPerformance);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEvent);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbManager);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerFlowChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHR";
            this.Text = "frmHR";
            this.Load += new System.EventHandler(this.frmHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFlowChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart customerFlowChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmployeeCount;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnManager;
        private System.Windows.Forms.TextBox tbManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEvent;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEvent;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEmp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPerformance;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTimecards;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAttendance;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRecruitments;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPayroll;
    }
}