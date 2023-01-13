using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberSitesi
{
    public class MailGonder :IBildirimGonder
    {
      

        public void Gonder(Haber haber, Kullanici kullanici)
        {
            Console.WriteLine(" mail olarak gonderildi.");
        }
    }
}
