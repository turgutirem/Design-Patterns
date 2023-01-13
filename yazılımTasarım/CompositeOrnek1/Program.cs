using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kadro genelMudur = new Kadro("genel Mudur", "İrem");
            Kadro mudur = new Kadro("müdür", "aslı");
            genelMudur.Ekle(mudur);
            mudur.Ekle(new Yazilim("sekreter", "zeynep"));
            mudur.Ekle(new Yazilim("arge", "özge"));//işci gibi
            mudur.Ekle(new Yazilim("sanayi","ilker"));

            genelMudur.Yazdir(1);



            Console.ReadKey();
        }
    }
    public abstract class Sirket//component
    {
        protected string departman;
        protected string isim;

        public Sirket(string _departman, string _isim)
        {
            this.departman = _departman;
            this.isim = _isim;
        }

        public abstract void Ekle(Sirket sirket);
        public abstract void Sil(Sirket sirket);
        public abstract void Yazdir(int satirbasi);
    }
    public class Yazilim : Sirket//leaf
    {
        public Yazilim(string departman,string isim):base(departman,isim) {        }
        public override void Ekle(Sirket sirket){        }

        public override void Sil(Sirket sirket)   {        }

        public override void Yazdir(int satirbasi)
        {
            Console.WriteLine(new string('-', satirbasi) + "> " + isim + " - " + departman);
        }
    }
    public class Kadro : Sirket//composit
    {
        public List<Sirket> liste = new List<Sirket>();
        public Kadro(string departman, string isim):base(departman,isim)
        {

        }
        public override void Ekle(Sirket sirket)
        {
            liste.Add(sirket);
        }

        public override void Sil(Sirket sirket)
        {
            liste.Remove(sirket);
        }

        public override void Yazdir(int satirbasi)
        {
            Console.WriteLine(new string('-',satirbasi) + "> " + isim + " - " + departman);
            foreach (Sirket item in liste)
            {
                item.Yazdir(satirbasi + 2);
            }
        }
    }

}
