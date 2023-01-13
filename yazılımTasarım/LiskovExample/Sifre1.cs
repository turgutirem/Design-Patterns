using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovExample
{
    class Sifre1 : ISifrele, ICoz
    {
        public string Coz(string sifre)
        {

            return sifre;
        }

        public string sifrele(string sifre)
        {
            return sifre.Split('%')[0];
        }
    }
}
