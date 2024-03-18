namespace app
{
    partial class frmDelMenu
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
            this.btnAddExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblDelCust = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddExit
            // 
            this.btnAddExit.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddExit.Location = new System.Drawing.Point(279, 247);
            this.btnAddExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(118, 29);
            this.btnAddExit.TabIndex = 37;
            this.btnAddExit.Text = "Cancel";
            this.btnAddExit.UseVisualStyleBackColor = true;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.Location = new System.Drawing.Point(129, 247);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(118, 29);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(159, 175);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(194, 20);
            this.tbID.TabIndex = 35;
            // 
            // lblDelCust
            // 
            this.lblDelCust.AutoSize = true;
            this.lblDelCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelCust.ForeColor = System.Drawing.Color.Red;
            this.lblDelCust.Location = new System.Drawing.Point(176, 120);
            this.lblDelCust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelCust.Name = "lblDelCust";
            this.lblDelCust.Size = new System.Drawing.Size(154, 26);
            this.lblDelCust.TabIndex = 34;
            this.lblDelCust.Text = "Enter Item ID";
            // 
            // frmDelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 416);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblDelCust);
            this.Name = "frmDelMenu";
            this.Text = "frmDelMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblDelCust;
    }
}