using Emgu.CV.Features2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASyst
{
    public class SettingsComponent
    {
        public int Radius { get; set; }
        public int Neighbors { get; set; }
        public int GridX { get; set; }
        public int GridY { get; set; }
        public int numCompEigen { get; set; }
        public int numCompFisher { get; set; }
        public double ThresholdLPBH { get; set; }
        public double ThresholdEigen { get; set; }
        public double ThresholdFisher { get; set; }
        public bool boolLBPH { get; set; }
        public bool boolEigen { get; set; }
        public bool boolFisher { get; set; }

        public SettingsComponent()
        {
            Radius = 1;
            Neighbors = 8;
            GridX = 8;
            GridY = 9;
            numCompEigen = 0;
            numCompFisher = 0;
            ThresholdLPBH = 5000;
            ThresholdEigen = 5000;
            ThresholdFisher = 5000;
            boolLBPH = true;
            boolEigen = false;
            boolFisher = false;
        }
    }
}
