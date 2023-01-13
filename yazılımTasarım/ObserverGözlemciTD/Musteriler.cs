using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverGozlemciTD
{
    class Musteri1 : IMusteri
    {
       // public string Isim { get; set; }
        

        public void Update()
        {
            Console.WriteLine("Fiyat bilgisi değişti");
        }
    }
}
