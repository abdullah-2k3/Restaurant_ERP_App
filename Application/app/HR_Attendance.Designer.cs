namespace app
{
    partial class HR_Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_Attendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.btnAttendance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblID.Location = new System.Drawing.Point(50, 311);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(107, 21);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "EmployeeID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(36, 461);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Attendance Status:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(193, 313);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(82, 20);
            this.tbID.TabIndex = 1;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(193, 461);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(82, 20);
            this.tbStatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(51, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Day Number:";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(193, 388);
            this.tbDay.Margin = new System.Windows.Forms.Padding(2);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(82, 20);
            this.tbDay.TabIndex = 2;
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
            this.btnAttendance.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.BackgroundImage")));
            this.btnAttendance.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.ButtonText = "Add Attendance";
            this.btnAttendance.ButtonTextMarginLeft = 0;
            this.btnAttendance.ColorContrastOnClick = 45;
            this.btnAttendance.ColorContrastOnHover = 45;
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAttendance.CustomizableEdges = borderEdges1;
            this.btnAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAttendance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAttendance.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAttendance.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAttendance.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.Navy;
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
            this.btnAttendance.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAttendance.IdleIconLeftImage = null;
            this.btnAttendance.IdleIconRightImage = null;
            this.btnAttendance.IndicateFocus = false;
            this.btnAttendance.Location = new System.Drawing.Point(397, 466);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAttendance.OnDisabledState.BorderRadius = 25;
            this.btnAttendance.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.OnDisabledState.BorderThickness = 1;
            this.btnAttendance.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAttendance.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAttendance.OnDisabledState.IconLeftImage = null;
            this.btnAttendance.OnDisabledState.IconRightImage = null;
            this.btnAttendance.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnAttendance.onHoverState.BorderRadius = 25;
            this.btnAttendance.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.onHoverState.BorderThickness = 1;
            this.btnAttendance.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAttendance.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.onHoverState.IconLeftImage = null;
            this.btnAttendance.onHoverState.IconRightImage = null;
            this.btnAttendance.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAttendance.OnIdleState.BorderRadius = 25;
            this.btnAttendance.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.OnIdleState.BorderThickness = 1;
            this.btnAttendance.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAttendance.OnIdleState.ForeColor = System.Drawing.Color.Navy;
            this.btnAttendance.OnIdleState.IconLeftImage = null;
            this.btnAttendance.OnIdleState.IconRightImage = null;
            this.btnAttendance.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAttendance.OnPressedState.BorderRadius = 25;
            this.btnAttendance.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttendance.OnPressedState.BorderThickness = 1;
            this.btnAttendance.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.btnAttendance.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.OnPressedState.IconLeftImage = null;
            this.btnAttendance.OnPressedState.IconRightImage = null;
            this.btnAttendance.Size = new System.Drawing.Size(150, 39);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttendance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAttendance.TextMarginLeft = 0;
            this.btnAttendance.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAttendance.UseDefaultRadiusAndThickness = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Week Starting Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(50, 51);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 25);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "02-03-2024";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(31, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 87);
            this.panel1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(27, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Change Start Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // btnDate
            // 
            this.btnDate.AllowAnimations = true;
            this.btnDate.AllowMouseEffects = true;
            this.btnDate.AllowToggling = false;
            this.btnDate.AnimationSpeed = 200;
            this.btnDate.AutoGenerateColors = false;
            this.btnDate.AutoRoundBorders = false;
            this.btnDate.AutoSizeLeftIcon = true;
            this.btnDate.AutoSizeRightIcon = true;
            this.btnDate.BackColor = System.Drawing.Color.Transparent;
            this.btnDate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDate.BackgroundImage")));
            this.btnDate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDate.ButtonText = "Save";
            this.btnDate.ButtonTextMarginLeft = 0;
            this.btnDate.ColorContrastOnClick = 45;
            this.btnDate.ColorContrastOnHover = 45;
            this.btnDate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDate.CustomizableEdges = borderEdges2;
            this.btnDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDate.IconMarginLeft = 11;
            this.btnDate.IconPadding = 10;
            this.btnDate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDate.IconSize = 25;
            this.btnDate.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnDate.IdleBorderRadius = 25;
            this.btnDate.IdleBorderThickness = 1;
            this.btnDate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDate.IdleIconLeftImage = null;
            this.btnDate.IdleIconRightImage = null;
            this.btnDate.IndicateFocus = false;
            this.btnDate.Location = new System.Drawing.Point(227, 251);
            this.btnDate.Name = "btnDate";
            this.btnDate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDate.OnDisabledState.BorderRadius = 25;
            this.btnDate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDate.OnDisabledState.BorderThickness = 1;
            this.btnDate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDate.OnDisabledState.IconLeftImage = null;
            this.btnDate.OnDisabledState.IconRightImage = null;
            this.btnDate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnDate.onHoverState.BorderRadius = 25;
            this.btnDate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDate.onHoverState.BorderThickness = 1;
            this.btnDate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnDate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDate.onHoverState.IconLeftImage = null;
            this.btnDate.onHoverState.IconRightImage = null;
            this.btnDate.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDate.OnIdleState.BorderRadius = 25;
            this.btnDate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDate.OnIdleState.BorderThickness = 1;
            this.btnDate.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDate.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDate.OnIdleState.IconLeftImage = null;
            this.btnDate.OnIdleState.IconRightImage = null;
            this.btnDate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnDate.OnPressedState.BorderRadius = 25;
            this.btnDate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDate.OnPressedState.BorderThickness = 1;
            this.btnDate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnDate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDate.OnPressedState.IconLeftImage = null;
            this.btnDate.OnPressedState.IconRightImage = null;
            this.btnDate.Size = new System.Drawing.Size(69, 20);
            this.btnDate.TabIndex = 38;
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDate.TextMarginLeft = 0;
            this.btnDate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDate.UseDefaultRadiusAndThickness = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // HR_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HR_Attendance";
            this.Text = "HR_Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDay;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAttendance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDate;
    }
}