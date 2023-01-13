using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovPrinciple
{
    class Ucgen : IAlan // class Ucgen : IShape
    {
        private double Kenar1 { get; set; }
        private double Kenar2 { get; set; }
        private double Taban { get; set; }
        private double Yukseklik { get; set; }
        public Ucgen(double _kenar1, double _kenar2, double _taban, double _yukseklik)
        {
            Kenar1 = _kenar1;
            Kenar2 = _kenar2;
            Taban = _taban;
            Yukseklik = _yukseklik;
        }
        public double alan()
        {
            return (Taban * Yukseklik) / 2;
        }

        public double cevre()
        {
            return Kenar1 + Kenar2 + Taban;
        }
    }
}
