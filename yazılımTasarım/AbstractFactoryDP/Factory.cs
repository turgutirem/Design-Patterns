using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryDP
{
    //open-closed ve factory dessenini aynı anda uygulabilmek amacı gütmektedir!!
    
    
    //public class Factory
    //{
    //    public Bilgisayar getBilgisayar(string islemci,string disk)
    //    {
    //        if (islemci=="Amd")
    //        {
    //            if (disk == "Hdd")
    //            {
    //                return new Bilgisayar(new Amd(), new Hdd());
    //            }
    //            else if(disk=="Ssd")
    //            {
    //                return new Bilgisayar(new Amd(), new Ssd());
    //            }
    //                return new Bilgisayar(new Amd(), new Nvme());
    //        }
    //        else
    //        {
    //            if (disk == "Hdd")
    //            {
    //                return new Bilgisayar(new Intel(), new Hdd());
    //            }
    //            else if (disk == "Ssd")
    //            {
    //                return new Bilgisayar(new Intel(), new Ssd());
    //            }
    //                return new Bilgisayar(new Intel(), new Nvme());
    //        }
    //    }

    //}
    public interface IIslemci { }
    public class Intel: IIslemci { }
    public class Amd : IIslemci { }
    public interface Idisk { void islemciTak(IIslemci islemci); }
    public class Ssd : Idisk
    {
        public void islemciTak(IIslemci islemci)
        {
            Console.WriteLine(islemci + " islemcili SSD disk");
        }
    }
    public class Hdd : Idisk
    {
        public void islemciTak(IIslemci islemci)
        { 
            Console.WriteLine(islemci + " islemcili HDD disk");
        }
    }
    public class Nvme : Idisk
    {
        public void islemciTak(IIslemci islemci)
        {
            Console.WriteLine(islemci + " islemcili NVME disk");
        }
    }
    public class Bilgisayar
    {
        private IIslemci islemci;
        private Idisk disk;
        public Bilgisayar(IAbsFactory factory)
        {
            islemci = factory.islemci();
            disk = factory.disk();
        }
        public void islmciTak()
        {
            disk.islemciTak(islemci);
        }
    }

    public interface IAbsFactory
    {
        IIslemci islemci();
        Idisk disk();
    }
    public class Factory1 : IAbsFactory
    {
        public Idisk disk()
        {
           return new Hdd();
        }

        public IIslemci islemci()
        {
            return new Amd();
        }
    }
}
