using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDesign
{
    public  class Urunkaydet
    {
        //VTIslemleri vtIslemleri = new VTIslemleri();
        public void Kaydet(Urun urun)
        {
            VTIslemleri.GetVTIslemleri().UrunKaydet(urun);
            Console.WriteLine(urun.Isim+" isimli ürün "+urun.Fiyat+" fiyat etiketiyle " + " kaydedildi");

        }
    }
}
