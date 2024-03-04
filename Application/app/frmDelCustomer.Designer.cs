namespace app
{
    partial class frmDelCustomer
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
            this.lblDelCust = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnAddExit = new System.Windows.Forms.Button();
            this.btnDelCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDelCust
            // 
            this.lblDelCust.AutoSize = true;
            this.lblDelCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelCust.ForeColor = System.Drawing.Color.Red;
            this.lblDelCust.Location = new System.Drawing.Point(165, 95);
            this.lblDelCust.Name = "lblDelCust";
            this.lblDelCust.Size = new System.Drawing.Size(262, 32);
            this.lblDelCust.TabIndex = 26;
            this.lblDelCust.Text = "Enter Customer ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(196, 162);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(202, 22);
            this.tbID.TabIndex = 27;
            // 
            // btnAddExit
            // 
            this.btnAddExit.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAddExit.Location = new System.Drawing.Point(325, 234);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(157, 36);
            this.btnAddExit.TabIndex = 29;
            this.btnAddExit.Text = "Exit";
            this.btnAddExit.UseVisualStyleBackColor = true;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnDelCustomer
            // 
            this.btnDelCustomer.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelCustomer.Location = new System.Drawing.Point(123, 234);
            this.btnDelCustomer.Name = "btnDelCustomer";
            this.btnDelCustomer.Size = new System.Drawing.Size(157, 36);
            this.btnDelCustomer.TabIndex = 28;
            this.btnDelCustomer.Text = "Save";
            this.btnDelCustomer.UseVisualStyleBackColor = true;
            this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
            // 
            // frmDelCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 406);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.btnDelCustomer);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblDelCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDelCustomer";
            this.Text = "frmDelCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelCust;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnAddExit;
        private System.Windows.Forms.Button btnDelCustomer;
    }
}