using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryOrnekBgrup
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorySinif factorySinif = new FactorySinif();
            Isite isite = factorySinif.GetFactory("Asitesi");
            isite.fiyatDondur(5);
            //factorySinif.GetFactory("Asinifi");
           // factorySinif.GetFactory("Asinifi").fiyatDondur(5);
            Console.ReadLine();

        }
    }
}
