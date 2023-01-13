using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPandOCPornegi
{
    class CarpmaIslem : IOperation
    {
        public int Operation(SRPExampleIsvalidMethod isvalidMethod, int a, int b)
        {
            const string ErrorMessage = "Input is not valid";
           
            if (!isvalidMethod.IsValid(a, b))
                throw new Exception(ErrorMessage);

           // int sonuc = ;
           // Console.WriteLine(sonuc);
            return a * b;
        }
    }
}
