using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDesign
{
    public class Urun
    {
        public string Isim { get; set; }
        public double Fiyat { get; set; }
       
        public Urun(string isim,double fiyat)
        {
            Isim = isim;
            Fiyat = fiyat;
        }
        
        
    }
}
