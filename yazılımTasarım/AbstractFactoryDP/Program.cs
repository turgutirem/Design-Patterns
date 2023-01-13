using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {

            Factory1 factory = new Factory1();
            Bilgisayar bilgisayar = new Bilgisayar(factory);
            
            bilgisayar.islmciTak();


            Console.WriteLine("-----");

            factory.islemci();
            
            Console.WriteLine(factory.disk());

            Console.ReadLine();
           

        }
    }
}
