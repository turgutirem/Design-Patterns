using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAbs dbAbs = new DbRefinedAbs(new SqlDb());
            dbAbs.VtConnect();
            dbAbs.VtExecute();
            dbAbs = new DbRefinedAbs(new OracleDb());
            dbAbs.VtConnect();
            dbAbs.VtExecute();
            Console.Read();
        }
    }
    interface IDbImplentor
    {
        void Execute();
        void Connect();
    }
    class SqlDb : IDbImplentor
    {
        public void Connect()
        {
            Console.WriteLine("Sql bağlandı");
        }

        public void Execute()
        {
            Console.WriteLine("Sql komut çalıştı");
        }
    }
    class OracleDb : IDbImplentor
    {
        public void Connect()
        {
            Console.WriteLine("Oracle bağlandı");
        }

        public void Execute()
        {
            Console.WriteLine("Oracle komut çalıştı");
        }
    }
    abstract class DbAbs
    {
        protected IDbImplentor _dbImplemntor;
       
        public abstract void VtConnect();
        public abstract void VtExecute();
        public DbAbs(IDbImplentor dbImplemntor)
        {
            _dbImplemntor = dbImplemntor;
        }
    }
    class DbRefinedAbs : DbAbs
    {
        public override void VtConnect()
        {
            _dbImplemntor.Connect();
        }

        public override void VtExecute()
        {
            _dbImplemntor.Execute();
        }
        public DbRefinedAbs(IDbImplentor dbImplemntor):base(dbImplemntor)
        {

        }
    }
}
