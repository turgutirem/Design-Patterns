using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public interface IRapor
    {
       // IPlatform platform1 { get; }
        void Display(IPlatform platform);
      
    }
}
