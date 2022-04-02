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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            MainForm.settings.Radius = Int32.Parse(txbRadius.Text);
            MainForm.settings.Neighbors = Int32.Parse(txbNeighbors.Text);
            MainForm.settings.GridX = Int32.Parse(txbGridX.Text);
            MainForm.settings.GridY = Int32.Parse(txbGridY.Text);
            MainForm.settings.numCompEigen = Int32.Parse(txbEigenNumCom.Text);
            MainForm.settings.numCompFisher = Int32.Parse(txbFisherNumCom.Text);
            MainForm.settings.ThresholdLPBH = Double.Parse(txbLBPHThreshold.Text);
            MainForm.settings.ThresholdEigen = Double.Parse(txbEigenThreshold.Text);
            MainForm.settings.ThresholdFisher = Double.Parse(txbFisherThreshold.Text);
            MainForm.settings.boolLBPH = rdbLBPH.Checked;
            MainForm.settings.boolEigen = rdbEigen.Checked;
            MainForm.settings.boolFisher = rdbFisher.Checked;

            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbRadius.Text = "1";
            txbNeighbors.Text = "8";
            txbGridX.Text = "8";
            txbGridY.Text = "9";
            txbLBPHThreshold.Text = "5000";
            txbEigenNumCom.Text = "0";
            txbEigenThreshold.Text = "5000";
            txbFisherNumCom.Text = "0";
            txbFisherThreshold.Text = "5000";
            rdbLBPH.Checked = true;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txbRadius.Text = MainForm.settings.Radius.ToString();
            txbNeighbors.Text = MainForm.settings.Neighbors.ToString();
            txbGridX.Text = MainForm.settings.GridX.ToString();
            txbGridY.Text = MainForm.settings.GridY.ToString();
            txbEigenNumCom.Text = MainForm.settings.numCompEigen.ToString();
            txbFisherNumCom.Text = MainForm.settings.numCompFisher.ToString();
            txbLBPHThreshold.Text = MainForm.settings.ThresholdLPBH.ToString();
            txbEigenThreshold.Text = MainForm.settings.ThresholdEigen.ToString();
            txbFisherThreshold.Text = MainForm.settings.ThresholdFisher.ToString();
            rdbLBPH.Checked = MainForm.settings.boolLBPH;
            rdbEigen.Checked = MainForm.settings.boolEigen;
            rdbFisher.Checked = MainForm.settings.boolFisher;
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
