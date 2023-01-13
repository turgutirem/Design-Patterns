using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityTD
{
    class DVI : AGoruntuKaynagi
    {
        
        public override void goster(string goruntu )
        {
            if (goruntu=="DVI")
            {
                Console.WriteLine("dvi");
               
            }
            else
            {
                _goruntuKaynagi.goster(goruntu);
            }
      
           
        }
    }
}
