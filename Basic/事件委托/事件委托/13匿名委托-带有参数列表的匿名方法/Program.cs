using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13匿名委托_带有参数列表的匿名方法
{
    class Program
    {
        public delegate void PrintDelegate(string name,int age);
        static void Main(string[] args)
        {
            PrintDelegate pd = delegate(string name,int age)
            {
                Console.WriteLine("大家好我叫{0},今年{1}岁了！",name,age);
            };
            pd("匿名委托-带有参数列表的匿名方法",13);
            Console.ReadKey();
        }
    }
}
