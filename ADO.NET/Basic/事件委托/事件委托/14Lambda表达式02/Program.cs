using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14Lambda表达式02
{
    class Program
    {
        public delegate void PrintDelegate(string str,int age);
        static void Main(string[] args)
        {
            PrintDelegate pd = (string str,int age) =>
                {
                    Console.WriteLine("我叫{0},今年{1}岁了!",str,age);
                };
            pd("Lambda表达式",14);
            Console.ReadKey();
        }
    }
}
