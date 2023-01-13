using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaretSitesi
{
    class Satici : Customer

    {

        public override void UrunBak(Urun urun){ }
        List<Urun> Urunler = new List<Urun>();
        public void urunEkle(Urun urun) 
        {
            Urunler.Add(urun);
        }

    }
}
