using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverGozlemciTD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ihaber edilecek sınıf(içinde update metodu var), gözlemlenecek sınıf->list var ıhaber tipinde ,ekle çıkar metodları,kontrol ve  haber ver methodu var haber ver içinde haber edilcek sınıf
            //çağırılıyor! habereddilecek.update() diye kontrol içinde de haber ver çağırılıyor!
            //ıhbaer edilecek implemente edilmiş 2(bu fark etmez sayısı) tane haber edilecek sınıf var
            //
            //otobus fiyatı sınıf olcak içinde list olcak 
            //kişiler haber edilcek
            //otobus firmasında fiyat takibi yapcaz

            OtobusFiyatiGözlemleme otobusFiyatiGözlemleme = new OtobusFiyatiGözlemleme(45);
            IMusteri musteri1 = new Musteri1();
            otobusFiyatiGözlemleme.ekle(musteri1);
            otobusFiyatiGözlemleme.kontrol();
            Console.ReadLine();


        }
    }
}
