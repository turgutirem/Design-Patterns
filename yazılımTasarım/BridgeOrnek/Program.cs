using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoAbsraction videoAbsraction = new VideoRefinedAbs();
            videoAbsraction.VideoMode = new OpenGlMode();
            videoAbsraction.ShowScreen();

            Console.Read();
        }
    }
    interface IVideoMode
    {
       string GetScreen();
    }
    class OpenGlMode : IVideoMode
    {
        const string mode_name = "OpenGL Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0} ",mode_name);
        }
    }
    class Direct3DMode : IVideoMode
    {
        const string mode_name = "Direct 3D Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0} ", mode_name);
        }
    }
    class VideoAbsraction//köprüü
    {
       protected IVideoMode videoMode;
        public IVideoMode VideoMode { set { videoMode = value; } }
        public virtual  void ShowScreen() 
        {
            Console.WriteLine(videoMode.GetScreen());
        }
    
    }
    class VideoRefinedAbs : VideoAbsraction
    {
        public override void ShowScreen()
        {
           
            Console.WriteLine(videoMode.GetScreen());
        }
    }
}
