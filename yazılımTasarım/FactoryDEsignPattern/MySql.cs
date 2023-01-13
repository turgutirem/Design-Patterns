using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDesignPattern
{
    public class MySql : IveriTabani
    {
        public void veriOku()
        {
            Console.WriteLine("mysql verisi okundu");
        }

        public void veriYaz()
        {
            Console.WriteLine("mysql verisi yazıldı");
        }
    }
}
