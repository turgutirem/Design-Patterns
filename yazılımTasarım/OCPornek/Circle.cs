using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPornek
{
    public class Circle:IAlan
    {
        public double Radio { get; set; }

        public double AlanHesapla()
        {
            return Radio * Radio * Math.PI;
        }
    }
}
