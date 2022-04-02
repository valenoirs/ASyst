namespace ASyst
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.rdbEigen = new System.Windows.Forms.RadioButton();
            this.txbEigenThreshold = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEigenNumCom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbFisher = new System.Windows.Forms.RadioButton();
            this.txbFisherThreshold = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbFisherNumCom = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNeighbors = new System.Windows.Forms.TextBox();
            this.txbGridX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRadius = new System.Windows.Forms.TextBox();
            this.txbGridY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLBPHThreshold = new System.Windows.Forms.TextBox();
            this.rdbLBPH = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplySettings.Location = new System.Drawing.Point(488, 291);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(75, 23);
            this.btnApplySettings.TabIndex = 0;
            this.btnApplySettings.Text = "Apply";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // rdbEigen
            // 
            this.rdbEigen.AutoSize = true;
            this.rdbEigen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEigen.Location = new System.Drawing.Point(197, 21);
            this.rdbEigen.Name = "rdbEigen";
            this.rdbEigen.Size = new System.Drawing.Size(158, 18);
            this.rdbEigen.TabIndex = 15;
            this.rdbEigen.TabStop = true;
            this.rdbEigen.Text = "Eigen Face Recognizer";
            this.rdbEigen.UseVisualStyleBackColor = true;
            // 
            // txbEigenThreshold
            // 
            this.txbEigenThreshold.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEigenThreshold.Location = new System.Drawing.Point(197, 110);
            this.txbEigenThreshold.Name = "txbEigenThreshold";
            this.txbEigenThreshold.Size = new System.Drawing.Size(100, 21);
            this.txbEigenThreshold.TabIndex = 13;
            this.txbEigenThreshold.Text = "5000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Threshold :";
            // 
            // txbEigenNumCom
            // 
            this.txbEigenNumCom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEigenNumCom.Location = new System.Drawing.Point(197, 70);
            this.txbEigenNumCom.Name = "txbEigenNumCom";
            this.txbEigenNumCom.Size = new System.Drawing.Size(100, 21);
            this.txbEigenNumCom.TabIndex = 13;
            this.txbEigenNumCom.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "numComponent :";
            // 
            // rdbFisher
            // 
            this.rdbFisher.AutoSize = true;
            this.rdbFisher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFisher.Location = new System.Drawing.Point(378, 21);
            this.rdbFisher.Name = "rdbFisher";
            this.rdbFisher.Size = new System.Drawing.Size(161, 18);
            this.rdbFisher.TabIndex = 16;
            this.rdbFisher.TabStop = true;
            this.rdbFisher.Text = "Fisher Face Recognizer";
            this.rdbFisher.UseVisualStyleBackColor = true;
            // 
            // txbFisherThreshold
            // 
            this.txbFisherThreshold.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFisherThreshold.Location = new System.Drawing.Point(378, 110);
            this.txbFisherThreshold.Name = "txbFisherThreshold";
            this.txbFisherThreshold.Size = new System.Drawing.Size(100, 21);
            this.txbFisherThreshold.TabIndex = 14;
            this.txbFisherThreshold.Text = "5000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Threshold :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "numComponent :";
            // 
            // txbFisherNumCom
            // 
            this.txbFisherNumCom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFisherNumCom.Location = new System.Drawing.Point(378, 70);
            this.txbFisherNumCom.Name = "txbFisherNumCom";
            this.txbFisherNumCom.Size = new System.Drawing.Size(100, 21);
            this.txbFisherNumCom.TabIndex = 16;
            this.txbFisherNumCom.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(407, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Neighbors :";
            // 
            // txbNeighbors
            // 
            this.txbNeighbors.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNeighbors.Location = new System.Drawing.Point(23, 110);
            this.txbNeighbors.Name = "txbNeighbors";
            this.txbNeighbors.Size = new System.Drawing.Size(100, 21);
            this.txbNeighbors.TabIndex = 2;
            this.txbNeighbors.Text = "8";
            // 
            // txbGridX
            // 
            this.txbGridX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGridX.Location = new System.Drawing.Point(23, 150);
            this.txbGridX.Name = "txbGridX";
            this.txbGridX.Size = new System.Drawing.Size(100, 21);
            this.txbGridX.TabIndex = 3;
            this.txbGridX.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grid X :";
            // 
            // txbRadius
            // 
            this.txbRadius.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRadius.Location = new System.Drawing.Point(23, 70);
            this.txbRadius.Name = "txbRadius";
            this.txbRadius.Size = new System.Drawing.Size(100, 21);
            this.txbRadius.TabIndex = 1;
            this.txbRadius.Text = "1";
            // 
            // txbGridY
            // 
            this.txbGridY.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGridY.Location = new System.Drawing.Point(23, 190);
            this.txbGridY.Name = "txbGridY";
            this.txbGridY.Size = new System.Drawing.Size(100, 21);
            this.txbGridY.TabIndex = 4;
            this.txbGridY.Text = "9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grid Y :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Radius :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Threshold :";
            // 
            // txbLBPHThreshold
            // 
            this.txbLBPHThreshold.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLBPHThreshold.Location = new System.Drawing.Point(23, 230);
            this.txbLBPHThreshold.Name = "txbLBPHThreshold";
            this.txbLBPHThreshold.Size = new System.Drawing.Size(100, 21);
            this.txbLBPHThreshold.TabIndex = 5;
            this.txbLBPHThreshold.Text = "5000";
            // 
            // rdbLBPH
            // 
            this.rdbLBPH.AutoSize = true;
            this.rdbLBPH.Checked = true;
            this.rdbLBPH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLBPH.Location = new System.Drawing.Point(23, 21);
            this.rdbLBPH.Name = "rdbLBPH";
            this.rdbLBPH.Size = new System.Drawing.Size(158, 18);
            this.rdbLBPH.TabIndex = 14;
            this.rdbLBPH.TabStop = true;
            this.rdbLBPH.Text = "LBPH Face Recognizer";
            this.rdbLBPH.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdbLBPH);
            this.panel1.Controls.Add(this.rdbFisher);
            this.panel1.Controls.Add(this.txbGridX);
            this.panel1.Controls.Add(this.txbFisherThreshold);
            this.panel1.Controls.Add(this.txbNeighbors);
            this.panel1.Controls.Add(this.rdbEigen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbEigenThreshold);
            this.panel1.Controls.Add(this.txbRadius);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbGridY);
            this.panel1.Controls.Add(this.txbFisherNumCom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbLBPHThreshold);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbEigenNumCom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 266);
            this.panel1.TabIndex = 18;
            // 
            // btnCancelSettings
            // 
            this.btnCancelSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSettings.Location = new System.Drawing.Point(12, 291);
            this.btnCancelSettings.Name = "btnCancelSettings";
            this.btnCancelSettings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSettings.TabIndex = 19;
            this.btnCancelSettings.Text = "Cancel";
            this.btnCancelSettings.UseVisualStyleBackColor = true;
            this.btnCancelSettings.Click += new System.EventHandler(this.btnCancelSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 326);
            this.Controls.Add(this.btnCancelSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnApplySettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.TextBox txbEigenThreshold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEigenNumCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFisherThreshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbFisherNumCom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdbEigen;
        private System.Windows.Forms.RadioButton rdbFisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNeighbors;
        private System.Windows.Forms.TextBox txbGridX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRadius;
        private System.Windows.Forms.TextBox txbGridY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLBPHThreshold;
        private System.Windows.Forms.RadioButton rdbLBPH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelSettings;
    }
}