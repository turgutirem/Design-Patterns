using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDp
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsUrun absUrun = new Urun(56, "bilgisayar");
            absUrun.uyeler.Add(new Uye{ mail="irem@irem.com" });
            absUrun.uyeler.Add(new Uye { mail = "gf@gf.com" });

            AbsUrun absUrun1 = new Urun(55646, "hfgbd");
            absUrun1.uyeler.Add(new Uye { mail = "irem@irem.com" });

            absUrun1.Fiyat = 54;
            absUrun.Fiyat = 55;

            Console.ReadKey();

        }
    }
    abstract class AbsUrun
    {
        private decimal _fiyat;
        public List<IUye> uyeler = new List<IUye>(); 
        public string UrunAd { get; set; }
        public AbsUrun(decimal fiyat, string urunAd)
        {
            this._fiyat = fiyat;
            this.UrunAd = urunAd;
        }
        public decimal Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (_fiyat > value)
                {                   
                    _fiyat = value;
                    NotifyUrun();
                }
               
            }

        }


        public  void NotifyUrun()
        {
            foreach (IUye item in uyeler)
            {
                item.Update(this);
            }
        }

    }
    class Urun : AbsUrun
    {
        public Urun(decimal fiyat,string urunAd):base(fiyat,urunAd)
        {

        }
    }
    interface IUye
    {
        void Update(AbsUrun absUrun);
    }
    class Uye : IUye
    {
        public string mail { get; set; }
        public void Update(AbsUrun absUrun)
        {
            Console.WriteLine("{0} ın fiyatı {1} olarak güncellendi ve {2} adresine mail atıldı!",absUrun.UrunAd,absUrun.Fiyat,mail);
        }
    }
}
