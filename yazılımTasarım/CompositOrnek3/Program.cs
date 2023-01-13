using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositOrnek3
{//genel müdürlüğüne bağlı
//müdürlükler, bu müdürlüklere bağlı bölgeler, bölgelere bağlı bayiler ve
//son olarak bu bayilerde çalışan insanlar olduğunu söylüyor
    class Program
    {
        static void Main(string[] args)
        {
            CompositSinif GenelMudurluk = new CompositSinif();

            CompositSinif IcAnadoluGenelMudurluk = new CompositSinif();

            CompositSinif SivasBolgesi = new CompositSinif();
            CompositSinif AnkaraBolgesi = new CompositSinif();

            CompositSinif sivas1 = new CompositSinif();
           

            CompositSinif ankara1 = new CompositSinif();
            CompositSinif ankara2 = new CompositSinif();

            ankara1.Add(new Calisan());
            ankara1.Add(new Calisan());
            ankara1.Add(new Calisan());
            ankara1.Add(new Calisan());

            ankara2.Add(new Calisan());
            ankara2.Add(new Calisan());

            sivas1.Add(new Calisan());

            AnkaraBolgesi.Add(ankara1);
            AnkaraBolgesi.Add(ankara2);
          
            SivasBolgesi.Add(sivas1);
           
            IcAnadoluGenelMudurluk.Add(AnkaraBolgesi);
            IcAnadoluGenelMudurluk.Add(SivasBolgesi);

            GenelMudurluk.Add(IcAnadoluGenelMudurluk);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ankara 1 bayi maliyet "+ankara1.GetMaas().ToString());
            Console.WriteLine("Ankara 2 bayi maliyet " + ankara2.GetMaas().ToString());
            Console.WriteLine("Ankara bölge maliyet " + AnkaraBolgesi.GetMaas().ToString());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Sivas 1 bayi maliyet " + sivas1.GetMaas().ToString());
            Console.WriteLine("Sivas bölge maliyet " + SivasBolgesi.GetMaas().ToString());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("İç Anadolu bölge maliyet " + IcAnadoluGenelMudurluk.GetMaas().ToString());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Genel Müdürlük maliyet(toplam) " + GenelMudurluk.GetMaas().ToString());

            Console.ReadLine();


        }
    }
    //en alttan üste doğru
    //component
    interface ICalisan//soyut çalışan
    {
        int GetMaas();
    }
    //leaf
    class Calisan : ICalisan//somut çalışan
    {
        public int GetMaas()
        {
            return 25;
        }
    }
    //composit
    class CompositSinif : ICalisan//bayi,bölge müdürlükler vs
    {
        List<ICalisan> calisans;
        public CompositSinif()
        {
            calisans = new List<ICalisan>();
        }
        public void Add(ICalisan calisan)
        {
            calisans.Add(calisan);
        }
        public int GetMaas()
        {
            int result = 0;

            foreach (ICalisan calisan in calisans)
            {
                result+= calisan.GetMaas();
            }

            return result;
        }
    }
}
