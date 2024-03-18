namespace app
{
    partial class frmViewMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMenu));
            this.Brugers = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lstfastfood = new System.Windows.Forms.ListBox();
            this.lstJuices = new System.Windows.Forms.ListBox();
            this.lstDessert = new System.Windows.Forms.ListBox();
            this.lstDesi = new System.Windows.Forms.ListBox();
            this.lstContinental = new System.Windows.Forms.ListBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lstfastprice = new System.Windows.Forms.ListBox();
            this.lstdessertprice = new System.Windows.Forms.ListBox();
            this.lstDesiPrice = new System.Windows.Forms.ListBox();
            this.lstContPrice = new System.Windows.Forms.ListBox();
            this.lstjuicesprice = new System.Windows.Forms.ListBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // Brugers
            // 
            this.Brugers.AllowParentOverrides = false;
            this.Brugers.AutoEllipsis = true;
            this.Brugers.AutoSize = false;
            this.Brugers.AutoSizeHeightOnly = true;
            this.Brugers.Cursor = System.Windows.Forms.Cursors.Default;
            this.Brugers.CursorType = System.Windows.Forms.Cursors.Default;
            this.Brugers.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brugers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Brugers.Location = new System.Drawing.Point(53, 12);
            this.Brugers.Name = "Brugers";
            this.Brugers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Brugers.Size = new System.Drawing.Size(101, 30);
            this.Brugers.TabIndex = 7;
            this.Brugers.Text = "Fast Food";
            this.Brugers.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Brugers.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Brugers.Click += new System.EventHandler(this.Brugers_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = true;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(469, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(115, 30);
            this.bunifuLabel1.TabIndex = 8;
            this.bunifuLabel1.Text = "Desi Cusine";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = true;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 300);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(79, 30);
            this.bunifuLabel2.TabIndex = 9;
            this.bunifuLabel2.Text = "Dessert";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lstfastfood
            // 
            this.lstfastfood.BackColor = System.Drawing.Color.DimGray;
            this.lstfastfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstfastfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstfastfood.ForeColor = System.Drawing.Color.DarkRed;
            this.lstfastfood.FormattingEnabled = true;
            this.lstfastfood.ItemHeight = 20;
            this.lstfastfood.Items.AddRange(new object[] {
            "Burgers\t\t\t",
            "Chicken Nuggets",
            "French Fries",
            "Chicken Sandwich",
            "Pizza ",
            "Burrito",
            "Fried Chicken ",
            "Chicken Tenders",
            "Onion Rings",
            "Egg Rolls"});
            this.lstfastfood.Location = new System.Drawing.Point(45, 48);
            this.lstfastfood.Name = "lstfastfood";
            this.lstfastfood.Size = new System.Drawing.Size(268, 242);
            this.lstfastfood.TabIndex = 11;
            this.lstfastfood.SelectedIndexChanged += new System.EventHandler(this.lstfastfood_SelectedIndexChanged);
            // 
            // lstJuices
            // 
            this.lstJuices.BackColor = System.Drawing.Color.DimGray;
            this.lstJuices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstJuices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJuices.ForeColor = System.Drawing.Color.DarkRed;
            this.lstJuices.FormattingEnabled = true;
            this.lstJuices.ItemHeight = 20;
            this.lstJuices.Items.AddRange(new object[] {
            "Orange Juice",
            "Apple Juice",
            "Cranberry Juice",
            "Grape Juice",
            "Pineapple Juice",
            "Mango Juice",
            "Watermelon Juice",
            "Coconut Water ",
            "Seasonal Juice"});
            this.lstJuices.Location = new System.Drawing.Point(230, 336);
            this.lstJuices.Name = "lstJuices";
            this.lstJuices.Size = new System.Drawing.Size(148, 202);
            this.lstJuices.TabIndex = 13;
            // 
            // lstDessert
            // 
            this.lstDessert.BackColor = System.Drawing.Color.DimGray;
            this.lstDessert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDessert.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lstDessert.FormattingEnabled = true;
            this.lstDessert.ItemHeight = 20;
            this.lstDessert.Items.AddRange(new object[] {
            "Sundae",
            "Milkshake",
            "Ice Cream Cone",
            "Brownie",
            "Cookie",
            "Apple Pie",
            "Cheesecake ",
            "Donut ",
            "Cupcake ",
            "Muffin"});
            this.lstDessert.Location = new System.Drawing.Point(12, 336);
            this.lstDessert.Name = "lstDessert";
            this.lstDessert.Size = new System.Drawing.Size(142, 202);
            this.lstDessert.TabIndex = 14;
            // 
            // lstDesi
            // 
            this.lstDesi.BackColor = System.Drawing.Color.DimGray;
            this.lstDesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesi.ForeColor = System.Drawing.Color.DarkRed;
            this.lstDesi.FormattingEnabled = true;
            this.lstDesi.ItemHeight = 20;
            this.lstDesi.Items.AddRange(new object[] {
            "Biryani",
            "Karahi Chicken",
            "Seekh Kebab",
            "Nihari",
            "Chicken Tikka",
            "Haleem",
            "Chapli Kebab",
            "Aloo Gosht ",
            "Daal Chawal ",
            "Chicken Handi",
            "Rogan Josh",
            "Saag ",
            "Chicken Korma",
            "Chicken Karahi",
            "Mutton Pulao",
            "Keema",
            "Bhindi Gosht",
            "Mutton Kunna",
            "Daal Makhani",
            "Chicken Malai Boti",
            "Reshmi Kebab",
            "Tandoori Roti",
            "Bhuna Gosht",
            "Chicken Bihari"});
            this.lstDesi.Location = new System.Drawing.Point(469, 48);
            this.lstDesi.Name = "lstDesi";
            this.lstDesi.Size = new System.Drawing.Size(165, 482);
            this.lstDesi.TabIndex = 16;
            // 
            // lstContinental
            // 
            this.lstContinental.BackColor = System.Drawing.Color.DimGray;
            this.lstContinental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstContinental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContinental.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lstContinental.FormattingEnabled = true;
            this.lstContinental.ItemHeight = 20;
            this.lstContinental.Items.AddRange(new object[] {
            "Spaghetti Bolognese",
            "Beef Stroganoff",
            "Chicken Alfredo Pasta",
            "Fish and Chips",
            "Vegetable Lasagna",
            "Mushroom Risotto",
            "Chicken Fajitas",
            "Beef Steak",
            "Salad",
            "Beef Tacos",
            "Beef Chili",
            "Cheesecake"});
            this.lstContinental.Location = new System.Drawing.Point(767, 48);
            this.lstContinental.Name = "lstContinental";
            this.lstContinental.Size = new System.Drawing.Size(185, 262);
            this.lstContinental.TabIndex = 17;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = true;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuLabel4.Location = new System.Drawing.Point(741, 313);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(198, 55);
            this.bunifuLabel4.TabIndex = 18;
            this.bunifuLabel4.Text = "Feel free";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = true;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(741, 366);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(149, 37);
            this.bunifuLabel5.TabIndex = 19;
            this.bunifuLabel5.Text = "To Ask Us";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = true;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuLabel6.Location = new System.Drawing.Point(741, 398);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(235, 37);
            this.bunifuLabel6.TabIndex = 20;
            this.bunifuLabel6.Text = "About our Daily";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = true;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel7.Location = new System.Drawing.Point(786, 457);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(251, 73);
            this.bunifuLabel7.TabIndex = 21;
            this.bunifuLabel7.Text = "Specials";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = true;
            this.bunifuLabel8.AutoSize = false;
            this.bunifuLabel8.AutoSizeHeightOnly = true;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel8.Location = new System.Drawing.Point(253, 300);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(101, 30);
            this.bunifuLabel8.TabIndex = 22;
            this.bunifuLabel8.Text = "Juices";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = true;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel9.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuLabel9.Location = new System.Drawing.Point(767, 12);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(185, 30);
            this.bunifuLabel9.TabIndex = 23;
            this.bunifuLabel9.Text = " Continental Cusine";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.AllowParentOverrides = false;
            this.bunifuLabel12.AutoEllipsis = true;
            this.bunifuLabel12.AutoSize = false;
            this.bunifuLabel12.AutoSizeHeightOnly = true;
            this.bunifuLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel12.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel12.Location = new System.Drawing.Point(651, 12);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(59, 30);
            this.bunifuLabel12.TabIndex = 32;
            this.bunifuLabel12.Text = "Price";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lstfastprice
            // 
            this.lstfastprice.BackColor = System.Drawing.Color.DimGray;
            this.lstfastprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstfastprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstfastprice.ForeColor = System.Drawing.Color.DarkRed;
            this.lstfastprice.FormattingEnabled = true;
            this.lstfastprice.ItemHeight = 20;
            this.lstfastprice.Items.AddRange(new object[] {
            ""});
            this.lstfastprice.Location = new System.Drawing.Point(319, 52);
            this.lstfastprice.Name = "lstfastprice";
            this.lstfastprice.Size = new System.Drawing.Size(68, 242);
            this.lstfastprice.TabIndex = 24;
            this.lstfastprice.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstdessertprice
            // 
            this.lstdessertprice.BackColor = System.Drawing.Color.DimGray;
            this.lstdessertprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstdessertprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstdessertprice.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lstdessertprice.FormattingEnabled = true;
            this.lstdessertprice.ItemHeight = 20;
            this.lstdessertprice.Items.AddRange(new object[] {
            " "});
            this.lstdessertprice.Location = new System.Drawing.Point(160, 336);
            this.lstdessertprice.Name = "lstdessertprice";
            this.lstdessertprice.Size = new System.Drawing.Size(64, 202);
            this.lstdessertprice.TabIndex = 25;
            // 
            // lstDesiPrice
            // 
            this.lstDesiPrice.BackColor = System.Drawing.Color.DimGray;
            this.lstDesiPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDesiPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesiPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lstDesiPrice.FormattingEnabled = true;
            this.lstDesiPrice.ItemHeight = 20;
            this.lstDesiPrice.Items.AddRange(new object[] {
            ""});
            this.lstDesiPrice.Location = new System.Drawing.Point(651, 48);
            this.lstDesiPrice.Name = "lstDesiPrice";
            this.lstDesiPrice.Size = new System.Drawing.Size(75, 482);
            this.lstDesiPrice.TabIndex = 26;
            // 
            // lstContPrice
            // 
            this.lstContPrice.BackColor = System.Drawing.Color.DimGray;
            this.lstContPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstContPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContPrice.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lstContPrice.FormattingEnabled = true;
            this.lstContPrice.ItemHeight = 20;
            this.lstContPrice.Items.AddRange(new object[] {
            ""});
            this.lstContPrice.Location = new System.Drawing.Point(958, 48);
            this.lstContPrice.Name = "lstContPrice";
            this.lstContPrice.Size = new System.Drawing.Size(66, 262);
            this.lstContPrice.TabIndex = 27;
            // 
            // lstjuicesprice
            // 
            this.lstjuicesprice.BackColor = System.Drawing.Color.DimGray;
            this.lstjuicesprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstjuicesprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstjuicesprice.ForeColor = System.Drawing.Color.DarkRed;
            this.lstjuicesprice.FormattingEnabled = true;
            this.lstjuicesprice.ItemHeight = 20;
            this.lstjuicesprice.Items.AddRange(new object[] {
            " "});
            this.lstjuicesprice.Location = new System.Drawing.Point(384, 336);
            this.lstjuicesprice.Name = "lstjuicesprice";
            this.lstjuicesprice.Size = new System.Drawing.Size(64, 202);
            this.lstjuicesprice.TabIndex = 28;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = true;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.AutoSizeHeightOnly = true;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(319, 12);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(59, 30);
            this.bunifuLabel3.TabIndex = 29;
            this.bunifuLabel3.Text = "Price";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = true;
            this.bunifuLabel10.AutoSize = false;
            this.bunifuLabel10.AutoSizeHeightOnly = true;
            this.bunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel10.Location = new System.Drawing.Point(384, 300);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(59, 30);
            this.bunifuLabel10.TabIndex = 30;
            this.bunifuLabel10.Text = "Price";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = true;
            this.bunifuLabel11.AutoSize = false;
            this.bunifuLabel11.AutoSizeHeightOnly = true;
            this.bunifuLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel11.Location = new System.Drawing.Point(160, 300);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(59, 30);
            this.bunifuLabel11.TabIndex = 31;
            this.bunifuLabel11.Text = "Price";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = true;
            this.bunifuLabel13.AutoSize = false;
            this.bunifuLabel13.AutoSizeHeightOnly = true;
            this.bunifuLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel13.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel13.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel13.Location = new System.Drawing.Point(958, 12);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(59, 30);
            this.bunifuLabel13.TabIndex = 33;
            this.bunifuLabel13.Text = "Price";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.Controls.Add(this.bunifuLabel13);
            this.Controls.Add(this.bunifuLabel12);
            this.Controls.Add(this.bunifuLabel11);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.lstjuicesprice);
            this.Controls.Add(this.lstContPrice);
            this.Controls.Add(this.lstDesiPrice);
            this.Controls.Add(this.lstdessertprice);
            this.Controls.Add(this.lstfastprice);
            this.Controls.Add(this.bunifuLabel9);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.lstContinental);
            this.Controls.Add(this.lstDesi);
            this.Controls.Add(this.lstDessert);
            this.Controls.Add(this.lstJuices);
            this.Controls.Add(this.lstfastfood);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.Brugers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel Brugers;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.ListBox lstfastfood;
        private System.Windows.Forms.ListBox lstJuices;
        private System.Windows.Forms.ListBox lstDessert;
        private System.Windows.Forms.ListBox lstDesi;
        private System.Windows.Forms.ListBox lstContinental;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel12;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListBox lstfastprice;
        private System.Windows.Forms.ListBox lstdessertprice;
        private System.Windows.Forms.ListBox lstDesiPrice;
        private System.Windows.Forms.ListBox lstContPrice;
        private System.Windows.Forms.ListBox lstjuicesprice;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
    }
}