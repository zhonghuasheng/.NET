using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14Lambda表达式
{
    class Program
    {
        public delegate string PrintDelegate(string str);
        static void Main(string[] args)
        {
            PrintDelegate pd = (str) => str;
            Console.WriteLine(pd("Lambda表达式是从匿名方法中演变而来！"));
            Console.ReadKey();
            #region//总结一下
            /*
             *1、 Lambda表达式可以认为就是匿名方法，只是其使用语法更加简洁。
             *2、（parm）=>expr   其中parm是一个输入参数列表，expr是一个表达式或者一系列语句。
             */
            #endregion
        }
    }
}
