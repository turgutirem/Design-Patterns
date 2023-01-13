using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon = new Telefon();
            telefon.tema = new ATemasi();
            telefon.goster();
            telefon.tema = new BTemasi();
            telefon.goster();


            Console.Read();
        }
    }
    //davranış değişikliğinde kullanılıyor aracın hem elektrikli hem benzinli olması
    //telefonun tema değiştirmesi
    class Telefon
    {
        public ITema tema { get; set; }
        public void goster()
        {
            tema.ozellik();
        }
    }
    interface ITema
    {
        void ozellik();
    }
    class ATemasi : ITema
    {
        public void ozellik()
        {
            Console.WriteLine("A teması özellikleri yüklendi.");
        }
    }
    class BTemasi : ITema
    {
        public void ozellik()
        {
            Console.WriteLine("B teması özellikleri yüklendi.");
        }
    }
}
