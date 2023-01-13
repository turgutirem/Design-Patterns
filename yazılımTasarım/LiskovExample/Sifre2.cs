using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovExample
{
    class Sifre2 : ISifrele
    {
        public string sifrele(string sifre)
        {
            return sifre;
        }
    }
}
