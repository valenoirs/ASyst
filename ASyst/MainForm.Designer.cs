namespace ASyst
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pcbRecognized = new Emgu.CV.UI.ImageBox();
            this.lblFaceStored = new System.Windows.Forms.Label();
            this.pcbCurrentFrame = new Emgu.CV.UI.ImageBox();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.lblDevices = new System.Windows.Forms.Label();
            this.lblCudaStts = new System.Windows.Forms.Label();
            this.tmrAddFace = new System.Windows.Forms.Timer(this.components);
            this.tmrScanning = new System.Windows.Forms.Timer(this.components);
            this.lblAttendedID = new System.Windows.Forms.Label();
            this.lblAttendanceStatusStts = new System.Windows.Forms.Label();
            this.btnScanning = new System.Windows.Forms.Button();
            this.lblIDOnScreen = new System.Windows.Forms.Label();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.lblAutoStts = new System.Windows.Forms.Label();
            this.lblFaceCounter = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stpLoadDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.stpAddFace = new System.Windows.Forms.ToolStripMenuItem();
            this.stpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAttendedName = new System.Windows.Forms.Label();
            this.lblAttendedIDStts = new System.Windows.Forms.Label();
            this.lblAttendedNameStts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIDOnScreenStts = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNameOnScreen = new System.Windows.Forms.Label();
            this.lblNameOnScreenStts = new System.Windows.Forms.Label();
            this.lblAsyst = new System.Windows.Forms.Label();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.tmrTimeNow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecognized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentFrame)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbRecognized
            // 
            this.pcbRecognized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRecognized.Location = new System.Drawing.Point(3, 207);
            this.pcbRecognized.Name = "pcbRecognized";
            this.pcbRecognized.Size = new System.Drawing.Size(100, 100);
            this.pcbRecognized.TabIndex = 7;
            this.pcbRecognized.TabStop = false;
            this.pcbRecognized.Visible = false;
            // 
            // lblFaceStored
            // 
            this.lblFaceStored.AutoSize = true;
            this.lblFaceStored.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceStored.Location = new System.Drawing.Point(12, 4);
            this.lblFaceStored.Name = "lblFaceStored";
            this.lblFaceStored.Size = new System.Drawing.Size(87, 14);
            this.lblFaceStored.TabIndex = 11;
            this.lblFaceStored.Text = "Face Stored : ";
            // 
            // pcbCurrentFrame
            // 
            this.pcbCurrentFrame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbCurrentFrame.Location = new System.Drawing.Point(1, 205);
            this.pcbCurrentFrame.Name = "pcbCurrentFrame";
            this.pcbCurrentFrame.Size = new System.Drawing.Size(533, 300);
            this.pcbCurrentFrame.TabIndex = 4;
            this.pcbCurrentFrame.TabStop = false;
            // 
            // cbxDevices
            // 
            this.cbxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevices.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(117, 7);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(210, 22);
            this.cbxDevices.TabIndex = 2;
            this.cbxDevices.TabStop = false;
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevices.Location = new System.Drawing.Point(8, 10);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(103, 14);
            this.lblDevices.TabIndex = 5;
            this.lblDevices.Text = "Camera Device :";
            // 
            // lblCudaStts
            // 
            this.lblCudaStts.AutoSize = true;
            this.lblCudaStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCudaStts.Location = new System.Drawing.Point(11, 6);
            this.lblCudaStts.Name = "lblCudaStts";
            this.lblCudaStts.Size = new System.Drawing.Size(136, 14);
            this.lblCudaStts.TabIndex = 6;
            this.lblCudaStts.Text = "CUDA Status :              -";
            // 
            // tmrAddFace
            // 
            this.tmrAddFace.Interval = 250;
            this.tmrAddFace.Tick += new System.EventHandler(this.tmrAddFace_Tick);
            // 
            // tmrScanning
            // 
            this.tmrScanning.Interval = 1000;
            this.tmrScanning.Tick += new System.EventHandler(this.tmrScanning_Tick);
            // 
            // lblAttendedID
            // 
            this.lblAttendedID.AutoSize = true;
            this.lblAttendedID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedID.Location = new System.Drawing.Point(136, 44);
            this.lblAttendedID.Name = "lblAttendedID";
            this.lblAttendedID.Size = new System.Drawing.Size(11, 14);
            this.lblAttendedID.TabIndex = 16;
            this.lblAttendedID.Text = "-";
            // 
            // lblAttendanceStatusStts
            // 
            this.lblAttendanceStatusStts.AutoSize = true;
            this.lblAttendanceStatusStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceStatusStts.Location = new System.Drawing.Point(12, 63);
            this.lblAttendanceStatusStts.Name = "lblAttendanceStatusStts";
            this.lblAttendanceStatusStts.Size = new System.Drawing.Size(124, 14);
            this.lblAttendanceStatusStts.TabIndex = 18;
            this.lblAttendanceStatusStts.Text = "Attendance Status : ";
            // 
            // btnScanning
            // 
            this.btnScanning.Enabled = false;
            this.btnScanning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanning.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanning.Location = new System.Drawing.Point(5, 46);
            this.btnScanning.Name = "btnScanning";
            this.btnScanning.Size = new System.Drawing.Size(85, 24);
            this.btnScanning.TabIndex = 8;
            this.btnScanning.Text = "Automate";
            this.btnScanning.UseVisualStyleBackColor = true;
            this.btnScanning.Click += new System.EventHandler(this.btnScanning_Click);
            // 
            // lblIDOnScreen
            // 
            this.lblIDOnScreen.AutoSize = true;
            this.lblIDOnScreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDOnScreen.Location = new System.Drawing.Point(111, 2);
            this.lblIDOnScreen.MaximumSize = new System.Drawing.Size(195, 0);
            this.lblIDOnScreen.Name = "lblIDOnScreen";
            this.lblIDOnScreen.Size = new System.Drawing.Size(11, 14);
            this.lblIDOnScreen.TabIndex = 19;
            this.lblIDOnScreen.Text = ",";
            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.AutoSize = true;
            this.lblAttendanceStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceStatus.Location = new System.Drawing.Point(136, 63);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(11, 14);
            this.lblAttendanceStatus.TabIndex = 20;
            this.lblAttendanceStatus.Text = "-";
            // 
            // lblAutoStts
            // 
            this.lblAutoStts.AutoSize = true;
            this.lblAutoStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoStts.Location = new System.Drawing.Point(12, 23);
            this.lblAutoStts.Name = "lblAutoStts";
            this.lblAutoStts.Size = new System.Drawing.Size(155, 14);
            this.lblAutoStts.TabIndex = 21;
            this.lblAutoStts.Text = "Automate Status :       OFF";
            // 
            // lblFaceCounter
            // 
            this.lblFaceCounter.AutoSize = true;
            this.lblFaceCounter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceCounter.Location = new System.Drawing.Point(136, 4);
            this.lblFaceCounter.Name = "lblFaceCounter";
            this.lblFaceCounter.Size = new System.Drawing.Size(11, 14);
            this.lblFaceCounter.TabIndex = 23;
            this.lblFaceCounter.Text = "-";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stpHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuStrip.Size = new System.Drawing.Size(534, 24);
            this.MenuStrip.TabIndex = 24;
            this.MenuStrip.Text = "MenuStrip";
            this.MenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stpLoadDataset,
            this.stpAddFace});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // stpLoadDataset
            // 
            this.stpLoadDataset.Name = "stpLoadDataset";
            this.stpLoadDataset.Size = new System.Drawing.Size(142, 22);
            this.stpLoadDataset.Tag = "";
            this.stpLoadDataset.Text = "Load Dataset";
            // 
            // stpAddFace
            // 
            this.stpAddFace.Enabled = false;
            this.stpAddFace.Name = "stpAddFace";
            this.stpAddFace.Size = new System.Drawing.Size(142, 22);
            this.stpAddFace.Text = "Add Face";
            this.stpAddFace.Click += new System.EventHandler(this.stpAddFace_Click);
            // 
            // stpHelp
            // 
            this.stpHelp.Name = "stpHelp";
            this.stpHelp.Size = new System.Drawing.Size(44, 20);
            this.stpHelp.Text = "Help";
            this.stpHelp.Click += new System.EventHandler(this.stpHelp_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(336, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 24);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAttendedName);
            this.panel1.Controls.Add(this.lblAttendanceStatus);
            this.panel1.Controls.Add(this.lblFaceStored);
            this.panel1.Controls.Add(this.lblAttendanceStatusStts);
            this.panel1.Controls.Add(this.lblFaceCounter);
            this.panel1.Controls.Add(this.lblAttendedIDStts);
            this.panel1.Controls.Add(this.lblAttendedNameStts);
            this.panel1.Controls.Add(this.lblAttendedID);
            this.panel1.Location = new System.Drawing.Point(318, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 83);
            this.panel1.TabIndex = 25;
            // 
            // lblAttendedName
            // 
            this.lblAttendedName.AutoSize = true;
            this.lblAttendedName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedName.Location = new System.Drawing.Point(136, 24);
            this.lblAttendedName.Name = "lblAttendedName";
            this.lblAttendedName.Size = new System.Drawing.Size(11, 14);
            this.lblAttendedName.TabIndex = 25;
            this.lblAttendedName.Text = "-";
            // 
            // lblAttendedIDStts
            // 
            this.lblAttendedIDStts.AutoSize = true;
            this.lblAttendedIDStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedIDStts.Location = new System.Drawing.Point(12, 44);
            this.lblAttendedIDStts.Name = "lblAttendedIDStts";
            this.lblAttendedIDStts.Size = new System.Drawing.Size(87, 14);
            this.lblAttendedIDStts.TabIndex = 24;
            this.lblAttendedIDStts.Text = "Attended ID : ";
            // 
            // lblAttendedNameStts
            // 
            this.lblAttendedNameStts.AutoSize = true;
            this.lblAttendedNameStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedNameStts.Location = new System.Drawing.Point(12, 24);
            this.lblAttendedNameStts.Name = "lblAttendedNameStts";
            this.lblAttendedNameStts.Size = new System.Drawing.Size(108, 14);
            this.lblAttendedNameStts.TabIndex = 14;
            this.lblAttendedNameStts.Text = "Attended Name : ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.cbxDevices);
            this.panel2.Controls.Add(this.lblDevices);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(5, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 38);
            this.panel2.TabIndex = 26;
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(427, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 24);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCudaStts);
            this.panel3.Controls.Add(this.lblAutoStts);
            this.panel3.Location = new System.Drawing.Point(318, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 43);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnScanning);
            this.panel4.Controls.Add(this.lblNameOnScreen);
            this.panel4.Controls.Add(this.lblIDOnScreenStts);
            this.panel4.Controls.Add(this.lblIDOnScreen);
            this.panel4.Controls.Add(this.lblNameOnScreenStts);
            this.panel4.Location = new System.Drawing.Point(5, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 81);
            this.panel4.TabIndex = 28;
            // 
            // lblIDOnScreenStts
            // 
            this.lblIDOnScreenStts.AutoSize = true;
            this.lblIDOnScreenStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDOnScreenStts.Location = new System.Drawing.Point(2, 2);
            this.lblIDOnScreenStts.Name = "lblIDOnScreenStts";
            this.lblIDOnScreenStts.Size = new System.Drawing.Size(91, 14);
            this.lblIDOnScreenStts.TabIndex = 20;
            this.lblIDOnScreenStts.Text = "ID On Screen :";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblDateToday);
            this.panel5.Location = new System.Drawing.Point(5, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 38);
            this.panel5.TabIndex = 29;
            // 
            // lblNameOnScreen
            // 
            this.lblNameOnScreen.AutoSize = true;
            this.lblNameOnScreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnScreen.Location = new System.Drawing.Point(111, 23);
            this.lblNameOnScreen.MaximumSize = new System.Drawing.Size(195, 0);
            this.lblNameOnScreen.Name = "lblNameOnScreen";
            this.lblNameOnScreen.Size = new System.Drawing.Size(11, 14);
            this.lblNameOnScreen.TabIndex = 21;
            this.lblNameOnScreen.Text = ",";
            // 
            // lblNameOnScreenStts
            // 
            this.lblNameOnScreenStts.AutoSize = true;
            this.lblNameOnScreenStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnScreenStts.Location = new System.Drawing.Point(2, 23);
            this.lblNameOnScreenStts.Name = "lblNameOnScreenStts";
            this.lblNameOnScreenStts.Size = new System.Drawing.Size(112, 14);
            this.lblNameOnScreenStts.TabIndex = 19;
            this.lblNameOnScreenStts.Text = "Name On Screen :";
            // 
            // lblAsyst
            // 
            this.lblAsyst.AutoSize = true;
            this.lblAsyst.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsyst.Location = new System.Drawing.Point(472, 4);
            this.lblAsyst.Name = "lblAsyst";
            this.lblAsyst.Size = new System.Drawing.Size(56, 20);
            this.lblAsyst.TabIndex = 22;
            this.lblAsyst.Text = "ASyst";
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.Location = new System.Drawing.Point(6, 7);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(103, 20);
            this.lblDateToday.TabIndex = 30;
            this.lblDateToday.Text = "Date Today";
            // 
            // tmrTimeNow
            // 
            this.tmrTimeNow.Enabled = true;
            this.tmrTimeNow.Interval = 1000;
            this.tmrTimeNow.Tick += new System.EventHandler(this.tmrTimeNow_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 510);
            this.Controls.Add(this.lblAsyst);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbRecognized);
            this.Controls.Add(this.pcbCurrentFrame);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASyst";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecognized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentFrame)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox pcbCurrentFrame;
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.Label lblCudaStts;
        private Emgu.CV.UI.ImageBox pcbRecognized;
        private System.Windows.Forms.Label lblFaceStored;
        private System.Windows.Forms.Timer tmrAddFace;
        private System.Windows.Forms.Timer tmrScanning;
        private System.Windows.Forms.Label lblAttendedID;
        private System.Windows.Forms.Label lblAttendanceStatusStts;
        private System.Windows.Forms.Button btnScanning;
        private System.Windows.Forms.Label lblIDOnScreen;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Label lblAutoStts;
        private System.Windows.Forms.Label lblFaceCounter;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stpLoadDataset;
        private System.Windows.Forms.ToolStripMenuItem stpAddFace;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAttendedName;
        private System.Windows.Forms.Label lblAttendedIDStts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNameOnScreenStts;
        private System.Windows.Forms.ToolStripMenuItem stpHelp;
        private System.Windows.Forms.Label lblAttendedNameStts;
        private System.Windows.Forms.Label lblIDOnScreenStts;
        private System.Windows.Forms.Label lblNameOnScreen;
        private System.Windows.Forms.Label lblAsyst;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblDateToday;
        private System.Windows.Forms.Timer tmrTimeNow;
    }
}

