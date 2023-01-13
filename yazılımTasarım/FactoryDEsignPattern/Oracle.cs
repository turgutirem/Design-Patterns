using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDesignPattern
{
    public class Oracle:IveriTabani
    {
        public void veriOku()
        {
            Console.WriteLine("oracle verisi okundu");
        }

        public void veriYaz()
        {
            Console.WriteLine("oracle verisi yazıldı");
        }
    }
}
