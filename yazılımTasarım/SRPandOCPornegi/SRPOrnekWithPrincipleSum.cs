using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPandOCPornegi
{
    class SRPOrnekWithPrincipleSum : IOperation
    {
        //this class is not valid for sr principle we have to seperated the methods
        //let's fix this example!!:)
        //public int Sum(int a,int b)
        //{
        //    if (!IsValid(a, b))
        //        throw new Exception("Input is not valid");
        //    return a + b;
        //}
        //private bool IsValid(int a,int b)
        //{
        //    if (a < 0 || b < 0)
        //        return false;

        //    return true;
        //}


        //this is good with sr principle
        // lets do some oc principle example and add carpma and cıkarma işlem  :))
        //public int Sum(int a, int b) for srp
        //{
        //    const string ErrorMessage = "Input is not valid";
        //    SRPExampleIsvalidMethod isvalidMethod = new SRPExampleIsvalidMethod();
        //    if (!isvalidMethod.IsValid(a, b))
        //        throw new Exception(ErrorMessage);

        //    return a + b;
        //}
        public int Operation(SRPExampleIsvalidMethod isvalidMethod, int a, int b)
        {
            const string ErrorMessage = "Input is not valid";
            
            if (!isvalidMethod.IsValid(a, b))
                throw new Exception(ErrorMessage);

           // int sonuc = a + b;
           // Console.WriteLine(sonuc);
            return a + b;
        }
    }
}
