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
            this.btnAddFace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddNewFace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 14);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "NAME : ";
            // 
            // txbIDLabel
            // 
            this.txbIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDLabel.Location = new System.Drawing.Point(82, 71);
            this.txbIDLabel.Name = "txbIDLabel";
            this.txbIDLabel.Size = new System.Drawing.Size(180, 20);
            this.txbIDLabel.TabIndex = 27;
            // 
            // txbNameLabel
            // 
            this.txbNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameLabel.Location = new System.Drawing.Point(82, 42);
            this.txbNameLabel.Name = "txbNameLabel";
            this.txbNameLabel.Size = new System.Drawing.Size(180, 20);
            this.txbNameLabel.TabIndex = 26;
            // 
            // btnAddFace
            // 
            this.btnAddFace.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFace.Location = new System.Drawing.Point(100, 106);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(85, 24);
            this.btnAddFace.TabIndex = 28;
            this.btnAddFace.Text = "Add Face";
            this.btnAddFace.UseVisualStyleBackColor = true;
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID : ";
            // 
            // lblAddNewFace
            // 
            this.lblAddNewFace.AutoSize = true;
            this.lblAddNewFace.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewFace.Location = new System.Drawing.Point(27, 10);
            this.lblAddNewFace.Name = "lblAddNewFace";
            this.lblAddNewFace.Size = new System.Drawing.Size(120, 20);
            this.lblAddNewFace.TabIndex = 32;
            this.lblAddNewFace.Text = "AddNewFace";
            // 
            // AddNewFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.lblAddNewFace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbIDLabel);
            this.Controls.Add(this.txbNameLabel);
            this.Controls.Add(this.btnAddFace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewFace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbIDLabel;
        private System.Windows.Forms.TextBox txbNameLabel;
        private System.Windows.Forms.Button btnAddFace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddNewFace;
    }
}