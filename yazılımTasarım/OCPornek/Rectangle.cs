using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPornek
{
    public class Rectangle : IAlan
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public Rectangle(double width,double height)
        {
            Width = width;
            Height = height;
        }
        public double AlanHesapla()
        {
            return Width * Height;
        }
    }
}
