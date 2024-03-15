namespace app
{
    partial class SummaryFR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryFR));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.income = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.expense = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.Profit = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.percentageincome = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.percentageexpense = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel6 = new Bunifu.UI.WinForms.BunifuPanel();
            this.percentageprofit = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.options = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel14 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.getbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel5.SuspendLayout();
            this.bunifuPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 26;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(1, 0);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(52, 52);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel2.BorderRadius = 25;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.income);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel2.Location = new System.Drawing.Point(190, 205);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(200, 100);
            this.bunifuPanel2.TabIndex = 5;
            // 
            // income
            // 
            this.income.AllowParentOverrides = false;
            this.income.AutoEllipsis = false;
            this.income.Cursor = System.Windows.Forms.Cursors.Default;
            this.income.CursorType = System.Windows.Forms.Cursors.Default;
            this.income.Font = new System.Drawing.Font("Roboto Slab Medium", 30F, System.Drawing.FontStyle.Bold);
            this.income.Location = new System.Drawing.Point(43, 39);
            this.income.Name = "income";
            this.income.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.income.Size = new System.Drawing.Size(101, 54);
            this.income.TabIndex = 1;
            this.income.Text = "$00.0";
            this.income.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.income.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Roboto Slab Medium", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(32, 4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(125, 27);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "Total Income";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.expense);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel1.Location = new System.Drawing.Point(414, 205);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(200, 100);
            this.bunifuPanel1.TabIndex = 6;
            // 
            // expense
            // 
            this.expense.AllowParentOverrides = false;
            this.expense.AutoEllipsis = false;
            this.expense.Cursor = System.Windows.Forms.Cursors.Default;
            this.expense.CursorType = System.Windows.Forms.Cursors.Default;
            this.expense.Font = new System.Drawing.Font("Roboto Slab Medium", 30F, System.Drawing.FontStyle.Bold);
            this.expense.Location = new System.Drawing.Point(43, 39);
            this.expense.Name = "expense";
            this.expense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expense.Size = new System.Drawing.Size(101, 54);
            this.expense.TabIndex = 1;
            this.expense.Text = "$00.0";
            this.expense.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.expense.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Roboto Slab Medium", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.Location = new System.Drawing.Point(32, 4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(134, 27);
            this.bunifuLabel5.TabIndex = 0;
            this.bunifuLabel5.Text = "Total Expense";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel3.BorderRadius = 25;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.Profit);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel7);
            this.bunifuPanel3.Location = new System.Drawing.Point(638, 205);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(200, 100);
            this.bunifuPanel3.TabIndex = 7;
            // 
            // Profit
            // 
            this.Profit.AllowParentOverrides = false;
            this.Profit.AutoEllipsis = false;
            this.Profit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Profit.CursorType = System.Windows.Forms.Cursors.Default;
            this.Profit.Font = new System.Drawing.Font("Roboto Slab Medium", 30F, System.Drawing.FontStyle.Bold);
            this.Profit.Location = new System.Drawing.Point(43, 39);
            this.Profit.Name = "Profit";
            this.Profit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Profit.Size = new System.Drawing.Size(101, 54);
            this.Profit.TabIndex = 1;
            this.Profit.Text = "$00.0";
            this.Profit.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Profit.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.Font = new System.Drawing.Font("Roboto Slab Medium", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel7.Location = new System.Drawing.Point(52, 4);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(92, 27);
            this.bunifuLabel7.TabIndex = 0;
            this.bunifuLabel7.Text = "Net Profit";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel4.BorderRadius = 25;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.percentageincome);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel9);
            this.bunifuPanel4.Location = new System.Drawing.Point(190, 330);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(200, 100);
            this.bunifuPanel4.TabIndex = 8;
            // 
            // percentageincome
            // 
            this.percentageincome.AllowParentOverrides = false;
            this.percentageincome.AutoEllipsis = false;
            this.percentageincome.Cursor = System.Windows.Forms.Cursors.Default;
            this.percentageincome.CursorType = System.Windows.Forms.Cursors.Default;
            this.percentageincome.Font = new System.Drawing.Font("Roboto Slab Medium", 30F, System.Drawing.FontStyle.Bold);
            this.percentageincome.Location = new System.Drawing.Point(56, 34);
            this.percentageincome.Name = "percentageincome";
            this.percentageincome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.percentageincome.Size = new System.Drawing.Size(91, 54);
            this.percentageincome.TabIndex = 1;
            this.percentageincome.Text = "100%";
            this.percentageincome.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.percentageincome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.Font = new System.Drawing.Font("Roboto Slab Medium", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel9.Location = new System.Drawing.Point(15, 3);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(169, 23);
            this.bunifuLabel9.TabIndex = 0;
            this.bunifuLabel9.Text = "% Increase in Income";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel5.BorderRadius = 25;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Controls.Add(this.percentageexpense);
            this.bunifuPanel5.Controls.Add(this.bunifuLabel11);
            this.bunifuPanel5.Location = new System.Drawing.Point(414, 330);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(200, 100);
            this.bunifuPanel5.TabIndex = 9;
            // 
            // percentageexpense
            // 
            this.percentageexpense.AllowParentOverrides = false;
            this.percentageexpense.AutoEllipsis = false;
            this.percentageexpense.Cursor = System.Windows.Forms.Cursors.Default;
            this.percentageexpense.CursorType = System.Windows.Forms.Cursors.Default;
            this.percentageexpense.Font = new System.Drawing.Font("Roboto Slab Medium", 30F, System.Drawing.FontStyle.Bold);
            this.percentageexpense.Location = new System.Drawing.Point(56, 34);
            this.percentageexpense.Name = "percentageexpense";
            this.percentageexpense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.percentageexpense.Size = new System.Drawing.Size(91, 54);
            this.percentageexpense.TabIndex = 1;
            this.percentageexpense.Text = "100%";
            this.percentageexpense.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.percentageexpense.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.Font = new System.Drawing.Font("Roboto Slab Medium", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel11.Location = new System.Drawing.Point(11, 3);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(179, 23);
            this.bunifuLabel11.TabIndex = 0;
            this.bunifuLabel11.Text = "% Increase in Expense";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel6
            // 
            this.bunifuPanel6.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel6.BackgroundImage")));
            this.bunifuPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel6.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel6.BorderRadius = 25;
            this.bunifuPanel6.BorderThickness = 1;
            this.bunifuPanel6.Controls.Add(this.percentageprofit);
            this.bunifuPanel6.Controls.Add(this.bunifuLabel13);
            this.bunifuPanel6.Location = new System.Drawing.Point(638, 333);
            this.bunifuPanel6.Name = "bunifuPanel6";
            this.bunifuPanel6.ShowBorders = true;
            this.bunifuPanel6.Size = new System.Drawing.Size(200, 100);
            this.bunifuPanel6.TabIndex = 10;
            // 
            // percentageprofit
            // 
            this.percentageprofit.AllowParentOverrides = false;
            this.percentageprofit.AutoEllipsis = false;
            this.percentageprofit.Cursor = System.Windows.Forms.Cursors.Default;
            this.percentageprofit.CursorType = System.Windows.Forms.Cursors.Default;
            this.percentageprofit.Font = new System.Drawing.Font("Roboto Slab Medium", 30F, System.Drawing.FontStyle.Bold);
            this.percentageprofit.Location = new System.Drawing.Point(56, 34);
            this.percentageprofit.Name = "percentageprofit";
            this.percentageprofit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.percentageprofit.Size = new System.Drawing.Size(91, 54);
            this.percentageprofit.TabIndex = 1;
            this.percentageprofit.Text = "100%";
            this.percentageprofit.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.percentageprofit.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel13.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel13.Font = new System.Drawing.Font("Roboto Slab Medium", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel13.Location = new System.Drawing.Point(15, 3);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(153, 23);
            this.bunifuLabel13.TabIndex = 0;
            this.bunifuLabel13.Text = "% Increase in Profit";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.BackgroundColor = System.Drawing.Color.White;
            this.options.BorderColor = System.Drawing.Color.Black;
            this.options.BorderRadius = 10;
            this.options.Color = System.Drawing.Color.Black;
            this.options.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.options.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.options.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.options.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.options.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.options.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.options.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.options.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.options.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.options.FillDropDown = true;
            this.options.FillIndicator = false;
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.Black;
            this.options.FormattingEnabled = true;
            this.options.Icon = null;
            this.options.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.options.IndicatorColor = System.Drawing.Color.Gray;
            this.options.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.options.ItemBackColor = System.Drawing.Color.White;
            this.options.ItemBorderColor = System.Drawing.Color.White;
            this.options.ItemForeColor = System.Drawing.Color.Black;
            this.options.ItemHeight = 26;
            this.options.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.options.ItemHighLightForeColor = System.Drawing.Color.White;
            this.options.ItemTopMargin = 3;
            this.options.Location = new System.Drawing.Point(417, 125);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(260, 32);
            this.options.TabIndex = 14;
            this.options.Text = null;
            this.options.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.options.TextLeftMargin = 5;
            // 
            // bunifuLabel14
            // 
            this.bunifuLabel14.AllowParentOverrides = false;
            this.bunifuLabel14.AutoEllipsis = false;
            this.bunifuLabel14.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel14.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel14.Font = new System.Drawing.Font("Roboto Slab Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel14.Location = new System.Drawing.Point(282, 129);
            this.bunifuLabel14.Name = "bunifuLabel14";
            this.bunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel14.Size = new System.Drawing.Size(120, 26);
            this.bunifuLabel14.TabIndex = 13;
            this.bunifuLabel14.Text = "Select Month";
            this.bunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Summary Finance Report";
            // 
            // getbtn
            // 
            this.getbtn.AllowAnimations = true;
            this.getbtn.AllowMouseEffects = true;
            this.getbtn.AllowToggling = false;
            this.getbtn.AnimationSpeed = 200;
            this.getbtn.AutoGenerateColors = false;
            this.getbtn.AutoRoundBorders = false;
            this.getbtn.AutoSizeLeftIcon = true;
            this.getbtn.AutoSizeRightIcon = true;
            this.getbtn.BackColor = System.Drawing.Color.Transparent;
            this.getbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.getbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getbtn.BackgroundImage")));
            this.getbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.getbtn.ButtonText = "Get Summary";
            this.getbtn.ButtonTextMarginLeft = 0;
            this.getbtn.ColorContrastOnClick = 45;
            this.getbtn.ColorContrastOnHover = 45;
            this.getbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.getbtn.CustomizableEdges = borderEdges1;
            this.getbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.getbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.getbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.getbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.getbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.getbtn.Font = new System.Drawing.Font("Roboto Slab Medium", 14F, System.Drawing.FontStyle.Bold);
            this.getbtn.ForeColor = System.Drawing.Color.White;
            this.getbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.getbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.getbtn.IconMarginLeft = 11;
            this.getbtn.IconPadding = 10;
            this.getbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.getbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.getbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.getbtn.IconSize = 25;
            this.getbtn.IdleBorderColor = System.Drawing.Color.Black;
            this.getbtn.IdleBorderRadius = 30;
            this.getbtn.IdleBorderThickness = 1;
            this.getbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.getbtn.IdleIconLeftImage = null;
            this.getbtn.IdleIconRightImage = null;
            this.getbtn.IndicateFocus = false;
            this.getbtn.Location = new System.Drawing.Point(689, 122);
            this.getbtn.Name = "getbtn";
            this.getbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.getbtn.OnDisabledState.BorderRadius = 30;
            this.getbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.getbtn.OnDisabledState.BorderThickness = 1;
            this.getbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.getbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.getbtn.OnDisabledState.IconLeftImage = null;
            this.getbtn.OnDisabledState.IconRightImage = null;
            this.getbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.getbtn.onHoverState.BorderRadius = 30;
            this.getbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.getbtn.onHoverState.BorderThickness = 1;
            this.getbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.getbtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.getbtn.onHoverState.IconLeftImage = null;
            this.getbtn.onHoverState.IconRightImage = null;
            this.getbtn.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.getbtn.OnIdleState.BorderRadius = 30;
            this.getbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.getbtn.OnIdleState.BorderThickness = 1;
            this.getbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.getbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.getbtn.OnIdleState.IconLeftImage = null;
            this.getbtn.OnIdleState.IconRightImage = null;
            this.getbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.getbtn.OnPressedState.BorderRadius = 30;
            this.getbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.getbtn.OnPressedState.BorderThickness = 1;
            this.getbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.getbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.getbtn.OnPressedState.IconLeftImage = null;
            this.getbtn.OnPressedState.IconRightImage = null;
            this.getbtn.Size = new System.Drawing.Size(150, 39);
            this.getbtn.TabIndex = 16;
            this.getbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.getbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.getbtn.TextMarginLeft = 0;
            this.getbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.getbtn.UseDefaultRadiusAndThickness = true;
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // SummaryFR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1058, 463);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.options);
            this.Controls.Add(this.bunifuLabel14);
            this.Controls.Add(this.bunifuPanel6);
            this.Controls.Add(this.bunifuPanel5);
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SummaryFR";
            this.Text = "SummaryFR";
            this.Load += new System.EventHandler(this.SummaryFR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.bunifuPanel5.ResumeLayout(false);
            this.bunifuPanel5.PerformLayout();
            this.bunifuPanel6.ResumeLayout(false);
            this.bunifuPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel income;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel expense;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel Profit;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuLabel percentageincome;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private Bunifu.UI.WinForms.BunifuLabel percentageexpense;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel6;
        private Bunifu.UI.WinForms.BunifuLabel percentageprofit;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private Bunifu.UI.WinForms.BunifuDropdown options;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel14;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton getbtn;
    }
}