using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityTD
{
    class VGA : AGoruntuKaynagi
    {
        public override void goster( string goruntu)
        {


            if (goruntu == "vga")
            {
                Console.WriteLine("vga");
                   
            }
            else
            {
                 _goruntuKaynagi.goster(goruntu);
            }

        }
    }
}
