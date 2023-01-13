using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberSitesi
{
    public class Bildirim
    { //bu sınıfı düşüncez
        private IBildirimGonder bildirimGonder;
        Haber haber;
        Kullanici kullanici;

        public Bildirim( IBildirimGonder _bildirimGonder)
        {
            bildirimGonder = _bildirimGonder;
        }
        public void Gonder()
        {
            bildirimGonder.Gonder(haber, kullanici);
        }
    }
}
