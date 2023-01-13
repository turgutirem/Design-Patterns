using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples
{
   public class Sepet
    {

        List<Urun> urunler = new List<Urun>();
        public Urun UrunGoster(int index)
        {
            return urunler[index];
        }
        public double SepetHesapla()
        {
            double toplam = 0;
            foreach (Urun urun in urunler)
            {
                toplam += urun.Fiyat;
            }
            return toplam;
        }
      
        public void urunEkle(Urun urun)
        {
            urunler.Add(urun);
        }
    }
}
