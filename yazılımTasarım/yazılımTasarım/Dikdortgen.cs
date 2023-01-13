using System;
using System.Collections.Generic;
using System.Text;

namespace yazılımTasarım
{
    class Dikdortgen : Sekil
    {
        private double kisaKenar ;
        private double uzunKenar ;

        public Dikdortgen(double KisaKenar,double UzunKenar)
        {
            setKenar(KisaKenar, UzunKenar);
        }
        public double AlanHesapla()
        {
            return kisaKenar * uzunKenar; 
        }

        
        public double CevreHesapla()
        {
            return (kisaKenar * 2) + (uzunKenar * 2);
        }
        public double getkisaKenar()
        {
            return kisaKenar;
        }
        public double getkuzunKenar()
        {
            return uzunKenar;
        }
        public void setKenar(double kisaKenarr,double uzunKenarr)
        {
            kisaKenar = kisaKenarr;
            uzunKenar = uzunKenarr;
        }
    }
}
