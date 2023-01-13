using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaretSitesi
{
    class Musteri : Customer
    {
        public override void UrunBak(Urun urun){ }
        Sepet Sepet = new Sepet();  //müşteri sepete sahip
        public void sepeteEkle(Urun urun) 
        { 
            Sepet.urunEkle(urun);
           
        }
        public Sepet GetSepet()
        {
            return Sepet;
        }
        
    }
}
