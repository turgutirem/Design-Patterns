using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaretSitesi
{
    class Urun
    {
        public double Fiyat { get; set; }
        public string Isim { get; set; }
        public Urun(string isimm,double fiyatt)
        {
            Fiyat = fiyatt;
            Isim = isimm;
        }
        public String GetUrun()
        {
            
            return Isim;
        }
     
    }
}
