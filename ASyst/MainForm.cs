﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

//Extension
using Emgu.CV;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using AForge.Video.DirectShow;
using Emgu.CV.UI;
using Emgu.CV.Face;
using Syncfusion.XlsIO;
using System.Speech.Synthesis;
using Newtonsoft.Json;

using Excel = Microsoft.Office.Interop.Excel;

namespace ASyst
{
    public partial class MainForm : Form
    {
        #region Declaration
        Capture grabber = new Capture();
        Image<Bgr, byte> currentFrame;
        Image<Gray, byte> grayFrame;
        FilterInfoCollection filter;
        FaceRecognizer recognizer;
        Rectangle[] faceDetected;
        List<Rectangle> faces = new List<Rectangle>();
        Image<Gray, byte> faceResult, TrainedFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> trainingNameLabels = new List<string>();
        List<string> trainingIDLabels = new List<string>();
        List<int> trainingImagesID = new List<int>();
        List<string> IDPersons = new List<string>();
        int counterAddFace, counterAbsent = 5, counterScanning, lastUsedColumn;
        string pathDataset = null, IDStored = null, NameStored = null, displayID = null;
        private bool hasCuda = false, recognizing = false;
        public static bool addFace = false;
        public static int faceCounter;
        public static string NameLabel, IDLabel, pathExcel = null;
        DateTime dateNow = DateTime.Now;
        DateTime dateTest = new DateTime(2022, 4, 30, 5, 10, 20);

        // Cascade Declaration
        CudaCascadeClassifier cuda_cascade;
        CascadeClassifier cascade;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        // App on load
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Check if user operating system support NVIDIA CUDA
            hasCuda = CudaInvoke.HasCuda;

            // Initialize Cascade Classifier declaration based on CUDA
            if (hasCuda)
            {
                lblCudaStts.Visible = true;
                cuda_cascade = new CudaCascadeClassifier("haarcascade_frontalface_default.xml");
            }
            else
            {
                cascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
            }

            // Set some path
            pathExcel = Application.StartupPath + "\\report\\" + dateNow.ToString("yyyy-MMMM") + ".xlsx";
            pathDataset = Application.StartupPath + "\\dataset\\";

            // Initialize EmguCV Recognizer using LBPH
            recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 1000.0);

            // Check if directory to save report and dataset exist, if not create one
            if (!Directory.Exists(Application.StartupPath + "\\report"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\report");
            }
            if (!Directory.Exists(Application.StartupPath + "\\dataset"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\dataset");
            }
            if (!Directory.Exists(pathDataset + "bitmap"))
            {
                Directory.CreateDirectory(pathDataset + "bitmap");
            }
            if (!File.Exists(pathDataset + "namelabels.txt"))
            {
                File.CreateText(pathDataset + "namelabels.txt").Close();
            }
            if (!File.Exists(pathDataset + "idlabels.txt"))
            {
                File.CreateText(pathDataset + "idlabels.txt").Close();
            }
            if (!File.Exists(pathDataset + "storedname.txt"))
            {
                File.CreateText(pathDataset + "storedname.txt").Close();
            }
            if (!File.Exists(pathDataset + "storedid.txt"))
            {
                File.CreateText(pathDataset + "storedid.txt").Close();
            }
            if (!File.Exists(pathDataset + "facecount.txt"))
            {
                File.CreateText(pathDataset + "facecount.txt").Close();
            }
            if (File.Exists(pathDataset + "trainingdata.xml"))
            {
                recognizer.Load(pathDataset + "trainingdata.xml");

                string namelabels = File.ReadAllText(pathDataset + "namelabels.txt");
                string idlabels = File.ReadAllText(pathDataset + "idlabels.txt");
                string[] Name = namelabels.Split('%');
                string[] ID = idlabels.Split('%');

                string[] count = Directory.GetFiles(pathDataset + "bitmap", "*", SearchOption.AllDirectories);
                faceCounter = count.Length;
                //faceCounter = Convert.ToInt32(File.ReadAllText(pathDataset + "facecount.txt"));

                for (int l = 0; l < faceCounter; l++)
                {
                    trainingImages.Add(new Image<Gray, byte>(pathDataset + "bitmap\\" + "face" + (l + 1) + ".bmp"));
                    trainingNameLabels.Add(Name[l]);
                    trainingIDLabels.Add(ID[l]);
                    trainingImagesID.Add(l);
                }

                lblFaceCounter.Text = (faceCounter / 10).ToString();
                //MessageBox.Show("Dataset Loaded,\n" + (faceCounter / 10) + " Face Added", "Dataset Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Dataset Created,\nPlease Add Some Face First", "Dataset Created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblFaceCounter.Text = "Empty";
            }

            if (!File.Exists(pathExcel))
            {
                excelCreate();
            }

            //Load all camera device
            try
            {
                filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filter)
                    cbxDevices.Items.Add(filterInfo.Name);
                cbxDevices.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("No Camera Device Detected,\nPlease check your device and re-launch me", "No Device", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxDevices.Text = "No Camera Device Detected";
                cbxDevices.Enabled = false;
            }

            // Get the last row used in excel and more stuff
            excelLoad();

            // Populate monitor data grid with stored name and ID
            try
            {
                string[] name = File.ReadAllText(pathDataset + "storedname.txt").Split('%');
                string[] id = File.ReadAllText(pathDataset + "storedid.txt").Split('%');
    
                if(name.Length > 0)
                {
                    for (int i = 0; i < name.Length - 1; i++)
                    {
                        dtgMonitor.Rows.Add(id[i], name[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("No name stored!");
            }

            // Set date & hour today
            lblDateToday.Text = DateTime.Now.ToString("dd / MM / yyyy");
            lblHourToday.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        // Start button
        private void Start_Click(object sender, EventArgs e)
        {
            // Disable unnecessary button
            btnStart.Enabled = false;
            cbxDevices.Enabled = false;
            lblAddFaceWarn.Visible = false;

            btnAddFace.Enabled = true;

            if (faceCounter > 0)
            {
                btnAuto.Enabled = true;
            }

            grabber.QueryFrame();
            // Application Idle Event Handler
            Application.Idle += new EventHandler(FrameCapture);

        }

        #region CoreFunction
        // Adding Face
        private void AddFace()
        {
            if (hasCuda)
            {
                using (CudaImage<Gray, byte> cuda_grayFrame = new CudaImage<Gray, byte>(grayFrame))
                using (GpuMat region = new GpuMat())
                {
                    cuda_cascade.DetectMultiScale(cuda_grayFrame, region);
                    faceDetected = cuda_cascade.Convert(region);
                }
            }
            else
            {
                grayFrame = grabber.QueryFrame().ToImage<Gray, byte>().Resize(pcbCurrentFrame.Width, pcbCurrentFrame.Height, Inter.Cubic);
                faceDetected = cascade.DetectMultiScale(grayFrame, 1.1, 10, new Size(20, 20), Size.Empty);
            }

            foreach (Rectangle face in faceDetected)
            {
                TrainedFace = currentFrame.Copy(face).Convert<Gray, byte>();
                break;
            }

            TrainedFace = faceResult.Resize(100, 100, Inter.Cubic);
            trainingImages.Add(TrainedFace);
            trainingImagesID.Add(faceCounter);
            trainingNameLabels.Add(NameLabel);
            trainingIDLabels.Add(IDLabel);

            faceCounter++;
            File.WriteAllText(pathDataset + "facecount.txt", faceCounter.ToString());

            File.WriteAllText(pathDataset + "namelabels.txt", "");
            File.WriteAllText(pathDataset + "idlabels.txt", "");

            pcbRecognized.Image = TrainedFace;

            for (int l = 0; l < faceCounter; l++)
            {
                trainingImages.ToArray()[l].Save(pathDataset + "\\bitmap\\face" + (l + 1) + ".bmp");
                File.AppendAllText(pathDataset + "namelabels.txt", trainingNameLabels.ToArray()[l] + "%");
                File.AppendAllText(pathDataset + "idlabels.txt", trainingIDLabels.ToArray()[l] + "%");
            }

            recognizer.Train(trainingImages.ToArray(), trainingImagesID.ToArray());
            recognizer.Save(pathDataset + "trainingdata.xml");

            lblFaceCounter.Text = (faceCounter / 10).ToString();
        }

        // Capture frame from camera device
        private void FrameCapture(object sender, EventArgs e)
        {
            IDPersons.Add("");
            currentFrame = grabber.QueryFrame().ToImage<Bgr, byte>().Resize(pcbCurrentFrame.Width, pcbCurrentFrame.Height, Inter.Cubic);
            grayFrame = currentFrame.Convert<Gray, byte>();

            if (hasCuda)
            {
                // If Nvidia CUDA Supported
                using (CudaImage<Gray, byte> cuda_grayFrame = new CudaImage<Gray, byte>(grayFrame))
                using (GpuMat region = new GpuMat())
                {
                    cuda_cascade.DetectMultiScale(cuda_grayFrame, region);
                    faceDetected = cuda_cascade.Convert(region);
                    faces.AddRange(faceDetected);
                    FaceDetector(faceDetected);
                }
                ScanningCounter();
                AutoAbsent();
            }
            else
            {
                // If Nvidia CUDA Unsupported
                faceDetected = cascade.DetectMultiScale(grayFrame, 1.1, 10, new Size(100, 100), Size.Empty);
                FaceDetector(faceDetected);
                ScanningCounter();
                AutoAbsent();
            }

            pcbCurrentFrame.Image = currentFrame;

            displayID = "";
            if (lblIDOnScreen.Text == "")
            {
                displayID = "Scanning";
                lblPersonDetected.Text = "Scanning";
            }
            
            IDPersons.Clear();
        }

        // Face Detector and Recognizer using Viola-Jones and LBPH algorithm
        private void FaceDetector(Rectangle[] facelessVoid)
        {
            foreach (Rectangle face in facelessVoid)
            {
                counterScanning = counterScanning + 1;

                faceResult = currentFrame.Copy(face).Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);

                currentFrame.Draw(new Rectangle(face.Location, face.Size), new Bgr(Color.Red), 2);

                try
                {
                    var result = recognizer.Predict(faceResult.Copy().Resize(100, 100, Inter.Cubic));

                    if (result.Label >= 0 && result.Distance < 90)
                    {
                        CvInvoke.PutText(
                        currentFrame,
                        trainingNameLabels.ToArray()[result.Label].Substring(0, trainingNameLabels.ToArray()[result.Label].IndexOf(' ')),
                        new Point(face.X - 2, face.Y - 5),
                        FontFace.HersheyDuplex,
                        0.5,
                        new Bgr(Color.White).MCvScalar);

                        //CvInvoke.PutText(
                        //currentFrame,
                        //trainingIDLabels.ToArray()[result.Label],
                        //new Point(face.X - 2, face.Y - 20),
                        //FontFace.HersheyDuplex,
                        //0.5,
                        //new Bgr(Color.White).MCvScalar);

                        IDStored = trainingIDLabels.ToArray()[result.Label];
                        NameStored = trainingNameLabels.ToArray()[result.Label].Substring(0, trainingNameLabels.ToArray()[result.Label].IndexOf(' '));
                    }else
                    {
                        CvInvoke.PutText(
                        currentFrame,
                        "Unknown",
                        new Point(face.X - 2, face.Y - 5),
                        FontFace.HersheyDuplex,
                        0.5,
                        new Bgr(Color.White).MCvScalar);
                    }

                    lblPersonDetected.Text = IDStored + " - " + NameStored;

                    lblAttendedID.Text = IDStored;
                    lblAttendedName.Text = NameStored;

                    IDPersons[counterScanning - 1] = IDStored;
                    IDPersons.Add("");
                }
                catch
                {
                    continue;
                }
            }
        }

        // Counter before saving attendance record
        private void ScanningCounter()
        {
            counterScanning = 0;

            for (int l = 0; l < faceDetected.Length; l++)
            {
                try
                {
                    displayID = displayID + IDPersons[l] + ", ";
                }
                catch
                {
                    continue;
                }
            }

            lblIDOnScreen.Text = displayID;
        }

        // Saving attendance record and status
        private void AutoAbsent()
        {
            if (recognizing == true)
            {
                tmrScanning.Start();
                if (lblPersonDetected.Text != "Scanning")
                {
                    if (counterAbsent == 0)
                    {
                        excelUpdate(IDStored);
                    }
                    tmrScanning.Start();
                    lblScanningCounter.Visible = true;
                    lblScanningStatus.Text = "Recognizing";
                    lblScanningCounter.Text = counterAbsent.ToString();
                }
                else
                {
                    tmrScanning.Stop();
                    counterAbsent = 5;
                    lblScanningCounter.Visible = false;
                    lblPersonDetected.Text = "Scanning";
                    lblScanningStatus.Text = "Scanning";
                    lblScanningCounter.Text = "Scanning";
                    lblAttendedID.Text = "Scanning";
                    lblAttendedName.Text = "Scanning";
                }
            }
            else if (recognizing == false)
            {
                tmrScanning.Stop();
                lblScanningCounter.Visible = false;
                lblScanningStatus.Text = "Waiting...";
                lblPersonDetected.Text = "Paused";
                lblIDOnScreen.Text = "Paused";
                lblScanningCounter.Text = "Paused";
                lblAttendedID.Text = "Paused";
                lblAttendedName.Text = "Paused";
            }
        }
        #endregion

        #region ResetButtonStyle
        private void btnScanningReset()
        {
            btnScanning.BackColor = Color.Transparent;
            btnScanning.ForeColor = Color.White;
        }

        private void btnMonitorReset()
        {
            btnMonitor.BackColor = Color.Transparent;
            btnMonitor.ForeColor = Color.White;
        }

        private void btnLaporanReset()
        {
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.ForeColor = Color.White;
        }
        #endregion

        #region Drag&Drop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlSidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Button
        private void btnScanning_Click(object sender, EventArgs e)
        {
            btnScanning.BackColor = Color.White;
            btnScanning.ForeColor = Color.FromArgb(0, 122, 204);
            btnMonitorReset();
            btnLaporanReset();

            pnlMonitor.Visible = false;
            lblEffectiveDayWarn.Visible = true;
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            btnMonitor.BackColor = Color.White;
            btnMonitor.ForeColor = Color.FromArgb(0, 122, 204);
            btnScanningReset();
            btnLaporanReset();

            pnlMonitor.Visible = true;
            lblEffectiveDayWarn.Visible = false;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            btnLaporan.BackColor = Color.White;
            btnLaporan.ForeColor = Color.FromArgb(0, 122, 204);
            btnScanningReset();
            btnMonitorReset();
        }

        private void btnAddFace_Click(object sender, EventArgs e)
        {
            pnlMonitor.Visible = false;
            btnScanning.BackColor = Color.White;
            btnScanning.ForeColor = Color.FromArgb(0, 122, 204);
            btnMonitorReset();

            AddNewFace add = new AddNewFace();
            add.ShowDialog();

            if (addFace == true)
            {
                counterAddFace = 21;
                tmrAddFace.Enabled = true;
                pcbRecognized.Visible = true;
            }
        }

        private void btnEffectiveDay_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();

            if(Help.effectiveDay > 0)
            {
                lblEffectiveDayCount.Text = Help.effectiveDay.ToString();
                lblEffectiveDayWarn.Text = "";
                btnStart.Enabled = true;
            }
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            Process.Start(@Application.StartupPath+"\\report");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            counterAbsent = 5;
            if (recognizing == false)
            {
                recognizing = true;
            }
            else if (recognizing == true)
            {
                recognizing = false;
            }
        }
        #endregion

        #region Timer
        private void tmrScanning_Tick(object sender, EventArgs e)
        {
            counterAbsent--;

            if (counterAbsent == -1)
            {
                counterAbsent = 5;
            }
        }

        private void tmrTimeNow_Tick(object sender, EventArgs e)
        {
            lblHourToday.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void tmrAddFace_Tick(object sender, EventArgs e)
        {
            if (counterAddFace > 1)
            {
                counterAddFace -= 1;
                if (counterAddFace % 2 == 0)
                {
                    AddFace();
                }
                else if (counterAddFace == 1)
                {

                    excelAdd();

                    File.AppendAllText(pathDataset + "storedname.txt", NameLabel + "%");
                    File.AppendAllText(pathDataset + "storedid.txt", IDLabel + "%");

                    dtgMonitor.Rows.Add(IDLabel, NameLabel);

                    MessageBox.Show("Done, Hope I Can Recognize Him/Her Later", "Face Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tmrAddFace.Enabled = false;
                    btnAuto.Enabled = true;
                    pcbRecognized.Visible = false;
                    addFace = false;
                }
            }
        }
        #endregion

        #region Excel
        private void excelLoad()
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel not installed properly", "Excel not installed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorksheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Open(pathExcel);
            xlWorksheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            lastUsedColumn = xlWorksheet.UsedRange.Columns.Count;

            void createNewDate()
            {
                lastUsedColumn += 1;

                xlWorksheet.Cells[5, lastUsedColumn].Font.Bold = true;
                xlWorksheet.Cells[6, lastUsedColumn].Font.Bold = true;
                xlWorksheet.Cells[6, lastUsedColumn + 1].Font.Bold = true;
                xlWorksheet.Cells[5, lastUsedColumn].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorksheet.Range[xlWorksheet.Cells[5, lastUsedColumn], xlWorksheet.Cells[5, lastUsedColumn + 1]].Merge();

                xlWorksheet.Cells[5, lastUsedColumn] = dateNow.ToString("MM/dd/yyyy");
                xlWorksheet.Cells[6, lastUsedColumn] = "Datang";
                xlWorksheet.Cells[6, lastUsedColumn + 1] = "Pulang";

                lastUsedColumn += 1;
            }
            
            try
            {
                if (!(dateNow.ToString("MM/dd/yyyy") == xlWorksheet.Cells[5, lastUsedColumn - 1].Value.ToString("MM/dd/yyyy")))
                {
                    createNewDate();
                }
            }
            catch
            {
                createNewDate();
            }

            if(xlWorksheet.Cells[4, 1].Value != null)
            {
                lblEffectiveDayCount.Text = xlWorksheet.Cells[4, 1].Value.ToString();
                lblEffectiveDayWarn.Text = "";

                btnStart.Enabled = true;
            }

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        private void excelAdd()
        {
            Excel.Application xlApp = new Excel.Application();

            int rowToUpdate = faceCounter / 10 + 6;

            if (xlApp == null)
            {
                MessageBox.Show("Excel not installed properly", "Excel not installed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorksheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Open(pathExcel);
            xlWorksheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorksheet.Cells[rowToUpdate, 1] = faceCounter / 10;
            xlWorksheet.Cells[rowToUpdate, 2] = IDLabel;
            xlWorksheet.Cells[rowToUpdate, 3] = NameLabel;
            
            xlWorksheet.Cells[rowToUpdate, 4] = 0;

            xlApp.DisplayAlerts = false;

            xlWorkBook.SaveAs(pathExcel, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        private void excelUpdate(string ID)
        {
            Excel.Application xlApp = new Excel.Application();
            int columnToUpdate = lastUsedColumn - 1, dataGridUpdate = 2, hadir;

            if (xlApp == null)
            {
                MessageBox.Show("Excel not installed properly", "Excel not installed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ckbPulang.Checked)
            {
                columnToUpdate += 1;
                dataGridUpdate += 1;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorksheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Open(pathExcel);
            xlWorksheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for(int n = 7; n < (faceCounter / 10 + 7); n++)
            {
                if(ID == xlWorksheet.Cells[n, 2].Value.ToString())
                {
                    if(counterAbsent == 0)
                    {
                        if(ckbPulang.Checked == false && xlWorksheet.Cells[n, columnToUpdate].Value == null)
                        {
                            hadir = Convert.ToInt32(xlWorksheet.Cells[n, 4].Value) + 1;
                            xlWorksheet.Cells[n, 4] = hadir;
                            xlWorksheet.Cells[n, 5] = xlWorksheet.Cells[4, 1].Value - hadir;
                        }

                        xlWorksheet.Cells[n, columnToUpdate] = DateTime.Now.ToString("HH:mm:ss");
                        dtgMonitor.Rows[n - 7].Cells[dataGridUpdate].Value = DateTime.Now.ToString("HH:mm:ss");


                        lblScanningCounter.Text = "DONE";

                        //string toSpeak = "Scanning Completed";
                        //SpeechSynthesizer speech = new SpeechSynthesizer();
                        //speech.Speak(toSpeak);
                        //speech.Dispose();
                    }
                    else
                    {
                        lblScanningCounter.Text = counterAbsent.ToString();
                    }
                }
            }

            xlApp.DisplayAlerts = false;

            xlWorkBook.SaveAs(pathExcel, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        private void excelCreate()
        {
            Excel.Application xlApp = new Excel.Application();

            string[] name = File.ReadAllText(pathDataset + "storedname.txt").Split('%');
            string[] id = File.ReadAllText(pathDataset + "storedid.txt").Split('%');
            
            if (xlApp == null)
            {
                MessageBox.Show("Excel not installed properly", "Excel not installed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorksheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorksheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorksheet.Range[xlWorksheet.Cells[1, 1], xlWorksheet.Cells[1, 5]].Merge();
            xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 5]].Merge();

            xlWorksheet.Range[xlWorksheet.Cells[5, 1], xlWorksheet.Cells[6, 1]].Merge();
            xlWorksheet.Range[xlWorksheet.Cells[5, 2], xlWorksheet.Cells[6, 2]].Merge();
            xlWorksheet.Range[xlWorksheet.Cells[5, 3], xlWorksheet.Cells[6, 3]].Merge();
            xlWorksheet.Range[xlWorksheet.Cells[5, 4], xlWorksheet.Cells[6, 4]].Merge();
            xlWorksheet.Range[xlWorksheet.Cells[5, 5], xlWorksheet.Cells[6, 5]].Merge();

            xlWorksheet.Columns[1].ColumnWidth = 5;
            xlWorksheet.Columns[2].ColumnWidth = 22;
            xlWorksheet.Columns[3].ColumnWidth = 28;
            xlWorksheet.Columns[4].ColumnWidth = 6;
            xlWorksheet.Columns[5].ColumnWidth = 6;

            xlWorksheet.Cells[1, 1].Font.Bold = true;
            xlWorksheet.Cells[2, 1].Font.Bold = true;
            xlWorksheet.Cells[4, 1].Font.Bold = true;
            xlWorksheet.Cells[4, 2].Font.Bold = true;
            xlWorksheet.Cells[5, 1].Font.Bold = true;
            xlWorksheet.Cells[5, 2].Font.Bold = true;
            xlWorksheet.Cells[5, 3].Font.Bold = true;
            xlWorksheet.Cells[5, 4].Font.Bold = true;
            xlWorksheet.Cells[5, 5].Font.Bold = true;

            xlWorksheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorksheet.Cells[2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            xlWorksheet.Columns[1].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            xlWorksheet.Columns[2].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            xlWorksheet.Cells[1, 1] = "DATA KEHADIRAN GURU & PEGAWAI SD GMIM 2 TONDANO";
            xlWorksheet.Cells[2, 1] = dateNow.ToString("MMMM . yyyy");
            xlWorksheet.Cells[4, 1] = 20;
            xlWorksheet.Cells[4, 2] = "Hari Efektif";
            xlWorksheet.Cells[5, 1] = "No";
            xlWorksheet.Cells[5, 2] = "NIP";
            xlWorksheet.Cells[5, 3] = "Nama";
            xlWorksheet.Cells[5, 4] = "Hadir";
            xlWorksheet.Cells[5, 5] = "Absen";

            if (name.Length > 0)
            {
                for (int i = 0; i < name.Length - 1; i++)
                {
                    xlWorksheet.Cells[i + 7, 1] = (i + 1).ToString();
                    xlWorksheet.Cells[i + 7, 2] = id[i];
                    xlWorksheet.Cells[i + 7, 3] = name[i];

                    xlWorksheet.Cells[i + 7, 4] = 0;
                    xlWorksheet.Cells[i + 7, 5] = xlWorksheet.Cells[4, 1].Value;
                }
            }

            xlApp.DisplayAlerts = false;

            xlWorkBook.SaveAs(pathExcel, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            MessageBox.Show("New Month, new Spreadsheet", "Excel Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
