using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbsFactoryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
         
            DBFactory factory1 =new SqlFactory(new SqlCommand(),new SqlConnection());
            IConnection connection = factory1.CreateConnection();
            //connection.Connect();
           // factory1.CreateConnection();
           
            factory1.CreateCommand();
            


            DBFactory factory2 = new OracleFactory(new OracleCommand(),new OracleConnection());
            factory2.CreateConnection();
            factory2.CreateCommand();
           

            Console.ReadLine();

        }
    }

    abstract class DBFactory
    {
        protected ICommand _command;
        protected IConnection _connection;
        public abstract ICommand CreateCommand();
        public abstract IConnection CreateConnection();
    }

    class SqlFactory : DBFactory
    {
        
        public SqlFactory(ICommand command, IConnection connection)
        {
            _command = command;
            _connection = connection;
        }
        public override ICommand CreateCommand()
        {
            
            _command.Execute();
            return new SqlCommand();
        }

        public override IConnection CreateConnection()
        {
            _connection.Connect();
            return new SqlConnection();
        }
    }
    class OracleFactory : DBFactory
    {
       
        public OracleFactory(ICommand command, IConnection connection)
        {
            _command = command;
            _connection = connection;
        }
        public override ICommand CreateCommand()
        {
            _command.Execute();
            return new OracleCommand();
        }

        public override IConnection CreateConnection()
        {
           _connection.Connect();
            return new OracleConnection();
        }
    }
    interface IConnection { void Connect(); }
    interface ICommand { void Execute(); }
    class SqlConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Sql'e bağlandı");
        }
    }
    class OracleConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Oracle'a bağlandı");
        }
    }
    class SqlCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Sql sorgusu çalıştırıldı");
        }
    }
    class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle sorgusu çalıştırıldı");
        }
    }

}
