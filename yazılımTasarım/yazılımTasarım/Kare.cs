using System;
using System.Collections.Generic;
using System.Text;

namespace yazılımTasarım
{
    class Kare : Sekil
    {
        private double kenarUzunlugu = 0;
        public Kare(double KenarUzunlugu)
        {
            setKenarUzunlugu(KenarUzunlugu);
        }
        double alan,cevre;
        public double AlanHesapla()
        {
            alan= (kenarUzunlugu * kenarUzunlugu);
            return alan;
        }

        public double CevreHesapla()
        {
            cevre = kenarUzunlugu * 4;
            return cevre ;
        }
        public double getKenarUzunllugu()
        {
            return kenarUzunlugu;
        }
        public void setKenarUzunlugu(double setKenaruzulugu)
        {
            kenarUzunlugu = setKenaruzulugu;
        }
    }
}
