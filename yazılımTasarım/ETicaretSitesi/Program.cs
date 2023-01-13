using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaretSitesi
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();
            Urun urun = new Urun("pc",2000);
            Urun urun1 = new Urun("aa", 3000);
            musteri.sepeteEkle(urun);
            musteri.sepeteEkle(urun1);
            Console.WriteLine("sepetin toplam fiyatı: "+musteri.GetSepet().SepetHesapla());
            Console.WriteLine(urun.GetUrun());
            Console.ReadLine();
        }
    }
}
