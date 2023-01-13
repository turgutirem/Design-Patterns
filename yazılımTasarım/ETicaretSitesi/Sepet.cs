using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaretSitesi
{
    class Sepet
    {
        List<Urun> Urunler = new List<Urun>();
       public double SepetHesapla()
        {
            double toplam = 0;
            foreach (Urun urun in Urunler)
            {
                toplam += urun.Fiyat;
            }
            return toplam;

        }
        public void urunEkle(Urun urun)
        {
            Urunler.Add(urun);
        }
    }
}
