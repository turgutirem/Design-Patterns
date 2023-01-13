using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberSitesi
{
    public interface IBildirimGonder
    {
        
        void Gonder(Haber haber, Kullanici kullanici);
     
    }
}
