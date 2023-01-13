using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberSitesi
{
    public class Kullanici 
    {
        public string Tc { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }

        
       
        public Kullanici(string _tc,string _mail,string _telefon)
        {
            Tc = _tc;
            Mail = _mail;
            Telefon = _telefon;
        }

    }
}
