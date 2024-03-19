namespace app
{
    partial class frmEditMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditMenu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelItem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelItem
            // 
            this.btnDelItem.AllowAnimations = true;
            this.btnDelItem.AllowMouseEffects = true;
            this.btnDelItem.AllowToggling = false;
            this.btnDelItem.AnimationSpeed = 200;
            this.btnDelItem.AutoGenerateColors = false;
            this.btnDelItem.AutoRoundBorders = false;
            this.btnDelItem.AutoSizeLeftIcon = true;
            this.btnDelItem.AutoSizeRightIcon = true;
            this.btnDelItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDelItem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelItem.BackgroundImage")));
            this.btnDelItem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelItem.ButtonText = "Delete Item";
            this.btnDelItem.ButtonTextMarginLeft = 0;
            this.btnDelItem.ColorContrastOnClick = 45;
            this.btnDelItem.ColorContrastOnHover = 45;
            this.btnDelItem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDelItem.CustomizableEdges = borderEdges1;
            this.btnDelItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelItem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelItem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelItem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelItem.ForeColor = System.Drawing.Color.White;
            this.btnDelItem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelItem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelItem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelItem.IconMarginLeft = 11;
            this.btnDelItem.IconPadding = 10;
            this.btnDelItem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelItem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelItem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelItem.IconSize = 25;
            this.btnDelItem.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnDelItem.IdleBorderRadius = 25;
            this.btnDelItem.IdleBorderThickness = 1;
            this.btnDelItem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelItem.IdleIconLeftImage = null;
            this.btnDelItem.IdleIconRightImage = null;
            this.btnDelItem.IndicateFocus = false;
            this.btnDelItem.Location = new System.Drawing.Point(785, 454);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelItem.OnDisabledState.BorderRadius = 25;
            this.btnDelItem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelItem.OnDisabledState.BorderThickness = 1;
            this.btnDelItem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelItem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelItem.OnDisabledState.IconLeftImage = null;
            this.btnDelItem.OnDisabledState.IconRightImage = null;
            this.btnDelItem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelItem.onHoverState.BorderRadius = 25;
            this.btnDelItem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelItem.onHoverState.BorderThickness = 1;
            this.btnDelItem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelItem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelItem.onHoverState.IconLeftImage = null;
            this.btnDelItem.onHoverState.IconRightImage = null;
            this.btnDelItem.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelItem.OnIdleState.BorderRadius = 25;
            this.btnDelItem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelItem.OnIdleState.BorderThickness = 1;
            this.btnDelItem.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelItem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDelItem.OnIdleState.IconLeftImage = null;
            this.btnDelItem.OnIdleState.IconRightImage = null;
            this.btnDelItem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDelItem.OnPressedState.BorderRadius = 25;
            this.btnDelItem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelItem.OnPressedState.BorderThickness = 1;
            this.btnDelItem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDelItem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelItem.OnPressedState.IconLeftImage = null;
            this.btnDelItem.OnPressedState.IconRightImage = null;
            this.btnDelItem.Size = new System.Drawing.Size(166, 54);
            this.btnDelItem.TabIndex = 45;
            this.btnDelItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelItem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelItem.TextMarginLeft = 0;
            this.btnDelItem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelItem.UseDefaultRadiusAndThickness = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowAnimations = true;
            this.btnUpdate.AllowMouseEffects = true;
            this.btnUpdate.AllowToggling = false;
            this.btnUpdate.AnimationSpeed = 200;
            this.btnUpdate.AutoGenerateColors = false;
            this.btnUpdate.AutoRoundBorders = false;
            this.btnUpdate.AutoSizeLeftIcon = true;
            this.btnUpdate.AutoSizeRightIcon = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.ButtonText = "Update Item";
            this.btnUpdate.ButtonTextMarginLeft = 0;
            this.btnUpdate.ColorContrastOnClick = 45;
            this.btnUpdate.ColorContrastOnHover = 45;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnUpdate.CustomizableEdges = borderEdges2;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUpdate.IconMarginLeft = 11;
            this.btnUpdate.IconPadding = 10;
            this.btnUpdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.IdleBorderRadius = 25;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleIconLeftImage = null;
            this.btnUpdate.IdleIconRightImage = null;
            this.btnUpdate.IndicateFocus = false;
            this.btnUpdate.Location = new System.Drawing.Point(544, 454);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdate.OnDisabledState.BorderRadius = 25;
            this.btnUpdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnDisabledState.BorderThickness = 1;
            this.btnUpdate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdate.OnDisabledState.IconLeftImage = null;
            this.btnUpdate.OnDisabledState.IconRightImage = null;
            this.btnUpdate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnUpdate.onHoverState.BorderRadius = 25;
            this.btnUpdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.onHoverState.BorderThickness = 1;
            this.btnUpdate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnUpdate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.onHoverState.IconLeftImage = null;
            this.btnUpdate.onHoverState.IconRightImage = null;
            this.btnUpdate.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.OnIdleState.BorderRadius = 25;
            this.btnUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnIdleState.BorderThickness = 1;
            this.btnUpdate.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnIdleState.IconLeftImage = null;
            this.btnUpdate.OnIdleState.IconRightImage = null;
            this.btnUpdate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnUpdate.OnPressedState.BorderRadius = 25;
            this.btnUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnPressedState.BorderThickness = 1;
            this.btnUpdate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnUpdate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnPressedState.IconLeftImage = null;
            this.btnUpdate.OnPressedState.IconRightImage = null;
            this.btnUpdate.Size = new System.Drawing.Size(166, 54);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextMarginLeft = 0;
            this.btnUpdate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpdate.UseDefaultRadiusAndThickness = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Add Item";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges3;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleBorderRadius = 25;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(328, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 25;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.onHoverState.BorderRadius = 25;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.OnIdleState.BorderRadius = 25;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAdd.OnPressedState.BorderRadius = 25;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(166, 54);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowCustomTheming = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.Name = null;
            this.dataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(357, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 362);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(193, 278);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(113, 20);
            this.tbName.TabIndex = 50;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(193, 391);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(113, 20);
            this.tbPrice.TabIndex = 52;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(193, 212);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(113, 20);
            this.tbID.TabIndex = 49;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(80, 209);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 21);
            this.lblID.TabIndex = 53;
            this.lblID.Text = "Item ID";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPrice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(98, 390);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 21);
            this.lblPrice.TabIndex = 54;
            this.lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(66, 336);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 21);
            this.lblCategory.TabIndex = 55;
            this.lblCategory.Text = "Category";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 278);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 21);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 57;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Fast Food",
            "Desi",
            "Continental",
            "Dessert",
            "Juices"});
            this.cbCategory.Location = new System.Drawing.Point(193, 336);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(113, 21);
            this.cbCategory.TabIndex = 58;
            // 
            // frmEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditMenu";
            this.Text = "frmEditMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelItem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}