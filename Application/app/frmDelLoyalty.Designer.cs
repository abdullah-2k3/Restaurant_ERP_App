namespace app
{
    partial class frmDelLoyalty
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
            this.btnDelCustomer = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblDelCust = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddExit
            // 
            this.btnAddExit.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddExit.Location = new System.Drawing.Point(250, 195);
            this.btnAddExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(118, 29);
            this.btnAddExit.TabIndex = 33;
            this.btnAddExit.Text = "Cancel";
            this.btnAddExit.UseVisualStyleBackColor = true;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnDelCustomer
            // 
            this.btnDelCustomer.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelCustomer.Location = new System.Drawing.Point(98, 195);
            this.btnDelCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelCustomer.Name = "btnDelCustomer";
            this.btnDelCustomer.Size = new System.Drawing.Size(118, 29);
            this.btnDelCustomer.TabIndex = 32;
            this.btnDelCustomer.Text = "Delete";
            this.btnDelCustomer.UseVisualStyleBackColor = true;
            this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(153, 136);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(152, 20);
            this.tbID.TabIndex = 31;
            // 
            // lblDelCust
            // 
            this.lblDelCust.AutoSize = true;
            this.lblDelCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelCust.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDelCust.Location = new System.Drawing.Point(124, 83);
            this.lblDelCust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelCust.Name = "lblDelCust";
            this.lblDelCust.Size = new System.Drawing.Size(210, 26);
            this.lblDelCust.TabIndex = 30;
            this.lblDelCust.Text = "Enter Customer ID";
            // 
            // frmDelLoyalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(462, 330);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.btnDelCustomer);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblDelCust);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDelLoyalty";
            this.Text = "frmDelLoyalty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddExit;
        private System.Windows.Forms.Button btnDelCustomer;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblDelCust;
    }
}