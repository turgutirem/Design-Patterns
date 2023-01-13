using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDesign
{
    public class VTIslemleri
    {
        //arayüz tanımla methodları da oraya yaz!..
        private List<Kullanici> kullaniciList;
        private List<Urun> urunList;
        public void UrunKaydet(Urun urun)
        {
            urunList.Add(urun);
        }
        public void KullaniciKaydet(Kullanici kullanici)
        {
            kullaniciList.Add(kullanici);
        }

        private VTIslemleri()
        {
            kullaniciList = new List<Kullanici>();
            urunList = new List<Urun>();
        }
        private static VTIslemleri vT;
        public static VTIslemleri GetVTIslemleri()//static eklemeseydik başka sınıftan erişemiyoruz! ve bu metot dışardan nesne oluşturulamadğı için çağıramıyor ve kullanamıyoruz.
        {
            if (vT == null)
                vT= new VTIslemleri();

            return vT;

        }



    }

}
