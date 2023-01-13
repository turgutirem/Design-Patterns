using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityTD
{
    public abstract class AGoruntuKaynagi
    {
        protected AGoruntuKaynagi _goruntuKaynagi;
        public void Sonraki(AGoruntuKaynagi goruntuKaynagi)
        {
            _goruntuKaynagi = goruntuKaynagi;

        }
        public abstract void goster(string goruntu);
       
    }
}
