using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberSitesi
{
    public class Haber
    {
        //private tanımla
        public string Baslık { get; set; }
        public string Icerik { get; set; }
        public Haber(string _baslik,string _icerik)
        {
            Baslık = _baslik;
            Icerik = _icerik;
        }
    }
}
