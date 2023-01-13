using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryVeriTabani factory = new FactoryVeriTabani();
            IveriTabani vt = factory.Get(1);
            vt.veriOku();
            vt.veriYaz();
            IveriTabani vt2 = factory.Get(2);
            vt2.veriOku();
            vt2.veriYaz();
            Console.ReadLine();
        }
    }
}
