using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityTD
{
    class HDMI : AGoruntuKaynagi
    {
        public override void goster(string goruntu)
        {


            if (goruntu == "hdmi")
            {
                Console.WriteLine("hdmi");
                
            }
            else
            {
                 _goruntuKaynagi.goster(goruntu);
            }


        }
    }
}
