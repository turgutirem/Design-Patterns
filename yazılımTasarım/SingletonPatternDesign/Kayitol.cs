using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDesign
{
    public  class Kayitol
    {
      //  VTIslemleri vtIslemleri = new VTIslemleri();
        public  void kaydet(Kullanici kullanici) 
        {
            VTIslemleri.GetVTIslemleri().KullaniciKaydet(kullanici);
            Console.WriteLine(kullanici.Isim+" isimli kullanici" + " kaydedildi");
        }
       
    }
}
