using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(new ConcreteBuilder());
            Console.WriteLine( director.BuildProduct()) ;
            Console.ReadLine();
        }
    }

    class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        public Product BuildProduct()
        {
           
            _builder.BuildPartA();
            _builder.BuildPartB();
            return _builder.GetProduct();
        }
    }

    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetProduct();
    }
    public class Product
    {
       
    }
    public class ConcreteBuilder : IBuilder
    {
        
        public void BuildPartA()
        {
            Console.WriteLine("Part A build.");
        }

        public void BuildPartB()
        {
            Console.WriteLine("Part B build.");
        }

        public Product GetProduct()
        {
            return new Product();
        }
    }
   

}
