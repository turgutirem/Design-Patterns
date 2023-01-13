using System;

namespace yazılımTasarım
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(KenarUzunlugu: 5);
            Console.WriteLine(kare.AlanHesapla());
            Console.WriteLine("***********************");

            Dikdortgen dikdortgen = new Dikdortgen(KisaKenar: 5.4, UzunKenar: 8.6);
            Console.WriteLine(dikdortgen.AlanHesapla());
            Console.WriteLine(dikdortgen.CevreHesapla());
            Console.WriteLine("***********************");

            Daire daire = new Daire(YariCapp: 4);
            Console.WriteLine(daire.AlanHesapla());
            Console.WriteLine(daire.CevreHesapla());
            Console.WriteLine("***********************");

            Ucgen ucgen = new Ucgen(Taban:6,Yukseklik:8,DigerKenar:10);
            Console.WriteLine(ucgen.AlanHesapla());
            Console.WriteLine(ucgen.CevreHesapla());
            Console.ReadLine();
        }
    }
}
