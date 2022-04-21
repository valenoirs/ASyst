namespace ASyst
{
    partial class AddNewFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFace));
            this.lblName = new System.Windows.Forms.Label();
            this.txbIDLabel = new System.Windows.Forms.TextBox();
            this.txbNameLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEffectiveDay = new System.Windows.Forms.Label();
            this.btnAddFace = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblName.Location = new System.Drawing.Point(12, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 19);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "NAME : ";
            // 
            // txbIDLabel
            // 
            this.txbIDLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.txbIDLabel.Location = new System.Drawing.Point(79, 94);
            this.txbIDLabel.Name = "txbIDLabel";
            this.txbIDLabel.Size = new System.Drawing.Size(180, 27);
            this.txbIDLabel.TabIndex = 27;
            // 
            // txbNameLabel
            // 
            this.txbNameLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.txbNameLabel.Location = new System.Drawing.Point(79, 52);
            this.txbNameLabel.Name = "txbNameLabel";
            this.txbNameLabel.Size = new System.Drawing.Size(180, 27);
            this.txbNameLabel.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID : ";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlNav.Controls.Add(this.btnExit);
            this.pnlNav.Controls.Add(this.lblEffectiveDay);
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(300, 25);
            this.pnlNav.TabIndex = 32;
            this.pnlNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(255, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 27);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEffectiveDay
            // 
            this.lblEffectiveDay.AutoSize = true;
            this.lblEffectiveDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectiveDay.ForeColor = System.Drawing.Color.White;
            this.lblEffectiveDay.Location = new System.Drawing.Point(3, 3);
            this.lblEffectiveDay.Name = "lblEffectiveDay";
            this.lblEffectiveDay.Size = new System.Drawing.Size(71, 19);
            this.lblEffectiveDay.TabIndex = 0;
            this.lblEffectiveDay.Text = "Add Face";
            // 
            // btnAddFace
            // 
            this.btnAddFace.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFace.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAddFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddFace.Location = new System.Drawing.Point(108, 139);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(85, 27);
            this.btnAddFace.TabIndex = 33;
            this.btnAddFace.Text = "Add Face";
            this.btnAddFace.UseVisualStyleBackColor = false;
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // AddNewFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnAddFace);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbIDLabel);
            this.Controls.Add(this.txbNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewFace";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNewFace_MouseDown);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbIDLabel;
        private System.Windows.Forms.TextBox txbNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEffectiveDay;
        private System.Windows.Forms.Button btnAddFace;
    }
}