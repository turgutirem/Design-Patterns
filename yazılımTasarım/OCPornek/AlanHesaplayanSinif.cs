using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPornek
{
    public class AlanHesaplayanSinif
    {
        IAlan alan;
        public AlanHesaplayanSinif(IAlan _alan)
        {
            alan = _alan;
           Console.WriteLine( _alan.AlanHesapla());
        }

    }
}
