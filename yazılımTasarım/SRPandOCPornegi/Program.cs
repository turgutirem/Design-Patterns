using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPandOCPornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SRPExampleIsvalidMethod isvalidMethod = new SRPExampleIsvalidMethod();
            CikarmaIslem cikarmaIslem = new CikarmaIslem();
            CarpmaIslem carpmaIslem = new CarpmaIslem();
            SRPOrnekWithPrincipleSum principleSum = new SRPOrnekWithPrincipleSum();

            
            Console.WriteLine(cikarmaIslem.Operation(isvalidMethod,5,4));
            Console.WriteLine(carpmaIslem.Operation(isvalidMethod, 6, 4));
            Console.WriteLine(principleSum.Operation(isvalidMethod, 1, 2));
            

            Console.ReadLine();
             
        }
    }
}
