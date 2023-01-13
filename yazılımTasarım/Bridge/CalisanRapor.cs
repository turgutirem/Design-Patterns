using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class CalisanRapor : IRapor
    {
        //private IPlatform _platform;
        //public IPlatform platform1 {

        //    get { return _platform; }
        //}

        public void Display(IPlatform platform)
        {
           
            Console.Write("Calisan raporu "); platform.goruntule();
        }
    }
}
