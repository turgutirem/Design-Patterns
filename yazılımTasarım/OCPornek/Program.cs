using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5,10);
             new AlanHesaplayanSinif(rectangle);
            Circle circle = new Circle();
            circle.Radio = 3;
            new AlanHesaplayanSinif(circle);
            Console.ReadLine();
        }
    }
}
