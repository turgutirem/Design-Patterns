using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterTutarHesapla adapter = new AdapterTutarHesapla();
            string tercih = null;
            Client client = new Client();
            client.OdenecekMeblaHesapla(adapter);
            Console.ReadKey();

        }
    }
    class Client
    {
        public void OdenecekMeblaHesapla(ITutarHesaplayici tutarHesaplayici)
        {
            Console.WriteLine("\n Lütfen fiyat giriniz.\n");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Lütfen miktarı giriniz.\n");
            double miktar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Tutar= "+tutarHesaplayici.Hesapla(fiyat,miktar));
            Console.WriteLine();
        }
    }
    class AdapteeIskontoHesapla
    {
        public double IskontoHesapla(double fiyat,double adet)
        {
            Console.WriteLine("\n Lütfen iskonto mitarını giriniz.\n");
            double iskonto = Convert.ToDouble(Console.ReadLine());
            return fiyat * adet * (1 - iskonto);
        }
    }
    interface ITutarHesaplayici
    {
        double Hesapla(double fiyat, double adet);
    }
    class AdapterTutarHesapla : ITutarHesaplayici
    {

        private AdapteeIskontoHesapla adaptee;
        public AdapterTutarHesapla()
        {
            adaptee = new AdapteeIskontoHesapla();
        }
        public double Hesapla(double fiyat, double adet)
        {
            return adaptee.IskontoHesapla(fiyat, adet);
        }
    }
}
