using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovPrinciple
{
    public class Cember : IShape // class Cember : IShape yerine soldaki gibi yapalım
    {
        //mümkün oldukça arayüzleri ayır diyor Liskov bizlere çok sınıf yazmaktan çekinmeyin de diyor :)
        //cemberin alanı mı var lan it xd 
        //hadi bunu çözelim!
        public const double pi = 3.14;
        private double YariCap { get; set; }
        public Cember(double _yariCap)
        {
            YariCap = _yariCap;
        }
        //public double alan()
        //{
        //    return pi * YariCap * YariCap;
        //}

        public double cevre()
        {
            return 2 * pi * YariCap;
        }
    }
}
