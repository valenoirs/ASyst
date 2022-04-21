using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASyst
{
    public partial class AddNewFace : Form
    {
        public AddNewFace()
        {
            InitializeComponent();
        }

        private void btnAddFace_Click(object sender, EventArgs e)
        {
            if (txbNameLabel.Text.Length < 1)
            {
                MessageBox.Show("Name Cannot Empty ", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txbIDLabel.Text.Length < 1)
            {
                MessageBox.Show("ID Cannot Empty ", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txbIDLabel.Text.Any(char.IsLetter))
            {
                MessageBox.Show("ID Cannot Contain Letter", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //else if (txbIDLabel.Text.Length != 8)
            //{
            //    MessageBox.Show("ID Length Cannot More or Less Than 8 Digits", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            else
            {
                MainForm.addFace = true;
                if (!txbNameLabel.Text.Contains(" "))
                {
                    MainForm.NameLabel = txbNameLabel.Text + " ";
                }
                else
                {
                    MainForm.NameLabel = txbNameLabel.Text;
                }
                MainForm.IDLabel = txbIDLabel.Text;
                this.Dispose();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddNewFace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
