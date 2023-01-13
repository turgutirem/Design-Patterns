using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Wifi wifi = new Wifi();
            FiveG fiveG = new FiveG();
            Galaxy galaxy = new Galaxy();
            IPad ipad = new IPad();
            Huwaei huwaei = new Huwaei();
            huwaei.accept(wifi);
            galaxy.accept(wifi);
            ipad.accept(fiveG);
            Console.ReadKey();
        }
    }
    
    interface ITablet
    {
        void accept(IVisitor visitor);
    }
    class Huwaei : ITablet
    {
        public void accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class IPad : ITablet
    {
        public void accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Galaxy : ITablet
    {
        public void accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    interface IVisitor//özelliklerin uyumunu sağlıyor
    {
        void Visit(ITablet tablet);
    }
    class Wifi : IVisitor
    {
        public void Visit(ITablet tablet)
        {
            baglan(tablet);
        }
        public void baglan(ITablet tablet)
        {
            Console.WriteLine("Wifiye bağlandı.");
        }
        
    }
    class FiveG : IVisitor
    {
        public void Visit(ITablet tablet)
        {
            ara(tablet, 5);
        }
        public void ara(ITablet tablet, int secenek)
        {
            Console.WriteLine("5G aranıyorr..");
        }
    }
}
