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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 493);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblID.Location = new System.Drawing.Point(56, 325);
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
            this.label2.Location = new System.Drawing.Point(38, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Attendance Status:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(247, 328);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(108, 22);
            this.tbID.TabIndex = 1;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(247, 510);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(108, 22);
            this.tbStatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(57, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Day Number:";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(247, 420);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(108, 22);
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAttendance.CustomizableEdges = borderEdges5;
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
            this.btnAttendance.Location = new System.Drawing.Point(529, 573);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnAttendance.Size = new System.Drawing.Size(200, 48);
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
            this.label4.Location = new System.Drawing.Point(21, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Week Starting Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(67, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "02-03-2024";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(41, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 106);
            this.panel1.TabIndex = 36;
            // 
            // HR_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1441, 673);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}