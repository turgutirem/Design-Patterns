using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada facade icinde yer alan tum metotlari kullanmis olduk
            FadaceKismi _fadace = new FadaceKismi();
            _fadace.Acik();//ışık
            _fadace.Kapali();

            _fadace.Kapat();//kapı
            _fadace.Ac();

            _fadace.SicaklikAyari(25);

            Console.ReadLine();
        }
    }
    public class FadaceKismi
    {
        Isik isik = new Isik();
        Kapi kapi = new Kapi();
        Klima klima = new Klima();

        public void Acik()
        {
            isik.Acik();
        }
        public void Kapali()
        {
            isik.Kapali();
        }

        public void Kapat()
        {
            kapi.Kapat();
        }
        public void Ac()
        {
            kapi.Ac();
        }
        public void SicaklikAyari(int sicaklik)
        {
            klima.SicaklikAyari(25);
        }

    }
    public class Klima
    {
        public void SicaklikAyari(int sicaklik)
        {
            Console.WriteLine("{0} dereceye sıcaklık ayarlandı",sicaklik);
        }
    }
    public class Kapi
    {
        public void Kapat()
        {
            Console.WriteLine("kapı kapandı");
        }
        public void Ac()
        {
            Console.WriteLine("kapı açıldı");
        }
    }
    public class Isik
    {
        public void Acik()
        {
            Console.WriteLine("ışık açıldı");
        }
        public void Kapali()
        {
            Console.WriteLine("ışık kapandı");
        }
    }
}
