using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IRapor rapor = new CalisanRapor();
            rapor.Display(new WebPlatform());
            IRapor rapor1 = new SatisRapor();
            rapor1.Display(new MobilPlatform());

            Console.ReadLine();
            
        }
    }
}
