using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterDPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class ReportSevice//client
    {
        IReportProducer _reportProducer;
        public ReportSevice(IReportProducer reportProducer )
        {
            _reportProducer = reportProducer;
        }
        public void operation()
        {
            _reportProducer.Operation();
        }
    }
    interface IReportProducer
    {
        void Operation();
    }
    class WordReportAdapter:IReportProducer
    {
        private MicrosoftOffice microsoftOffice;
        public WordReportAdapter()
        {
            microsoftOffice = new MicrosoftOffice();
        }
        public void Operation()
        {
            microsoftOffice.SpecificOperation();
        }
    }
    class MicrosoftOffice
    {
        public void SpecificOperation()
        {
            Console.WriteLine("operation gerçekleştirildi!");
        }
    }
}
