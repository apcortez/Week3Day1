using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day1
{
    class Cerchio
    {
        public double Raggio { get; set; }
        //public int CoordinateX { get; set; }
        //public int CoordinateY { get; set; }

        public Centro Coordinate { get; set; }
        public double CalcoloCirconferenza()
        {
            double circonferenza = 2 * Raggio * Math.PI;
            return circonferenza;
        }
    }

    struct Centro
    {
        public int X;
        public int Y;

    }
}
