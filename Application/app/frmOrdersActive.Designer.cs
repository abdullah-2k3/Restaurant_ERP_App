namespace app
{
    partial class frmOrdersActive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdersActive));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbItems = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbOrderStatus = new System.Windows.Forms.ComboBox();
            this.cbPayStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbItems
            // 
            this.tbItems.Location = new System.Drawing.Point(131, 124);
            this.tbItems.Name = "tbItems";
            this.tbItems.Size = new System.Drawing.Size(141, 20);
            this.tbItems.TabIndex = 66;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(131, 231);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(141, 20);
            this.tbAmount.TabIndex = 64;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(131, 74);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(141, 20);
            this.tbCustomerID.TabIndex = 62;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(131, 332);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(141, 20);
            this.tbDate.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "CustomerID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Items:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "OrderStatus:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "PaymentStatus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Date:";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(131, 21);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(141, 20);
            this.tbOrderID.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "OrderID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbPayStatus);
            this.panel1.Controls.Add(this.cbOrderStatus);
            this.panel1.Controls.Add(this.tbItems);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.tbCustomerID);
            this.panel1.Controls.Add(this.tbDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbOrderID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(36, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 373);
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 40);
            this.label1.TabIndex = 60;
            this.label1.Text = "Active Orders";
            // 
            // btnDel
            // 
            this.btnDel.AllowAnimations = true;
            this.btnDel.AllowMouseEffects = true;
            this.btnDel.AllowToggling = false;
            this.btnDel.AnimationSpeed = 200;
            this.btnDel.AutoGenerateColors = false;
            this.btnDel.AutoRoundBorders = false;
            this.btnDel.AutoSizeLeftIcon = true;
            this.btnDel.AutoSizeRightIcon = true;
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDel.ButtonText = "Delete Order";
            this.btnDel.ButtonTextMarginLeft = 0;
            this.btnDel.ColorContrastOnClick = 45;
            this.btnDel.ColorContrastOnHover = 45;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDel.CustomizableEdges = borderEdges1;
            this.btnDel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDel.IconMarginLeft = 11;
            this.btnDel.IconPadding = 10;
            this.btnDel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDel.IconSize = 25;
            this.btnDel.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnDel.IdleBorderRadius = 25;
            this.btnDel.IdleBorderThickness = 1;
            this.btnDel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.IdleIconLeftImage = null;
            this.btnDel.IdleIconRightImage = null;
            this.btnDel.IndicateFocus = false;
            this.btnDel.Location = new System.Drawing.Point(712, 481);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDel.OnDisabledState.BorderRadius = 25;
            this.btnDel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDel.OnDisabledState.BorderThickness = 1;
            this.btnDel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDel.OnDisabledState.IconLeftImage = null;
            this.btnDel.OnDisabledState.IconRightImage = null;
            this.btnDel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDel.onHoverState.BorderRadius = 25;
            this.btnDel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDel.onHoverState.BorderThickness = 1;
            this.btnDel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDel.onHoverState.IconLeftImage = null;
            this.btnDel.onHoverState.IconRightImage = null;
            this.btnDel.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDel.OnIdleState.BorderRadius = 25;
            this.btnDel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDel.OnIdleState.BorderThickness = 1;
            this.btnDel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDel.OnIdleState.IconLeftImage = null;
            this.btnDel.OnIdleState.IconRightImage = null;
            this.btnDel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDel.OnPressedState.BorderRadius = 25;
            this.btnDel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDel.OnPressedState.BorderThickness = 1;
            this.btnDel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDel.OnPressedState.IconLeftImage = null;
            this.btnDel.OnPressedState.IconRightImage = null;
            this.btnDel.Size = new System.Drawing.Size(159, 45);
            this.btnDel.TabIndex = 59;
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDel.TextMarginLeft = 0;
            this.btnDel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDel.UseDefaultRadiusAndThickness = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnUpdate.ButtonText = "Update Order";
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
            this.btnUpdate.Location = new System.Drawing.Point(451, 481);
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
            this.btnUpdate.Size = new System.Drawing.Size(159, 45);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextMarginLeft = 0;
            this.btnUpdate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpdate.UseDefaultRadiusAndThickness = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(366, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(672, 373);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.FormattingEnabled = true;
            this.cbOrderStatus.Items.AddRange(new object[] {
            "Active",
            "Completed"});
            this.cbOrderStatus.Location = new System.Drawing.Point(131, 171);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(141, 21);
            this.cbOrderStatus.TabIndex = 67;
            // 
            // cbPayStatus
            // 
            this.cbPayStatus.FormattingEnabled = true;
            this.cbPayStatus.Items.AddRange(new object[] {
            "Paid",
            "Not Paid"});
            this.cbPayStatus.Location = new System.Drawing.Point(131, 282);
            this.cbPayStatus.Name = "cbPayStatus";
            this.cbPayStatus.Size = new System.Drawing.Size(141, 21);
            this.cbPayStatus.TabIndex = 68;
            // 
            // frmOrdersActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdersActive";
            this.Text = "frmOrdersActive";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItems;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdate;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.ComboBox cbPayStatus;
    }
}