using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples
{
    public class Urun
    {
        public double Fiyat { get; set; }
        public string Isim { get; set; }
        public Urun(string isimm, double fiyatt)
        {
            Fiyat = fiyatt;
            Isim = isimm;
        }
       
    }
}
