using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class SatisRapor : IRapor
    {
        public void Display(IPlatform platform)
        {
           
            Console.Write("Satis raporu "); platform.goruntule();
        }
    }
}
