using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovPrinciple
{
    public class Shape 
    {
        //bunnu nasıl kullancaz bilmiyorum tam olarak!
        private IShape islem;

        public Shape(IShape _islem)
        {
            islem = _islem;
            
        }
       
    }
}
