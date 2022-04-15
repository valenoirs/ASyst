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
            this.lblAttendanceStatusStts = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.lblIDOnScreen = new System.Windows.Forms.Label();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAttendedName = new System.Windows.Forms.Label();
            this.lblAttendedIDStts = new System.Windows.Forms.Label();
            this.lblAttendedNameStts = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNameOnScreen = new System.Windows.Forms.Label();
            this.lblIDOnScreenStts = new System.Windows.Forms.Label();
            this.lblNameOnScreenStts = new System.Windows.Forms.Label();
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
            this.lblFaceCounter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFaceStored = new System.Windows.Forms.Label();
            this.btnAddFace = new System.Windows.Forms.Button();
            this.pnlMonitor = new System.Windows.Forms.Panel();
            this.lblAddFaceWarn = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuHadir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuPulang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPersonDetected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecognized)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbRecognized
            // 
            this.pcbRecognized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRecognized.Location = new System.Drawing.Point(190, 109);
            this.pcbRecognized.Name = "pcbRecognized";
            this.pcbRecognized.Size = new System.Drawing.Size(100, 100);
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
            this.cbxDevices.Location = new System.Drawing.Point(349, 66);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(266, 27);
            this.cbxDevices.TabIndex = 2;
            this.cbxDevices.TabStop = false;
            // 
            // lblCudaStts
            // 
            this.lblCudaStts.AutoSize = true;
            this.lblCudaStts.BackColor = System.Drawing.Color.Transparent;
            this.lblCudaStts.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCudaStts.ForeColor = System.Drawing.Color.White;
            this.lblCudaStts.Location = new System.Drawing.Point(93, 64);
            this.lblCudaStts.Name = "lblCudaStts";
            this.lblCudaStts.Size = new System.Drawing.Size(38, 15);
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
            this.lblAttendedID.Location = new System.Drawing.Point(127, 66);
            this.lblAttendedID.Name = "lblAttendedID";
            this.lblAttendedID.Size = new System.Drawing.Size(11, 14);
            this.lblAttendedID.TabIndex = 16;
            this.lblAttendedID.Text = "-";
            // 
            // lblAttendanceStatusStts
            // 
            this.lblAttendanceStatusStts.AutoSize = true;
            this.lblAttendanceStatusStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceStatusStts.Location = new System.Drawing.Point(3, 85);
            this.lblAttendanceStatusStts.Name = "lblAttendanceStatusStts";
            this.lblAttendanceStatusStts.Size = new System.Drawing.Size(124, 14);
            this.lblAttendanceStatusStts.TabIndex = 18;
            this.lblAttendanceStatusStts.Text = "Attendance Status : ";
            // 
            // btnAuto
            // 
            this.btnAuto.Enabled = false;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAuto.Location = new System.Drawing.Point(745, 66);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(85, 27);
            this.btnAuto.TabIndex = 8;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // lblIDOnScreen
            // 
            this.lblIDOnScreen.AutoSize = true;
            this.lblIDOnScreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDOnScreen.Location = new System.Drawing.Point(112, 9);
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
            this.lblAttendanceStatus.Location = new System.Drawing.Point(187, 539);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(11, 14);
            this.lblAttendanceStatus.TabIndex = 20;
            this.lblAttendanceStatus.Text = "-";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStart.Location = new System.Drawing.Point(639, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 27);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // lblAttendedName
            // 
            this.lblAttendedName.AutoSize = true;
            this.lblAttendedName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedName.Location = new System.Drawing.Point(127, 46);
            this.lblAttendedName.Name = "lblAttendedName";
            this.lblAttendedName.Size = new System.Drawing.Size(11, 14);
            this.lblAttendedName.TabIndex = 25;
            this.lblAttendedName.Text = "-";
            // 
            // lblAttendedIDStts
            // 
            this.lblAttendedIDStts.AutoSize = true;
            this.lblAttendedIDStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedIDStts.Location = new System.Drawing.Point(3, 66);
            this.lblAttendedIDStts.Name = "lblAttendedIDStts";
            this.lblAttendedIDStts.Size = new System.Drawing.Size(87, 14);
            this.lblAttendedIDStts.TabIndex = 24;
            this.lblAttendedIDStts.Text = "Attended ID : ";
            // 
            // lblAttendedNameStts
            // 
            this.lblAttendedNameStts.AutoSize = true;
            this.lblAttendedNameStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedNameStts.Location = new System.Drawing.Point(3, 46);
            this.lblAttendedNameStts.Name = "lblAttendedNameStts";
            this.lblAttendedNameStts.Size = new System.Drawing.Size(108, 14);
            this.lblAttendedNameStts.TabIndex = 14;
            this.lblAttendedNameStts.Text = "Attended Name : ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblAttendedName);
            this.panel4.Controls.Add(this.lblNameOnScreen);
            this.panel4.Controls.Add(this.lblIDOnScreenStts);
            this.panel4.Controls.Add(this.lblAttendanceStatusStts);
            this.panel4.Controls.Add(this.lblIDOnScreen);
            this.panel4.Controls.Add(this.lblNameOnScreenStts);
            this.panel4.Controls.Add(this.lblAttendedIDStts);
            this.panel4.Controls.Add(this.lblAttendedID);
            this.panel4.Controls.Add(this.lblAttendedNameStts);
            this.panel4.Location = new System.Drawing.Point(3, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 107);
            this.panel4.TabIndex = 28;
            this.panel4.Visible = false;
            // 
            // lblNameOnScreen
            // 
            this.lblNameOnScreen.AutoSize = true;
            this.lblNameOnScreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnScreen.Location = new System.Drawing.Point(112, 27);
            this.lblNameOnScreen.MaximumSize = new System.Drawing.Size(195, 0);
            this.lblNameOnScreen.Name = "lblNameOnScreen";
            this.lblNameOnScreen.Size = new System.Drawing.Size(11, 14);
            this.lblNameOnScreen.TabIndex = 21;
            this.lblNameOnScreen.Text = ",";
            // 
            // lblIDOnScreenStts
            // 
            this.lblIDOnScreenStts.AutoSize = true;
            this.lblIDOnScreenStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDOnScreenStts.Location = new System.Drawing.Point(3, 9);
            this.lblIDOnScreenStts.Name = "lblIDOnScreenStts";
            this.lblIDOnScreenStts.Size = new System.Drawing.Size(91, 14);
            this.lblIDOnScreenStts.TabIndex = 20;
            this.lblIDOnScreenStts.Text = "ID On Screen :";
            // 
            // lblNameOnScreenStts
            // 
            this.lblNameOnScreenStts.AutoSize = true;
            this.lblNameOnScreenStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnScreenStts.Location = new System.Drawing.Point(3, 27);
            this.lblNameOnScreenStts.Name = "lblNameOnScreenStts";
            this.lblNameOnScreenStts.Size = new System.Drawing.Size(112, 14);
            this.lblNameOnScreenStts.TabIndex = 19;
            this.lblNameOnScreenStts.Text = "Name On Screen :";
            // 
            // lblHourToday
            // 
            this.lblHourToday.AutoSize = true;
            this.lblHourToday.BackColor = System.Drawing.Color.Transparent;
            this.lblHourToday.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblHourToday.ForeColor = System.Drawing.Color.White;
            this.lblHourToday.Location = new System.Drawing.Point(35, 512);
            this.lblHourToday.Name = "lblHourToday";
            this.lblHourToday.Size = new System.Drawing.Size(100, 24);
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
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(170, 562);
            this.pnlSidePanel.TabIndex = 30;
            this.pnlSidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSidePanel_MouseDown);
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.BackColor = System.Drawing.Color.Transparent;
            this.lblDateToday.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblDateToday.ForeColor = System.Drawing.Color.White;
            this.lblDateToday.Location = new System.Drawing.Point(20, 486);
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
            this.btnLaporan.Location = new System.Drawing.Point(0, 191);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(170, 35);
            this.btnLaporan.TabIndex = 34;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.Transparent;
            this.btnMonitor.FlatAppearance.BorderSize = 0;
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnMonitor.ForeColor = System.Drawing.Color.White;
            this.btnMonitor.Location = new System.Drawing.Point(0, 150);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(170, 35);
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
            this.btnScanning.Location = new System.Drawing.Point(0, 109);
            this.btnScanning.Name = "btnScanning";
            this.btnScanning.Size = new System.Drawing.Size(170, 35);
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
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 49);
            this.label1.TabIndex = 31;
            this.label1.Text = "ASyst";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl.Location = new System.Drawing.Point(186, 486);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 24);
            this.lbl.TabIndex = 31;
            this.lbl.Text = "Status :";
            // 
            // lblScanningStatus
            // 
            this.lblScanningStatus.AutoSize = true;
            this.lblScanningStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblScanningStatus.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblScanningStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblScanningStatus.Location = new System.Drawing.Point(264, 486);
            this.lblScanningStatus.Name = "lblScanningStatus";
            this.lblScanningStatus.Size = new System.Drawing.Size(88, 24);
            this.lblScanningStatus.TabIndex = 32;
            this.lblScanningStatus.Text = "Waiting...";
            // 
            // pcbCurrentFrame
            // 
            this.pcbCurrentFrame.BackColor = System.Drawing.Color.Transparent;
            this.pcbCurrentFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbCurrentFrame.Location = new System.Drawing.Point(190, 109);
            this.pcbCurrentFrame.Name = "pcbCurrentFrame";
            this.pcbCurrentFrame.Size = new System.Drawing.Size(640, 360);
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
            this.btnExit.Location = new System.Drawing.Point(805, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 27);
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
            this.btnHide.Location = new System.Drawing.Point(761, -1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(45, 27);
            this.btnHide.TabIndex = 34;
            this.btnHide.Text = "-";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.BackColor = System.Drawing.Color.Transparent;
            this.lblDevices.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblDevices.Location = new System.Drawing.Point(186, 65);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(143, 24);
            this.lblDevices.TabIndex = 5;
            this.lblDevices.Text = "Camera Device :";
            // 
            // lblFaceCounter
            // 
            this.lblFaceCounter.AutoSize = true;
            this.lblFaceCounter.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblFaceCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFaceCounter.Location = new System.Drawing.Point(123, -1);
            this.lblFaceCounter.Name = "lblFaceCounter";
            this.lblFaceCounter.Size = new System.Drawing.Size(20, 24);
            this.lblFaceCounter.TabIndex = 23;
            this.lblFaceCounter.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.waktuHadir,
            this.waktuPulang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(640, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblFaceStored
            // 
            this.lblFaceStored.AutoSize = true;
            this.lblFaceStored.BackColor = System.Drawing.Color.Transparent;
            this.lblFaceStored.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblFaceStored.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFaceStored.Location = new System.Drawing.Point(-4, -1);
            this.lblFaceStored.Name = "lblFaceStored";
            this.lblFaceStored.Size = new System.Drawing.Size(121, 24);
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
            this.btnAddFace.Location = new System.Drawing.Point(0, 423);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(85, 27);
            this.btnAddFace.TabIndex = 24;
            this.btnAddFace.Text = "Add Face";
            this.btnAddFace.UseVisualStyleBackColor = false;
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonitor.Controls.Add(this.lblAddFaceWarn);
            this.pnlMonitor.Controls.Add(this.btnAddFace);
            this.pnlMonitor.Controls.Add(this.lblFaceStored);
            this.pnlMonitor.Controls.Add(this.dataGridView1);
            this.pnlMonitor.Controls.Add(this.lblFaceCounter);
            this.pnlMonitor.Location = new System.Drawing.Point(190, 65);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(640, 471);
            this.pnlMonitor.TabIndex = 35;
            this.pnlMonitor.Visible = false;
            // 
            // lblAddFaceWarn
            // 
            this.lblAddFaceWarn.AutoSize = true;
            this.lblAddFaceWarn.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblAddFaceWarn.ForeColor = System.Drawing.Color.Red;
            this.lblAddFaceWarn.Location = new System.Drawing.Point(91, 430);
            this.lblAddFaceWarn.Name = "lblAddFaceWarn";
            this.lblAddFaceWarn.Size = new System.Drawing.Size(152, 17);
            this.lblAddFaceWarn.TabIndex = 26;
            this.lblAddFaceWarn.Text = "*Please start camera first";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 200;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nama.Width = 238;
            // 
            // waktuHadir
            // 
            this.waktuHadir.HeaderText = "Datang";
            this.waktuHadir.Name = "waktuHadir";
            this.waktuHadir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.waktuHadir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // waktuPulang
            // 
            this.waktuPulang.HeaderText = "Pulang";
            this.waktuPulang.Name = "waktuPulang";
            this.waktuPulang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.waktuPulang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.lblPersonDetected.Location = new System.Drawing.Point(190, 444);
            this.lblPersonDetected.Name = "lblPersonDetected";
            this.lblPersonDetected.Size = new System.Drawing.Size(640, 25);
            this.lblPersonDetected.TabIndex = 36;
            this.lblPersonDetected.Text = "1234 123456 1 123 - Lucky Valentino Wuntu";
            this.lblPersonDetected.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 562);
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.lblPersonDetected);
            this.Controls.Add(this.lblAttendanceStatus);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblAttendanceStatusStts;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lblIDOnScreen;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAttendedName;
        private System.Windows.Forms.Label lblAttendedIDStts;
        private System.Windows.Forms.Label lblNameOnScreenStts;
        private System.Windows.Forms.Label lblAttendedNameStts;
        private System.Windows.Forms.Label lblIDOnScreenStts;
        private System.Windows.Forms.Label lblNameOnScreen;
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
        private System.Windows.Forms.Label lblFaceCounter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFaceStored;
        private System.Windows.Forms.Button btnAddFace;
        private System.Windows.Forms.Panel pnlMonitor;
        private System.Windows.Forms.Label lblAddFaceWarn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuHadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuPulang;
        private System.Windows.Forms.Button lblPersonDetected;
    }
}

