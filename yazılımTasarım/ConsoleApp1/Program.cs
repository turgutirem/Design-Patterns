using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovPrinciple
{
    class Program
    {
        //alan ve çevre tasarımı yap üçgen ve kare olacak !! yeni şekiller eklenecek şekilde olucak!!
        static void Main(string[] args)
        {
            Kare kare = new Kare(5);
            Shape shape = new Shape(kare);
            Cember cember = new Cember(5);
            Shape shape2 = new Shape(cember);

            Console.ReadLine();
        }
    }
}
