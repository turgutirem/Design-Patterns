using System;
using System.Collections.Generic;
using System.Text;

namespace yazılımTasarım
{
    class Ucgen : Sekil
    {
        private double yukseklik, taban,digerKenar;
        public Ucgen(double Taban,double Yukseklik,double DigerKenar)
        {
            setKenar(Taban, Yukseklik, DigerKenar);
        }
        public double AlanHesapla()
        {
            return (taban * yukseklik) / 2;
        }

        public double CevreHesapla()
        {
            return taban + yukseklik + digerKenar;
        }
        public double getYukseklik()
        {
            return yukseklik;
        }
        public double getTaban()
        {
            return taban;
        }
        public double getDigerKenar()
        {
            return digerKenar;
        }
        public void setKenar(double tabann,double yukseklikk,double digerKenarr)
        {
            taban = tabann;
            yukseklik = yukseklikk;
            digerKenar = digerKenarr;
        }
    }
}
