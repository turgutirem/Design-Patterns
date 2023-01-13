using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Menu");
            Menu kullanici = new Menu("-kullanici");
            Menu kullaniciEkle = new Menu("-----kullanici ekle");
            Menu kullaniciSil = new Menu("-----kullanici sil");
            Menu kullaniciEkleDetay = new Menu("-----kullanici detay");
            Menu departman = new Menu("-departman");
            Menu saglikDepartmani = new Menu("-----saglik departmanı");

            menu.add(kullanici);
            kullanici.add(kullaniciSil);
            kullanici.add(kullaniciEkle);
            kullanici.add(kullaniciEkleDetay);
            menu.add(departman);
            departman.add(saglikDepartmani);


            menu.BilgiGoster(menu);
            Console.ReadLine();
        }
    }
}
