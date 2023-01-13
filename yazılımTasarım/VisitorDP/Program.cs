using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorDP
{
    class Program
    {
        //sınıflar o modüle yeni bir davranış(metot/özellik) getirmek istedği zaman visitor kullanılııyor
        //akıllı saatler mesela
        //davranış eklerken var olan sistem bozulsun istemiyoruz!
        //visitor absract veyainterface olmalıdır.!
        //kabul et metodu eklensin visitor tipinde parametresi olsun 

        static void Main(string[] args)
        {
            ITelefon telefon1 = new A_telefon();
            ITelefon telefon2 = new B_telefon();

            IMsg msg = new Sms();
            IMsg msg1 = new Mms();

            telefon1.Accept(msg);
            telefon1.Accept(msg1);
            telefon2.Accept(msg);
            telefon2.Accept(msg1);

            Console.ReadLine();
        }
    }
    interface ITelefon
    {
        void Arama_yap();
        void Accept(IMsg msg);
    }
    class A_telefon : ITelefon
    {
        public void Accept(IMsg msg)
        {
            msg.Visit(this);
        }

        public void Arama_yap()
        {
            Console.WriteLine("A telefon arama yapıyor");
        }
    }
    class B_telefon : ITelefon
    {
        public void Accept(IMsg msg)
        {
            msg.Visit(this);
        }

        public void Arama_yap()
        {
            Console.WriteLine("B telefon arama yapıyor");
        }
    }
    interface IMsg
    {
        //void Visit(A_telefon);
        //void Visit(B_telefon);
        void Visit(ITelefon telefon);
    }

    class Sms : IMsg
    {
        public void Visit(ITelefon telefon)
        {
            if(telefon is A_telefon)
            {
                Console.WriteLine("A telefon sms özelliği açıldı");
            }
            else
            {
                Console.WriteLine("B telefon sms özelliği bulunmuyor");
            }
            
        }
    }
    class Mms : IMsg
    {
        //polimorfizm hali
        /// <summary>
        /// public void Visit(A_telefon telefon)
        /// {Console.WriteLine("A telefon Mms özelliği bulunmuyor");}
        ///  public void Visit(B_telefon telefon)
        ///  { Console.WriteLine("B telefon Mms özelliği açıldı");}
        /// </summary>
        /// <param name="telefon"></param>
        public void Visit(ITelefon telefon)
        {
            if (telefon is A_telefon)
            {
                Console.WriteLine("A telefon Mms özelliği bulunmuyor");
            }
            else
            {
                Console.WriteLine("B telefon Mms özelliği açıldı");
            }
        }
    }

}
