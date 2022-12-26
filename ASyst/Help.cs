using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace ASyst
{
    public partial class Help : Form
    {
        public static int effectiveDay;

        public Help()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txbEffectiveDay.Text.Length < 1)
            {
                MessageBox.Show("Effective day cannot empty!");
                return;
            }

            bool allDigits = txbEffectiveDay.Text.All(char.IsDigit);

            if (!allDigits)
            {
                MessageBox.Show("Effective must a number!");
                return;
            }

            effectiveDay = Convert.ToInt32(txbEffectiveDay.Text);


            if (effectiveDay > 30)
            {
                MessageBox.Show("Effective day must less than 30 days!");
                return;
            }
            if (effectiveDay == 0)
            {
                MessageBox.Show("Effective day must more than 0 day!");
                return;
            }

            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel not installed properly", "Excel not installed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorksheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Open(MainForm.pathExcel);
            xlWorksheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorksheet.Cells[4, 1] = effectiveDay;

            for (int i = 7; i < (MainForm.faceCounter / 10) + 7; i++)
            {
                xlWorksheet.Cells[i, 5] = effectiveDay - Convert.ToInt32(xlWorksheet.Cells[i, 4].Value);
            }

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            this.Dispose();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlNav_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
