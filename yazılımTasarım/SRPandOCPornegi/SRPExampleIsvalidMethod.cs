using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPandOCPornegi
{
    class SRPExampleIsvalidMethod
    {
        public bool IsValid(int a, int b)
        {
            if (a < 0 || b < 0)
                return false;

            return true;
        }
    }
}
