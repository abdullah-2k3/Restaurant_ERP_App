namespace app
{
    partial class Status_tbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status_tbl));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.idbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.statusdrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.updatebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 14;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(5, 4);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(29, 29);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 71;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Roboto Slab Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(138, 113);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(87, 28);
            this.bunifuLabel1.TabIndex = 73;
            this.bunifuLabel1.Text = "Table ID:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Roboto Slab Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(444, 113);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(70, 28);
            this.bunifuLabel2.TabIndex = 74;
            this.bunifuLabel2.Text = "Status:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // idbox
            // 
            this.idbox.AcceptsReturn = false;
            this.idbox.AcceptsTab = false;
            this.idbox.AnimationSpeed = 200;
            this.idbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.idbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.idbox.BackColor = System.Drawing.Color.Transparent;
            this.idbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("idbox.BackgroundImage")));
            this.idbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.idbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.idbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.idbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.idbox.BorderRadius = 12;
            this.idbox.BorderThickness = 1;
            this.idbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.idbox.DefaultText = "";
            this.idbox.FillColor = System.Drawing.Color.White;
            this.idbox.HideSelection = true;
            this.idbox.IconLeft = null;
            this.idbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.idbox.IconPadding = 10;
            this.idbox.IconRight = null;
            this.idbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.idbox.Lines = new string[0];
            this.idbox.Location = new System.Drawing.Point(232, 111);
            this.idbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idbox.MaxLength = 32767;
            this.idbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.idbox.Modified = false;
            this.idbox.Multiline = false;
            this.idbox.Name = "idbox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.idbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.idbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.idbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.idbox.OnIdleState = stateProperties4;
            this.idbox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idbox.PasswordChar = '\0';
            this.idbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.idbox.PlaceholderText = "Enter table id";
            this.idbox.ReadOnly = false;
            this.idbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idbox.SelectedText = "";
            this.idbox.SelectionLength = 0;
            this.idbox.SelectionStart = 0;
            this.idbox.ShortcutsEnabled = true;
            this.idbox.Size = new System.Drawing.Size(180, 34);
            this.idbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.idbox.TabIndex = 75;
            this.idbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idbox.TextMarginBottom = 0;
            this.idbox.TextMarginLeft = 3;
            this.idbox.TextMarginTop = 0;
            this.idbox.TextPlaceholder = "Enter table id";
            this.idbox.UseSystemPasswordChar = false;
            this.idbox.WordWrap = true;
            // 
            // statusdrop
            // 
            this.statusdrop.BackColor = System.Drawing.Color.Transparent;
            this.statusdrop.BackgroundColor = System.Drawing.Color.White;
            this.statusdrop.BorderColor = System.Drawing.Color.Silver;
            this.statusdrop.BorderRadius = 1;
            this.statusdrop.Color = System.Drawing.Color.Silver;
            this.statusdrop.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.statusdrop.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusdrop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.statusdrop.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusdrop.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.statusdrop.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.statusdrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusdrop.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.statusdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusdrop.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.statusdrop.FillDropDown = true;
            this.statusdrop.FillIndicator = false;
            this.statusdrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusdrop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusdrop.ForeColor = System.Drawing.Color.Black;
            this.statusdrop.FormattingEnabled = true;
            this.statusdrop.Icon = null;
            this.statusdrop.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.statusdrop.IndicatorColor = System.Drawing.Color.Gray;
            this.statusdrop.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.statusdrop.ItemBackColor = System.Drawing.Color.White;
            this.statusdrop.ItemBorderColor = System.Drawing.Color.White;
            this.statusdrop.ItemForeColor = System.Drawing.Color.Black;
            this.statusdrop.ItemHeight = 26;
            this.statusdrop.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.statusdrop.ItemHighLightForeColor = System.Drawing.Color.White;
            this.statusdrop.Items.AddRange(new object[] {
            "vacant",
            "occupied",
            "reserved",
            "being cleaned"});
            this.statusdrop.ItemTopMargin = 3;
            this.statusdrop.Location = new System.Drawing.Point(525, 111);
            this.statusdrop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusdrop.Name = "statusdrop";
            this.statusdrop.Size = new System.Drawing.Size(175, 32);
            this.statusdrop.TabIndex = 76;
            this.statusdrop.Text = null;
            this.statusdrop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.statusdrop.TextLeftMargin = 5;
            this.statusdrop.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(986, 268);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // updatebtn
            // 
            this.updatebtn.AllowAnimations = true;
            this.updatebtn.AllowMouseEffects = true;
            this.updatebtn.AllowToggling = false;
            this.updatebtn.AnimationSpeed = 200;
            this.updatebtn.AutoGenerateColors = false;
            this.updatebtn.AutoRoundBorders = false;
            this.updatebtn.AutoSizeLeftIcon = true;
            this.updatebtn.AutoSizeRightIcon = true;
            this.updatebtn.BackColor = System.Drawing.Color.Transparent;
            this.updatebtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.ButtonText = "Update Status";
            this.updatebtn.ButtonTextMarginLeft = 0;
            this.updatebtn.ColorContrastOnClick = 45;
            this.updatebtn.ColorContrastOnHover = 45;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.updatebtn.CustomizableEdges = borderEdges1;
            this.updatebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updatebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updatebtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updatebtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updatebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.updatebtn.Font = new System.Drawing.Font("Roboto Slab Medium", 12.75F, System.Drawing.FontStyle.Bold);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.updatebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.updatebtn.IconMarginLeft = 11;
            this.updatebtn.IconPadding = 10;
            this.updatebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.updatebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.updatebtn.IconSize = 25;
            this.updatebtn.IdleBorderColor = System.Drawing.Color.Black;
            this.updatebtn.IdleBorderRadius = 35;
            this.updatebtn.IdleBorderThickness = 1;
            this.updatebtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updatebtn.IdleIconLeftImage = null;
            this.updatebtn.IdleIconRightImage = null;
            this.updatebtn.IndicateFocus = false;
            this.updatebtn.Location = new System.Drawing.Point(748, 108);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updatebtn.OnDisabledState.BorderRadius = 35;
            this.updatebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.OnDisabledState.BorderThickness = 1;
            this.updatebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updatebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updatebtn.OnDisabledState.IconLeftImage = null;
            this.updatebtn.OnDisabledState.IconRightImage = null;
            this.updatebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updatebtn.onHoverState.BorderRadius = 35;
            this.updatebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.onHoverState.BorderThickness = 1;
            this.updatebtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updatebtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.updatebtn.onHoverState.IconLeftImage = null;
            this.updatebtn.onHoverState.IconRightImage = null;
            this.updatebtn.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.updatebtn.OnIdleState.BorderRadius = 35;
            this.updatebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.OnIdleState.BorderThickness = 1;
            this.updatebtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updatebtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.updatebtn.OnIdleState.IconLeftImage = null;
            this.updatebtn.OnIdleState.IconRightImage = null;
            this.updatebtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.updatebtn.OnPressedState.BorderRadius = 35;
            this.updatebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.OnPressedState.BorderThickness = 1;
            this.updatebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.updatebtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.updatebtn.OnPressedState.IconLeftImage = null;
            this.updatebtn.OnPressedState.IconRightImage = null;
            this.updatebtn.Size = new System.Drawing.Size(157, 36);
            this.updatebtn.TabIndex = 78;
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.updatebtn.TextMarginLeft = 0;
            this.updatebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.updatebtn.UseDefaultRadiusAndThickness = true;
            this.updatebtn.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(415, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 45);
            this.label13.TabIndex = 106;
            this.label13.Text = "Table Status";
            // 
            // Status_tbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1058, 463);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusdrop);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Status_tbl";
            this.Text = "Status_tbl";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox idbox;
        private Bunifu.UI.WinForms.BunifuDropdown statusdrop;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updatebtn;
        private System.Windows.Forms.Label label13;
    }
}