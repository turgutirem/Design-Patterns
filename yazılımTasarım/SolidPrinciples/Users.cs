using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples
{
    public abstract class Users
    {

        public  Sepet sepet = new Sepet();
        public virtual double FiyatGoster() 
        {
           return sepet.SepetHesapla();
        }
        
    }
}
