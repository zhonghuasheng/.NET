using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            B a = new B();
            Console.ReadKey();
        }
    }

    class A
    {
        public A()
        {
            Print();
        }

        public virtual void Print() { }
    }

    class B : A
    {
        int x = -1;
        int y = 2;
        public B()
        {
            y = 1;
        }

        public override void Print()
        {
            Console.WriteLine("x = {0}, y={1}", x, y);
        }
    }
}
