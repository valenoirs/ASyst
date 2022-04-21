namespace ASyst
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblEffectiveDay = new System.Windows.Forms.Label();
            this.txbEffectiveDay = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEffectiveDay
            // 
            this.lblEffectiveDay.AutoSize = true;
            this.lblEffectiveDay.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEffectiveDay.ForeColor = System.Drawing.Color.White;
            this.lblEffectiveDay.Location = new System.Drawing.Point(3, 4);
            this.lblEffectiveDay.Name = "lblEffectiveDay";
            this.lblEffectiveDay.Size = new System.Drawing.Size(94, 19);
            this.lblEffectiveDay.TabIndex = 0;
            this.lblEffectiveDay.Text = "Effective Day";
            // 
            // txbEffectiveDay
            // 
            this.txbEffectiveDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEffectiveDay.Font = new System.Drawing.Font("Calibri", 15F);
            this.txbEffectiveDay.Location = new System.Drawing.Point(133, 63);
            this.txbEffectiveDay.MaxLength = 2;
            this.txbEffectiveDay.Name = "txbEffectiveDay";
            this.txbEffectiveDay.Size = new System.Drawing.Size(85, 32);
            this.txbEffectiveDay.TabIndex = 1;
            this.txbEffectiveDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCalculate.Location = new System.Drawing.Point(133, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 27);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlNav.Controls.Add(this.btnExit);
            this.pnlNav.Controls.Add(this.lblEffectiveDay);
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(350, 25);
            this.pnlNav.TabIndex = 26;
            this.pnlNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(305, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 27);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbEffectiveDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_MouseDown);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEffectiveDay;
        private System.Windows.Forms.TextBox txbEffectiveDay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnExit;
    }
}