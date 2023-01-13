using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberSitesi
{
    class Program
    {
        static void Main(string[] args)
        {

            Haber haber = new Haber("10 Kasım Anma Günü"," Saat 9u 5 geçe herkes Ataya saygı duruşunda bulundu.");
            Kullanici kullanici = new Kullanici("12345678910","iremt.151@gmail.com","05467209811");
            SmsGonder smsGonder = new SmsGonder();
            Bildirim bildirim = new Bildirim(smsGonder);
            bildirim.Gonder();
            Bildirim bildirim2 = new Bildirim(new MailGonder());
            bildirim2.Gonder();
            Console.ReadLine();
        }
    }
}
