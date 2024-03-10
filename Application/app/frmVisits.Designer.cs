namespace app
{
    partial class frmVisits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisits));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnUpdateEmp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDelEmp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddEmp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(154, 308);
            this.tbDay.Margin = new System.Windows.Forms.Padding(2);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(82, 20);
            this.tbDay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(29, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Visit Day:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(154, 392);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(82, 20);
            this.tbAmount.TabIndex = 4;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(154, 131);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(82, 20);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(28, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Bill Amount:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblID.Location = new System.Drawing.Point(29, 130);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(108, 21);
            this.lblID.TabIndex = 46;
            this.lblID.Text = "Customer ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 340);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 47);
            this.label1.TabIndex = 41;
            this.label1.Text = "Customer Visits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(51, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(154, 216);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(82, 20);
            this.tbName.TabIndex = 2;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.AllowAnimations = true;
            this.btnUpdateEmp.AllowMouseEffects = true;
            this.btnUpdateEmp.AllowToggling = false;
            this.btnUpdateEmp.AnimationSpeed = 200;
            this.btnUpdateEmp.AutoGenerateColors = false;
            this.btnUpdateEmp.AutoRoundBorders = false;
            this.btnUpdateEmp.AutoSizeLeftIcon = true;
            this.btnUpdateEmp.AutoSizeRightIcon = true;
            this.btnUpdateEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateEmp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btnUpdateEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmp.BackgroundImage")));
            this.btnUpdateEmp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateEmp.ButtonText = "Update Visit";
            this.btnUpdateEmp.ButtonTextMarginLeft = 0;
            this.btnUpdateEmp.ColorContrastOnClick = 45;
            this.btnUpdateEmp.ColorContrastOnHover = 45;
            this.btnUpdateEmp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnUpdateEmp.CustomizableEdges = borderEdges1;
            this.btnUpdateEmp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateEmp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdateEmp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdateEmp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdateEmp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateEmp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateEmp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUpdateEmp.IconMarginLeft = 11;
            this.btnUpdateEmp.IconPadding = 10;
            this.btnUpdateEmp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateEmp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateEmp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUpdateEmp.IconSize = 25;
            this.btnUpdateEmp.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateEmp.IdleBorderRadius = 25;
            this.btnUpdateEmp.IdleBorderThickness = 1;
            this.btnUpdateEmp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btnUpdateEmp.IdleIconLeftImage = null;
            this.btnUpdateEmp.IdleIconRightImage = null;
            this.btnUpdateEmp.IndicateFocus = false;
            this.btnUpdateEmp.Location = new System.Drawing.Point(356, 474);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdateEmp.OnDisabledState.BorderRadius = 25;
            this.btnUpdateEmp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateEmp.OnDisabledState.BorderThickness = 1;
            this.btnUpdateEmp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdateEmp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdateEmp.OnDisabledState.IconLeftImage = null;
            this.btnUpdateEmp.OnDisabledState.IconRightImage = null;
            this.btnUpdateEmp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
            this.btnUpdateEmp.onHoverState.BorderRadius = 25;
            this.btnUpdateEmp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateEmp.onHoverState.BorderThickness = 1;
            this.btnUpdateEmp.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnUpdateEmp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmp.onHoverState.IconLeftImage = null;
            this.btnUpdateEmp.onHoverState.IconRightImage = null;
            this.btnUpdateEmp.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateEmp.OnIdleState.BorderRadius = 25;
            this.btnUpdateEmp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateEmp.OnIdleState.BorderThickness = 1;
            this.btnUpdateEmp.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btnUpdateEmp.OnIdleState.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateEmp.OnIdleState.IconLeftImage = null;
            this.btnUpdateEmp.OnIdleState.IconRightImage = null;
            this.btnUpdateEmp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnUpdateEmp.OnPressedState.BorderRadius = 25;
            this.btnUpdateEmp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateEmp.OnPressedState.BorderThickness = 1;
            this.btnUpdateEmp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnUpdateEmp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmp.OnPressedState.IconLeftImage = null;
            this.btnUpdateEmp.OnPressedState.IconRightImage = null;
            this.btnUpdateEmp.Size = new System.Drawing.Size(158, 39);
            this.btnUpdateEmp.TabIndex = 6;
            this.btnUpdateEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateEmp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateEmp.TextMarginLeft = 0;
            this.btnUpdateEmp.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpdateEmp.UseDefaultRadiusAndThickness = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.AllowAnimations = true;
            this.btnDelEmp.AllowMouseEffects = true;
            this.btnDelEmp.AllowToggling = false;
            this.btnDelEmp.AnimationSpeed = 200;
            this.btnDelEmp.AutoGenerateColors = false;
            this.btnDelEmp.AutoRoundBorders = false;
            this.btnDelEmp.AutoSizeLeftIcon = true;
            this.btnDelEmp.AutoSizeRightIcon = true;
            this.btnDelEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnDelEmp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDelEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelEmp.BackgroundImage")));
            this.btnDelEmp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelEmp.ButtonText = "Delete Visit";
            this.btnDelEmp.ButtonTextMarginLeft = 0;
            this.btnDelEmp.ColorContrastOnClick = 45;
            this.btnDelEmp.ColorContrastOnHover = 45;
            this.btnDelEmp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDelEmp.CustomizableEdges = borderEdges2;
            this.btnDelEmp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelEmp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelEmp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelEmp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelEmp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmp.ForeColor = System.Drawing.Color.Navy;
            this.btnDelEmp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelEmp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelEmp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelEmp.IconMarginLeft = 11;
            this.btnDelEmp.IconPadding = 10;
            this.btnDelEmp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelEmp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelEmp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelEmp.IconSize = 25;
            this.btnDelEmp.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnDelEmp.IdleBorderRadius = 25;
            this.btnDelEmp.IdleBorderThickness = 1;
            this.btnDelEmp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDelEmp.IdleIconLeftImage = null;
            this.btnDelEmp.IdleIconRightImage = null;
            this.btnDelEmp.IndicateFocus = false;
            this.btnDelEmp.Location = new System.Drawing.Point(564, 474);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelEmp.OnDisabledState.BorderRadius = 25;
            this.btnDelEmp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelEmp.OnDisabledState.BorderThickness = 1;
            this.btnDelEmp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelEmp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelEmp.OnDisabledState.IconLeftImage = null;
            this.btnDelEmp.OnDisabledState.IconRightImage = null;
            this.btnDelEmp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDelEmp.onHoverState.BorderRadius = 25;
            this.btnDelEmp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelEmp.onHoverState.BorderThickness = 1;
            this.btnDelEmp.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDelEmp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelEmp.onHoverState.IconLeftImage = null;
            this.btnDelEmp.onHoverState.IconRightImage = null;
            this.btnDelEmp.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelEmp.OnIdleState.BorderRadius = 25;
            this.btnDelEmp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelEmp.OnIdleState.BorderThickness = 1;
            this.btnDelEmp.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDelEmp.OnIdleState.ForeColor = System.Drawing.Color.Navy;
            this.btnDelEmp.OnIdleState.IconLeftImage = null;
            this.btnDelEmp.OnIdleState.IconRightImage = null;
            this.btnDelEmp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDelEmp.OnPressedState.BorderRadius = 25;
            this.btnDelEmp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelEmp.OnPressedState.BorderThickness = 1;
            this.btnDelEmp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDelEmp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelEmp.OnPressedState.IconLeftImage = null;
            this.btnDelEmp.OnPressedState.IconRightImage = null;
            this.btnDelEmp.Size = new System.Drawing.Size(150, 39);
            this.btnDelEmp.TabIndex = 7;
            this.btnDelEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelEmp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelEmp.TextMarginLeft = 0;
            this.btnDelEmp.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelEmp.UseDefaultRadiusAndThickness = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.AllowAnimations = true;
            this.btnAddEmp.AllowMouseEffects = true;
            this.btnAddEmp.AllowToggling = false;
            this.btnAddEmp.AnimationSpeed = 200;
            this.btnAddEmp.AutoGenerateColors = false;
            this.btnAddEmp.AutoRoundBorders = false;
            this.btnAddEmp.AutoSizeLeftIcon = true;
            this.btnAddEmp.AutoSizeRightIcon = true;
            this.btnAddEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAddEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddEmp.BackgroundImage")));
            this.btnAddEmp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddEmp.ButtonText = "Add Visit";
            this.btnAddEmp.ButtonTextMarginLeft = 0;
            this.btnAddEmp.ColorContrastOnClick = 45;
            this.btnAddEmp.ColorContrastOnHover = 45;
            this.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddEmp.CustomizableEdges = borderEdges3;
            this.btnAddEmp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddEmp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddEmp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddEmp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddEmp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.Navy;
            this.btnAddEmp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddEmp.IconMarginLeft = 11;
            this.btnAddEmp.IconPadding = 10;
            this.btnAddEmp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddEmp.IconSize = 25;
            this.btnAddEmp.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAddEmp.IdleBorderRadius = 25;
            this.btnAddEmp.IdleBorderThickness = 1;
            this.btnAddEmp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAddEmp.IdleIconLeftImage = null;
            this.btnAddEmp.IdleIconRightImage = null;
            this.btnAddEmp.IndicateFocus = false;
            this.btnAddEmp.Location = new System.Drawing.Point(136, 474);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddEmp.OnDisabledState.BorderRadius = 25;
            this.btnAddEmp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddEmp.OnDisabledState.BorderThickness = 1;
            this.btnAddEmp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddEmp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddEmp.OnDisabledState.IconLeftImage = null;
            this.btnAddEmp.OnDisabledState.IconRightImage = null;
            this.btnAddEmp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnAddEmp.onHoverState.BorderRadius = 25;
            this.btnAddEmp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddEmp.onHoverState.BorderThickness = 1;
            this.btnAddEmp.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAddEmp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.onHoverState.IconLeftImage = null;
            this.btnAddEmp.onHoverState.IconRightImage = null;
            this.btnAddEmp.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddEmp.OnIdleState.BorderRadius = 25;
            this.btnAddEmp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddEmp.OnIdleState.BorderThickness = 1;
            this.btnAddEmp.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAddEmp.OnIdleState.ForeColor = System.Drawing.Color.Navy;
            this.btnAddEmp.OnIdleState.IconLeftImage = null;
            this.btnAddEmp.OnIdleState.IconRightImage = null;
            this.btnAddEmp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddEmp.OnPressedState.BorderRadius = 25;
            this.btnAddEmp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddEmp.OnPressedState.BorderThickness = 1;
            this.btnAddEmp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.btnAddEmp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.OnPressedState.IconLeftImage = null;
            this.btnAddEmp.OnPressedState.IconRightImage = null;
            this.btnAddEmp.Size = new System.Drawing.Size(150, 39);
            this.btnAddEmp.TabIndex = 5;
            this.btnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddEmp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddEmp.TextMarginLeft = 0;
            this.btnAddEmp.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddEmp.UseDefaultRadiusAndThickness = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(745, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // frmVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisits";
            this.Text = "frmVisits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateEmp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelEmp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}