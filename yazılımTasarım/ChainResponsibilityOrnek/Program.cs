using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainResponsibilityOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zİncir olusturma halkaları
            PlayerHandler mp4 = new ConcreteHandlerMp4();
            PlayerHandler mpg = new ConcreteHandlerMpg();
            PlayerHandler avi = new ConcreteHandlerAvi();

            //zincirin halkaları
            //istek sırası

            mp4.sonrakiHandler = mpg;
            mpg.sonrakiHandler = avi;

            //istek zincirin ilk halkasına gidiyor
            mp4.play("video.mpg");
            mp4.play("video.avi");
            mp4.play("video.mp4");
            mp4.play("video.swf");

            Console.Read();

        }
    }
    abstract class PlayerHandler
    {
        protected PlayerHandler _sonrakiHandler;
       public PlayerHandler sonrakiHandler {set { _sonrakiHandler = value; } }
       public abstract void play(string path);
    }
    class ConcreteHandlerMp4 : PlayerHandler
    {
        public override void play(string path)
        {
            if (path.EndsWith(".mp4"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor(mp4 player)..",path);
            }
            else
            {
                if (_sonrakiHandler!=null)
                {
                    _sonrakiHandler.play(path);
                }
            }
        }
    }
    class ConcreteHandlerMpg : PlayerHandler
    {
        public override void play(string path)
        {
            if (path.EndsWith(".mpg"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor(mpg player)..", path);
            }
            else
            {
                if (_sonrakiHandler != null)
                {
                    _sonrakiHandler.play(path);
                }
            }
        }
    }
    class ConcreteHandlerAvi : PlayerHandler
    {
        public override void play(string path)
        {
            if (path.EndsWith(".avi"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor(avi player)..", path);
            }
            else
            {
                Console.WriteLine("gecersiz dosya formatı");
            }
        }
    }
}
