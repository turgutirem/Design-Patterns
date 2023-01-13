using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityTD
{
    public class Goruntu
    {

        public AGoruntuKaynagi _goruntuKaynagi { set; get; }

        List<AGoruntuKaynagi> goruntuler = new List<AGoruntuKaynagi>();

        public Goruntu( )
        {
            
        }

        public void Sonraki(AGoruntuKaynagi goruntuKaynagi)
        {
            goruntuKaynagi = _goruntuKaynagi;
            _goruntuKaynagi.Sonraki(goruntuKaynagi);
        }

      

    }
}
