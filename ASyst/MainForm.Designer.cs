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
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.lblCudaStts = new System.Windows.Forms.Label();
            this.tmrAddFace = new System.Windows.Forms.Timer(this.components);
            this.tmrScanning = new System.Windows.Forms.Timer(this.components);
            this.lblAttendedID = new System.Windows.Forms.Label();
            this.lblAttendanceStatusStts = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.lblIDOnScreen = new System.Windows.Forms.Label();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.lblAutoStts = new System.Windows.Forms.Label();
            this.lblFaceCounter = new System.Windows.Forms.Label();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnScanning = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbCurrentFrame = new Emgu.CV.UI.ImageBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblDevices = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecognized)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentFrame)).BeginInit();
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
            // lblFaceStored
            // 
            this.lblFaceStored.AutoSize = true;
            this.lblFaceStored.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceStored.Location = new System.Drawing.Point(212, 2);
            this.lblFaceStored.Name = "lblFaceStored";
            this.lblFaceStored.Size = new System.Drawing.Size(87, 14);
            this.lblFaceStored.TabIndex = 11;
            this.lblFaceStored.Text = "Face Stored : ";
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
            this.lblCudaStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCudaStts.Location = new System.Drawing.Point(2, 42);
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
            this.lblAttendedID.Location = new System.Drawing.Point(336, 42);
            this.lblAttendedID.Name = "lblAttendedID";
            this.lblAttendedID.Size = new System.Drawing.Size(11, 14);
            this.lblAttendedID.TabIndex = 16;
            this.lblAttendedID.Text = "-";
            // 
            // lblAttendanceStatusStts
            // 
            this.lblAttendanceStatusStts.AutoSize = true;
            this.lblAttendanceStatusStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceStatusStts.Location = new System.Drawing.Point(212, 61);
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
            this.lblAttendanceStatus.Location = new System.Drawing.Point(336, 61);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(11, 14);
            this.lblAttendanceStatus.TabIndex = 20;
            this.lblAttendanceStatus.Text = "-";
            // 
            // lblAutoStts
            // 
            this.lblAutoStts.AutoSize = true;
            this.lblAutoStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoStts.Location = new System.Drawing.Point(3, 61);
            this.lblAutoStts.Name = "lblAutoStts";
            this.lblAutoStts.Size = new System.Drawing.Size(155, 14);
            this.lblAutoStts.TabIndex = 21;
            this.lblAutoStts.Text = "Automate Status :       OFF";
            // 
            // lblFaceCounter
            // 
            this.lblFaceCounter.AutoSize = true;
            this.lblFaceCounter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceCounter.Location = new System.Drawing.Point(336, 2);
            this.lblFaceCounter.Name = "lblFaceCounter";
            this.lblFaceCounter.Size = new System.Drawing.Size(11, 14);
            this.lblFaceCounter.TabIndex = 23;
            this.lblFaceCounter.Text = "-";
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
            this.lblAttendedName.Location = new System.Drawing.Point(336, 22);
            this.lblAttendedName.Name = "lblAttendedName";
            this.lblAttendedName.Size = new System.Drawing.Size(11, 14);
            this.lblAttendedName.TabIndex = 25;
            this.lblAttendedName.Text = "-";
            // 
            // lblAttendedIDStts
            // 
            this.lblAttendedIDStts.AutoSize = true;
            this.lblAttendedIDStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedIDStts.Location = new System.Drawing.Point(212, 42);
            this.lblAttendedIDStts.Name = "lblAttendedIDStts";
            this.lblAttendedIDStts.Size = new System.Drawing.Size(87, 14);
            this.lblAttendedIDStts.TabIndex = 24;
            this.lblAttendedIDStts.Text = "Attended ID : ";
            // 
            // lblAttendedNameStts
            // 
            this.lblAttendedNameStts.AutoSize = true;
            this.lblAttendedNameStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedNameStts.Location = new System.Drawing.Point(212, 22);
            this.lblAttendedNameStts.Name = "lblAttendedNameStts";
            this.lblAttendedNameStts.Size = new System.Drawing.Size(108, 14);
            this.lblAttendedNameStts.TabIndex = 14;
            this.lblAttendedNameStts.Text = "Attended Name : ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblAutoStts);
            this.panel4.Controls.Add(this.lblCudaStts);
            this.panel4.Controls.Add(this.lblAttendedName);
            this.panel4.Controls.Add(this.lblNameOnScreen);
            this.panel4.Controls.Add(this.lblAttendanceStatus);
            this.panel4.Controls.Add(this.lblIDOnScreenStts);
            this.panel4.Controls.Add(this.lblFaceStored);
            this.panel4.Controls.Add(this.lblAttendanceStatusStts);
            this.panel4.Controls.Add(this.lblIDOnScreen);
            this.panel4.Controls.Add(this.lblFaceCounter);
            this.panel4.Controls.Add(this.lblNameOnScreenStts);
            this.panel4.Controls.Add(this.lblAttendedIDStts);
            this.panel4.Controls.Add(this.lblAttendedID);
            this.panel4.Controls.Add(this.lblAttendedNameStts);
            this.panel4.Location = new System.Drawing.Point(382, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 81);
            this.panel4.TabIndex = 28;
            this.panel4.Visible = false;
            // 
            // lblNameOnScreen
            // 
            this.lblNameOnScreen.AutoSize = true;
            this.lblNameOnScreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnScreen.Location = new System.Drawing.Point(111, 20);
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
            this.lblIDOnScreenStts.Location = new System.Drawing.Point(2, 2);
            this.lblIDOnScreenStts.Name = "lblIDOnScreenStts";
            this.lblIDOnScreenStts.Size = new System.Drawing.Size(91, 14);
            this.lblIDOnScreenStts.TabIndex = 20;
            this.lblIDOnScreenStts.Text = "ID On Screen :";
            // 
            // lblNameOnScreenStts
            // 
            this.lblNameOnScreenStts.AutoSize = true;
            this.lblNameOnScreenStts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnScreenStts.Location = new System.Drawing.Point(2, 20);
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
            this.lblHourToday.Location = new System.Drawing.Point(35, 514);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Controls.Add(this.lblDateToday);
            this.panel6.Controls.Add(this.lblHourToday);
            this.panel6.Controls.Add(this.btnLaporan);
            this.panel6.Controls.Add(this.btnMonitor);
            this.panel6.Controls.Add(this.btnScanning);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 562);
            this.panel6.TabIndex = 30;
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.BackColor = System.Drawing.Color.Transparent;
            this.lblDateToday.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblDateToday.ForeColor = System.Drawing.Color.White;
            this.lblDateToday.Location = new System.Drawing.Point(21, 488);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(186, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(264, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Waiting...";
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
            this.btnExit.Location = new System.Drawing.Point(809, -1);
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
            this.btnHide.Location = new System.Drawing.Point(765, -1);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 562);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxDevices);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.panel4);
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
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.Label lblCudaStts;
        private Emgu.CV.UI.ImageBox pcbRecognized;
        private System.Windows.Forms.Label lblFaceStored;
        private System.Windows.Forms.Timer tmrAddFace;
        private System.Windows.Forms.Timer tmrScanning;
        private System.Windows.Forms.Label lblAttendedID;
        private System.Windows.Forms.Label lblAttendanceStatusStts;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lblIDOnScreen;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Label lblAutoStts;
        private System.Windows.Forms.Label lblFaceCounter;
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnScanning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Label lblDateToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox pcbCurrentFrame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lblDevices;
    }
}

