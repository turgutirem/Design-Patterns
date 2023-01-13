using System;
using System.Collections.Generic;
using System.Text;

namespace yazılımTasarım
{
    class Daire : Sekil
    {
        private static double pi= 3.14;
        private double r,alan,cevre;
        public Daire(double YariCapp)
        {
            setYariCap(YariCapp);
        }
        public double AlanHesapla()
        {
            alan = pi * r * r;
            return alan;
        }

        public double CevreHesapla()
        {
            cevre= 2 * pi * r;
            return cevre;
        }
        public double getYariCap()
        {
            return r;
        }
        public void setYariCap(double yariCap)
        {
            r = yariCap;
        }
    }
}
