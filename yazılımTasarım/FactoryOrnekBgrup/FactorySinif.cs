using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryOrnekBgrup
{
    public class FactorySinif
    {
        public Isite GetFactory(string s)
        {

            
            if (s == "Asitesi")   
                return new Asitesi();
            else if (s == "Bsitesi")
                return new Bsitesi();
            else if (s == "Csitesi")
               return new Csitesi();
            else
                return null;

            
        }

    }
}
