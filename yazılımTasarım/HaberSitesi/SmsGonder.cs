using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberSitesi
{
    public class SmsGonder :IBildirimGonder
    {
        public void Gonder(Haber haber, Kullanici kullanici)
        {
           
            Console.WriteLine(" telefonuna sms olarak gönderildi");
        }

    }
}
