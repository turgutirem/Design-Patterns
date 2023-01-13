using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            Customer customer1 = new Customer
            {
                CashAmount = 463454.54M,
                FullName = "İrem Turgut",
                IdNo = "123456",
                CustomerNumber=151
            };
            Customer customer2 = new Customer
            {
                CashAmount = 2543676854.54M,
                FullName = "İlker Turgut",
                IdNo = "654321",
                CustomerNumber = 172
            };
            facade.SendEft(customer2, customer1, 87545);
            facade.UseCredit(customer2);

            Console.ReadLine();

        }
    }
    class Facade
    {
        private EFTManager _EFTManager;
        private CreditManager _creditManager;
        public Facade()
        {
            _EFTManager = new EFTManager();
            _creditManager = new CreditManager();
        }
        public void SendEft(Customer fromCustomer, Customer toCustomer, decimal amount)
        {
            _EFTManager.SendEft(fromCustomer, toCustomer, amount);
        }
        public void UseCredit(Customer customer)
        {
            _creditManager.UseCredit(customer);
        }
    }
    class EFTManager
    {
        public void SendEft(Customer fromCustomer,Customer toCustomer,decimal amount)
        {
            if (ControlManager.BakiyeKontrol(fromCustomer,amount))
            {
                fromCustomer.CashAmount -= amount;
                Console.WriteLine("EFT "+toCustomer.CustomerNumber+" no'lu hesaba gönderildi");
            }
            else
            {
                Console.WriteLine("yetersiz bakiye! İşlem gerçekleştirilemedi!!");
            }
        }
    }
    class CreditManager
    {
        public void UseCredit(Customer customer)
        {
            if (ControlManager.KullanilabilirKrediKontrol(customer.IdNo))
            {
                Console.WriteLine("kredi kullandırıldı");
            }
            else
            {
                Console.WriteLine("kredi onaylanmadı");
            }
        }
    }
    public static class ControlManager
    {
        public static bool KullanilabilirKrediKontrol(string IdNo)
        {
            //işlemler yazılsın
            //her zaman true dönmeli
            return true;
        }
        public static bool BakiyeKontrol(Customer customer,decimal amount)
        {
            if (customer.CashAmount>=amount)
            {
                return true;
            }
            else
                return false;
        }
    }
    public class Customer
    {
        public int CustomerNumber{ get; set; }
        public string FullName { get; set; }
        public string IdNo { get; set; }
        public decimal CashAmount { get; set; }
    }

}
