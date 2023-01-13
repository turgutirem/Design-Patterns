using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDesignPattern
{
    public class FactoryVeriTabani
    {
        //public static final int sql = 1;
       public IveriTabani Get(int vt)
       {
            //switch (vt)
            //{
            //    case 1:
            //        return new Oracle();
            //    case 2:
            //        return new MySql();
            //    default:
            //        return new Oracle();
                
            //}
           
            if (vt == 1)
            {
                return new MySql();
            }
            else if (vt == 2)
            {
                return new Oracle();
            }
            else return null;
       }
    }
}
