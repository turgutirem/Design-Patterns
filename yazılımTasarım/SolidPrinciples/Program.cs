using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples
{
    class Program
    {
       // Single responsibility prensibi ->tek sorumluluk ilkesi!! fonk düzeyi/sınıf düzeyi/modüller düzeyi
       //web sitesinde farklı tipte kullanıcılar var ! bazı özellikleri var yok eksik vs.!
       //kullanıcı->mail
       //1.tip kullanıcı->(standart)
       //2.tip kullanıcı->(özel) bu kullanıcı sepete ürün eklediği zaman %10 indirim hakkı olsun!
       //sepet class ürün listesi var
       //ürün class isim fiyat
       //yeniden kullanılabilirlik açısından single r. değerlendirilmeli.
       //soyutlama kallıtım+arayüz üzerinden biz soyutlama kullandık kodda open-closed a uygun oldu yeni user eklenebilir.
       //single r için sınıfın üye elemanlarına bakıcaz!
       //3.müşteriyi eklicezzzzzz
       //single ile open closed ile ilgili örnek yap!!
        static void Main(string[] args)
        {
            StandartUser standartUser = new StandartUser();
            SpecialUser specialUser = new SpecialUser();

            Urun urun1 = new Urun("atkı",500);
            Urun urun2 = new Urun("kazak", 500);

            standartUser.sepet.urunEkle(urun1);
            standartUser.sepet.urunEkle(urun2);

            specialUser.sepet.urunEkle(urun1);
            specialUser.sepet.urunEkle(urun2);

            Console.WriteLine(standartUser.FiyatGoster());
            Console.WriteLine(specialUser.FiyatGoster());
            Console.ReadLine();
        }
    }
}
