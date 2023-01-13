using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{

    public class Menu
    {

        public List<Menu> menuler;
        private string baslik { get; set; }
        public Menu(string _baslik)
        {
            baslik = _baslik;
            menuler= new List<Menu>();
        }

        public void add(Menu menu)
        {
            menuler.Add(menu);
        }
        public void BilgiGoster(Menu menu)
        {
            Console.WriteLine(baslik);
            foreach (Menu altmenuu in menuler)
            {
                altmenuu.BilgiGoster(menu);
            }
        }

    }
}