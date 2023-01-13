using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples
{
    class SpecialUser : Users
    {
        //  public override void UrunBak(Urun urun) { }
        public override double FiyatGoster()
        {
           return base.FiyatGoster()*0.9;
        }

    }
}
