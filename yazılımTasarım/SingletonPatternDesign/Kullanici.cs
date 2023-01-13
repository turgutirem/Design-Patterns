using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDesign
{
    public class Kullanici
    {
        public string Isim { get; set; }
        List<Kullanici> kullanicis = new List<Kullanici>();
        public Kullanici(string isim)
        {
            Isim = isim;
        }

       
    }
}
