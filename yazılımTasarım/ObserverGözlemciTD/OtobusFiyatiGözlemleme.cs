using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverGozlemciTD
{
    class OtobusFiyatiGözlemleme
    {
        List<IMusteri> liste;

        private double Fiyat;
        private double _oncekiFiyat;
       
        public OtobusFiyatiGözlemleme(double fiyat)
        {
            liste = new List<IMusteri>();
            Fiyat = fiyat;
            _oncekiFiyat = 50;
        }
        public void ekle(IMusteri musteri)
        {
            liste.Add(musteri);
        }
        public void cikar(IMusteri musteri)
        {
            liste.Remove(musteri);
        }
        public void kontrol()
        {
            if (Fiyat < _oncekiFiyat)
            {
                //...
                haberVer();
            }
            else
            {
                haberVer();
            }
        }

        public void haberVer()
        {
            foreach (var musteri in liste)
            {
                musteri.Update();
            }

        }
    }
}
