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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pcbRecognized = new Emgu.CV.UI.ImageBox();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.lblCudaStts = new System.Windows.Forms.Label();
            this.tmrAddFace = new System.Windows.Forms.Timer(this.components);
            this.tmrScanning = new System.Windows.Forms.Timer(this.components);
            this.lblAttendedID = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.lblScanningCounter = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAttendedName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIDOnScreen = new System.Windows.Forms.Label();
            this.lblHourToday = new System.Windows.Forms.Label();
            this.tmrTimeNow = new System.Windows.Forms.Timer(this.components);
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnScanning = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblScanningStatus = new System.Windows.Forms.Label();
            this.pcbCurrentFrame = new Emgu.CV.UI.ImageBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblDevices = new System.Windows.Forms.Label();
            this.lblPersonDetected = new System.Windows.Forms.Button();
            this.ckbPulang = new System.Windows.Forms.CheckBox();
            this.lblEffectiveDayWarn = new System.Windows.Forms.Label();
            this.lblFaceCounter = new System.Windows.Forms.Label();
            this.dtgMonitor = new System.Windows.Forms.DataGridView();
            this.waktuPulang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuHadir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFaceStored = new System.Windows.Forms.Label();
            this.btnAddFace = new System.Windows.Forms.Button();
            this.lblAddFaceWarn = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Button();
            this.lblEffectiveDay = new System.Windows.Forms.Label();
            this.lblEffectiveDayCount = new System.Windows.Forms.Label();
            this.btnEffectiveDay = new System.Windows.Forms.Button();
            this.pnlMonitor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecognized)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonitor)).BeginInit();
            this.pnlMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbRecognized
            // 
            this.pcbRecognized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRecognized.Location = new System.Drawing.Point(253, 134);
            this.pcbRecognized.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbRecognized.Name = "pcbRecognized";
            this.pcbRecognized.Size = new System.Drawing.Size(133, 123);
            this.pcbRecognized.TabIndex = 7;
            this.pcbRecognized.TabStop = false;
            this.pcbRecognized.Visible = false;
            // 
            // cbxDevices
            // 
            this.cbxDevices.BackColor = System.Drawing.Color.White;
            this.cbxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDevices.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbxDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(465, 81);
            this.cbxDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(353, 32);
            this.cbxDevices.TabIndex = 2;
            this.cbxDevices.TabStop = false;
            // 
            // lblCudaStts
            // 
            this.lblCudaStts.AutoSize = true;
            this.lblCudaStts.BackColor = System.Drawing.Color.Transparent;
            this.lblCudaStts.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCudaStts.ForeColor = System.Drawing.Color.White;
            this.lblCudaStts.Location = new System.Drawing.Point(124, 79);
            this.lblCudaStts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCudaStts.Name = "lblCudaStts";
            this.lblCudaStts.Size = new System.Drawing.Size(51, 21);
            this.lblCudaStts.TabIndex = 6;
            this.lblCudaStts.Text = "CUDA";
            this.lblCudaStts.Visible = false;
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
            this.lblAttendedID.Location = new System.Drawing.Point(-1, 34);
            this.lblAttendedID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendedID.Name = "lblAttendedID";
            this.lblAttendedID.Size = new System.Drawing.Size(94, 17);
            this.lblAttendedID.TabIndex = 16;
            this.lblAttendedID.Text = "Attended ID";
            // 
            // btnAuto
            // 
            this.btnAuto.Enabled = false;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAuto.Location = new System.Drawing.Point(993, 81);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(113, 33);
            this.btnAuto.TabIndex = 8;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // lblScanningCounter
            // 
            this.lblScanningCounter.AutoSize = true;
            this.lblScanningCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblScanningCounter.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblScanningCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblScanningCounter.Location = new System.Drawing.Point(248, 630);
            this.lblScanningCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanningCounter.Name = "lblScanningCounter";
            this.lblScanningCounter.Size = new System.Drawing.Size(27, 31);
            this.lblScanningCounter.TabIndex = 20;
            this.lblScanningCounter.Text = "5";
            this.lblScanningCounter.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStart.Location = new System.Drawing.Point(852, 81);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 33);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // lblAttendedName
            // 
            this.lblAttendedName.AutoSize = true;
            this.lblAttendedName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedName.Location = new System.Drawing.Point(-1, 17);
            this.lblAttendedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendedName.Name = "lblAttendedName";
            this.lblAttendedName.Size = new System.Drawing.Size(120, 17);
            this.lblAttendedName.TabIndex = 25;
            this.lblAttendedName.Text = "Attended Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblAttendedName);
            this.panel4.Controls.Add(this.lblIDOnScreen);
            this.panel4.Controls.Add(this.lblAttendedID);
            this.panel4.Location = new System.Drawing.Point(49, 332);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 55);
            this.panel4.TabIndex = 28;
            this.panel4.Visible = false;
            // 
            // lblIDOnScreen
            // 
            this.lblIDOnScreen.AutoSize = true;
            this.lblIDOnScreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDOnScreen.Location = new System.Drawing.Point(-1, 0);
            this.lblIDOnScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDOnScreen.MaximumSize = new System.Drawing.Size(260, 0);
            this.lblIDOnScreen.Name = "lblIDOnScreen";
            this.lblIDOnScreen.Size = new System.Drawing.Size(103, 17);
            this.lblIDOnScreen.TabIndex = 19;
            this.lblIDOnScreen.Text = "ID on Screen";
            // 
            // lblHourToday
            // 
            this.lblHourToday.AutoSize = true;
            this.lblHourToday.BackColor = System.Drawing.Color.Transparent;
            this.lblHourToday.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblHourToday.ForeColor = System.Drawing.Color.White;
            this.lblHourToday.Location = new System.Drawing.Point(47, 626);
            this.lblHourToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHourToday.Name = "lblHourToday";
            this.lblHourToday.Size = new System.Drawing.Size(130, 31);
            this.lblHourToday.TabIndex = 30;
            this.lblHourToday.Text = "00 : 00 : 00";
            this.lblHourToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTimeNow
            // 
            this.tmrTimeNow.Enabled = true;
            this.tmrTimeNow.Interval = 1000;
            this.tmrTimeNow.Tick += new System.EventHandler(this.tmrTimeNow_Tick);
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlSidePanel.Controls.Add(this.lblDateToday);
            this.pnlSidePanel.Controls.Add(this.lblCudaStts);
            this.pnlSidePanel.Controls.Add(this.lblHourToday);
            this.pnlSidePanel.Controls.Add(this.panel4);
            this.pnlSidePanel.Controls.Add(this.btnLaporan);
            this.pnlSidePanel.Controls.Add(this.btnMonitor);
            this.pnlSidePanel.Controls.Add(this.btnScanning);
            this.pnlSidePanel.Controls.Add(this.label1);
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(227, 692);
            this.pnlSidePanel.TabIndex = 30;
            this.pnlSidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSidePanel_MouseDown);
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.BackColor = System.Drawing.Color.Transparent;
            this.lblDateToday.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDateToday.ForeColor = System.Drawing.Color.White;
            this.lblDateToday.Location = new System.Drawing.Point(47, 598);
            this.lblDateToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(126, 24);
            this.lblDateToday.TabIndex = 35;
            this.lblDateToday.Text = "20 / 02 / 2022";
            this.lblDateToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(0, 235);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(227, 43);
            this.btnLaporan.TabIndex = 34;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Visible = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.Transparent;
            this.btnMonitor.FlatAppearance.BorderSize = 0;
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnMonitor.ForeColor = System.Drawing.Color.White;
            this.btnMonitor.Location = new System.Drawing.Point(0, 185);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(227, 43);
            this.btnMonitor.TabIndex = 33;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnScanning
            // 
            this.btnScanning.BackColor = System.Drawing.Color.White;
            this.btnScanning.FlatAppearance.BorderSize = 0;
            this.btnScanning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanning.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnScanning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnScanning.Location = new System.Drawing.Point(0, 134);
            this.btnScanning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScanning.Name = "btnScanning";
            this.btnScanning.Size = new System.Drawing.Size(227, 43);
            this.btnScanning.TabIndex = 32;
            this.btnScanning.Text = "Scanning";
            this.btnScanning.UseVisualStyleBackColor = false;
            this.btnScanning.Click += new System.EventHandler(this.btnScanning_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 61);
            this.label1.TabIndex = 31;
            this.label1.Text = "ASyst";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl.Location = new System.Drawing.Point(248, 598);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 24);
            this.lbl.TabIndex = 31;
            this.lbl.Text = "Status :";
            // 
            // lblScanningStatus
            // 
            this.lblScanningStatus.AutoSize = true;
            this.lblScanningStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblScanningStatus.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblScanningStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblScanningStatus.Location = new System.Drawing.Point(332, 598);
            this.lblScanningStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanningStatus.Name = "lblScanningStatus";
            this.lblScanningStatus.Size = new System.Drawing.Size(88, 24);
            this.lblScanningStatus.TabIndex = 32;
            this.lblScanningStatus.Text = "Waiting...";
            // 
            // pcbCurrentFrame
            // 
            this.pcbCurrentFrame.BackColor = System.Drawing.Color.Transparent;
            this.pcbCurrentFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbCurrentFrame.Location = new System.Drawing.Point(253, 134);
            this.pcbCurrentFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCurrentFrame.Name = "pcbCurrentFrame";
            this.pcbCurrentFrame.Size = new System.Drawing.Size(853, 443);
            this.pcbCurrentFrame.TabIndex = 4;
            this.pcbCurrentFrame.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnExit.Location = new System.Drawing.Point(1073, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 33);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHide.Location = new System.Drawing.Point(1015, -1);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(60, 33);
            this.btnHide.TabIndex = 34;
            this.btnHide.Text = "-";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Visible = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.BackColor = System.Drawing.Color.Transparent;
            this.lblDevices.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblDevices.Location = new System.Drawing.Point(248, 80);
            this.lblDevices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(177, 31);
            this.lblDevices.TabIndex = 5;
            this.lblDevices.Text = "Camera Device :";
            // 
            // lblPersonDetected
            // 
            this.lblPersonDetected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPersonDetected.FlatAppearance.BorderSize = 0;
            this.lblPersonDetected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPersonDetected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPersonDetected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPersonDetected.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPersonDetected.ForeColor = System.Drawing.Color.White;
            this.lblPersonDetected.Location = new System.Drawing.Point(253, 546);
            this.lblPersonDetected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPersonDetected.Name = "lblPersonDetected";
            this.lblPersonDetected.Size = new System.Drawing.Size(853, 31);
            this.lblPersonDetected.TabIndex = 36;
            this.lblPersonDetected.UseVisualStyleBackColor = false;
            // 
            // ckbPulang
            // 
            this.ckbPulang.AutoSize = true;
            this.ckbPulang.BackColor = System.Drawing.Color.Transparent;
            this.ckbPulang.Font = new System.Drawing.Font("Calibri", 12F);
            this.ckbPulang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ckbPulang.Location = new System.Drawing.Point(993, 597);
            this.ckbPulang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPulang.Name = "ckbPulang";
            this.ckbPulang.Size = new System.Drawing.Size(88, 28);
            this.ckbPulang.TabIndex = 37;
            this.ckbPulang.Text = "Pulang";
            this.ckbPulang.UseVisualStyleBackColor = false;
            // 
            // lblEffectiveDayWarn
            // 
            this.lblEffectiveDayWarn.AutoSize = true;
            this.lblEffectiveDayWarn.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblEffectiveDayWarn.ForeColor = System.Drawing.Color.Red;
            this.lblEffectiveDayWarn.Location = new System.Drawing.Point(848, 57);
            this.lblEffectiveDayWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEffectiveDayWarn.Name = "lblEffectiveDayWarn";
            this.lblEffectiveDayWarn.Size = new System.Drawing.Size(210, 21);
            this.lblEffectiveDayWarn.TabIndex = 38;
            this.lblEffectiveDayWarn.Text = "*Please set effective day first";
            // 
            // lblFaceCounter
            // 
            this.lblFaceCounter.AutoSize = true;
            this.lblFaceCounter.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblFaceCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFaceCounter.Location = new System.Drawing.Point(164, -1);
            this.lblFaceCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaceCounter.Name = "lblFaceCounter";
            this.lblFaceCounter.Size = new System.Drawing.Size(27, 31);
            this.lblFaceCounter.TabIndex = 23;
            this.lblFaceCounter.Text = "0";
            // 
            // dtgMonitor
            // 
            this.dtgMonitor.AllowUserToAddRows = false;
            this.dtgMonitor.AllowUserToDeleteRows = false;
            this.dtgMonitor.AllowUserToResizeColumns = false;
            this.dtgMonitor.AllowUserToResizeRows = false;
            this.dtgMonitor.BackgroundColor = System.Drawing.Color.White;
            this.dtgMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgMonitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMonitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMonitor.ColumnHeadersHeight = 29;
            this.dtgMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.waktuHadir,
            this.waktuPulang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMonitor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMonitor.EnableHeadersVisualStyles = false;
            this.dtgMonitor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dtgMonitor.Location = new System.Drawing.Point(0, 53);
            this.dtgMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.dtgMonitor.MultiSelect = false;
            this.dtgMonitor.Name = "dtgMonitor";
            this.dtgMonitor.ReadOnly = true;
            this.dtgMonitor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgMonitor.RowHeadersVisible = false;
            this.dtgMonitor.RowHeadersWidth = 51;
            this.dtgMonitor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgMonitor.Size = new System.Drawing.Size(853, 414);
            this.dtgMonitor.TabIndex = 0;
            // 
            // waktuPulang
            // 
            this.waktuPulang.HeaderText = "Pulang";
            this.waktuPulang.MinimumWidth = 6;
            this.waktuPulang.Name = "waktuPulang";
            this.waktuPulang.ReadOnly = true;
            this.waktuPulang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.waktuPulang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.waktuPulang.Width = 125;
            // 
            // waktuHadir
            // 
            this.waktuHadir.HeaderText = "Datang";
            this.waktuHadir.MinimumWidth = 6;
            this.waktuHadir.Name = "waktuHadir";
            this.waktuHadir.ReadOnly = true;
            this.waktuHadir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.waktuHadir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.waktuHadir.Width = 125;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            this.Nama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nama.Width = 238;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 200;
            // 
            // lblFaceStored
            // 
            this.lblFaceStored.AutoSize = true;
            this.lblFaceStored.BackColor = System.Drawing.Color.Transparent;
            this.lblFaceStored.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblFaceStored.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFaceStored.Location = new System.Drawing.Point(-5, -1);
            this.lblFaceStored.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaceStored.Name = "lblFaceStored";
            this.lblFaceStored.Size = new System.Drawing.Size(150, 31);
            this.lblFaceStored.TabIndex = 6;
            this.lblFaceStored.Text = "Face Stored : ";
            // 
            // btnAddFace
            // 
            this.btnAddFace.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFace.Enabled = false;
            this.btnAddFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFace.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAddFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddFace.Location = new System.Drawing.Point(740, 0);
            this.btnAddFace.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(113, 33);
            this.btnAddFace.TabIndex = 24;
            this.btnAddFace.Text = "Add Face";
            this.btnAddFace.UseVisualStyleBackColor = false;
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // lblAddFaceWarn
            // 
            this.lblAddFaceWarn.AutoSize = true;
            this.lblAddFaceWarn.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblAddFaceWarn.ForeColor = System.Drawing.Color.Red;
            this.lblAddFaceWarn.Location = new System.Drawing.Point(529, 9);
            this.lblAddFaceWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddFaceWarn.Name = "lblAddFaceWarn";
            this.lblAddFaceWarn.Size = new System.Drawing.Size(186, 21);
            this.lblAddFaceWarn.TabIndex = 26;
            this.lblAddFaceWarn.Text = "*Please start camera first";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.BackColor = System.Drawing.Color.Transparent;
            this.lblReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReport.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblReport.Location = new System.Drawing.Point(736, 517);
            this.lblReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(112, 24);
            this.lblReport.TabIndex = 35;
            this.lblReport.Text = "View Report";
            this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReport.Click += new System.EventHandler(this.lblReport_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPanel.FlatAppearance.BorderSize = 0;
            this.btnPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnPanel.ForeColor = System.Drawing.Color.White;
            this.btnPanel.Location = new System.Drawing.Point(0, 465);
            this.btnPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(853, 31);
            this.btnPanel.TabIndex = 37;
            this.btnPanel.UseVisualStyleBackColor = false;
            // 
            // lblEffectiveDay
            // 
            this.lblEffectiveDay.AutoSize = true;
            this.lblEffectiveDay.BackColor = System.Drawing.Color.Transparent;
            this.lblEffectiveDay.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEffectiveDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblEffectiveDay.Location = new System.Drawing.Point(121, 517);
            this.lblEffectiveDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEffectiveDay.Name = "lblEffectiveDay";
            this.lblEffectiveDay.Size = new System.Drawing.Size(125, 24);
            this.lblEffectiveDay.TabIndex = 38;
            this.lblEffectiveDay.Text = "Effective Day :";
            // 
            // lblEffectiveDayCount
            // 
            this.lblEffectiveDayCount.AutoSize = true;
            this.lblEffectiveDayCount.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEffectiveDayCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblEffectiveDayCount.Location = new System.Drawing.Point(265, 517);
            this.lblEffectiveDayCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEffectiveDayCount.Name = "lblEffectiveDayCount";
            this.lblEffectiveDayCount.Size = new System.Drawing.Size(20, 24);
            this.lblEffectiveDayCount.TabIndex = 39;
            this.lblEffectiveDayCount.Text = "0";
            // 
            // btnEffectiveDay
            // 
            this.btnEffectiveDay.BackColor = System.Drawing.Color.Transparent;
            this.btnEffectiveDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffectiveDay.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEffectiveDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEffectiveDay.Location = new System.Drawing.Point(0, 512);
            this.btnEffectiveDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnEffectiveDay.Name = "btnEffectiveDay";
            this.btnEffectiveDay.Size = new System.Drawing.Size(113, 33);
            this.btnEffectiveDay.TabIndex = 40;
            this.btnEffectiveDay.Text = "Set";
            this.btnEffectiveDay.UseVisualStyleBackColor = false;
            this.btnEffectiveDay.Click += new System.EventHandler(this.btnEffectiveDay_Click);
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonitor.Controls.Add(this.btnEffectiveDay);
            this.pnlMonitor.Controls.Add(this.lblEffectiveDayCount);
            this.pnlMonitor.Controls.Add(this.lblEffectiveDay);
            this.pnlMonitor.Controls.Add(this.btnPanel);
            this.pnlMonitor.Controls.Add(this.lblReport);
            this.pnlMonitor.Controls.Add(this.lblAddFaceWarn);
            this.pnlMonitor.Controls.Add(this.btnAddFace);
            this.pnlMonitor.Controls.Add(this.lblFaceStored);
            this.pnlMonitor.Controls.Add(this.dtgMonitor);
            this.pnlMonitor.Controls.Add(this.lblFaceCounter);
            this.pnlMonitor.Location = new System.Drawing.Point(253, 81);
            this.pnlMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(853, 578);
            this.pnlMonitor.TabIndex = 35;
            this.pnlMonitor.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 692);
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.lblEffectiveDayWarn);
            this.Controls.Add(this.ckbPulang);
            this.Controls.Add(this.lblPersonDetected);
            this.Controls.Add(this.lblScanningCounter);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblScanningStatus);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxDevices);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.pcbRecognized);
            this.Controls.Add(this.pcbCurrentFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASyst";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecognized)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlSidePanel.ResumeLayout(false);
            this.pnlSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonitor)).EndInit();
            this.pnlMonitor.ResumeLayout(false);
            this.pnlMonitor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.Label lblCudaStts;
        private Emgu.CV.UI.ImageBox pcbRecognized;
        private System.Windows.Forms.Timer tmrAddFace;
        private System.Windows.Forms.Timer tmrScanning;
        private System.Windows.Forms.Label lblAttendedID;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lblScanningCounter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAttendedName;
        private System.Windows.Forms.Label lblHourToday;
        private System.Windows.Forms.Timer tmrTimeNow;
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.Button btnScanning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Label lblDateToday;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblScanningStatus;
        private Emgu.CV.UI.ImageBox pcbCurrentFrame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.Button lblPersonDetected;
        private System.Windows.Forms.CheckBox ckbPulang;
        private System.Windows.Forms.Label lblIDOnScreen;
        private System.Windows.Forms.Label lblEffectiveDayWarn;
        private System.Windows.Forms.Label lblFaceCounter;
        private System.Windows.Forms.DataGridView dtgMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuHadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuPulang;
        private System.Windows.Forms.Label lblFaceStored;
        private System.Windows.Forms.Button btnAddFace;
        private System.Windows.Forms.Label lblAddFaceWarn;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Label lblEffectiveDay;
        private System.Windows.Forms.Label lblEffectiveDayCount;
        private System.Windows.Forms.Button btnEffectiveDay;
        private System.Windows.Forms.Panel pnlMonitor;
    }
}

