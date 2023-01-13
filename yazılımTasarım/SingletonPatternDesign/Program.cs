using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDesign
{
    class Program
    {  //veri oku - veri yaz ,hep aynı vt sınıfı kullandıldığından emin olmalıyız.Kullanıcı kayıt oluyor! Kullanici ürün kaydediyor!
        // büyük projelerde kullnaıyoruz  çoğunluklaa
        static void Main(string[] args)
        {
            Urun urun = new Urun("telefon",55);
            Kullanici kullanici = new Kullanici("İrem");
            Urunkaydet urunkaydet = new Urunkaydet();
            Kayitol kayitol = new Kayitol();
            kayitol.kaydet(kullanici);
            urunkaydet.Kaydet(urun);

            Console.ReadLine();

        }
    }
}
