using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovPrinciple
{
    public class Kare:  IAlan //class Kare:IShape yrine
    {
        private double Kenar { get; set; }
        public Kare(double _kenar)
        {
            Kenar = _kenar;
        }
        public double alan()
        {
            
            return Kenar * Kenar;
        }

        public double cevre()
        {
            return Kenar * 4;
        }
    }
}
