using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MillingApp
{
   public class  MillingParameter
    {
        public static int cutterType { get; set; }
        public static int groupOfStell { get; set; }
        public static int sizeTool { get; set; }
        public static int numberofFlutes { get; set; }
        public static int numberofSizeTool { get; set; }
        public static double diameterTool { get; set; }

        public double resoultN(int Vc)
        {
            return 1000 * Vc / (diameterTool * Math.PI);
        }

        public double resoultVf(double fz, int n)
        {
            return fz * numberofFlutes * n / 1000;
        }
    }   
}
