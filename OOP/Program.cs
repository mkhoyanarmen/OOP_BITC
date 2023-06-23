using System;

namespace OOP
{
    class A
    {
        int a = 44; // initializer
        B ob = new B(); // composition
        B ob2; // aggregation
        public A() // default constructor
        {
            Console.WriteLine("AAAAAAA");
        }
    }
    class B
    {
        public B()
        {
            Console.WriteLine("BBBBBBBB");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A ob = new A();
            //A ob2 = new A { a = 55 }; // this is initializer, when (a) variable is public
        }
    }
}
