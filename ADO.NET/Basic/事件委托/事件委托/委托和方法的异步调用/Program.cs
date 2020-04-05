using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _12委托和方法的异步调用
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client application started !");
            Thread.CurrentThread.Name = "Main Thread";

            Calculator cal = new Calculator();
            int result = cal.Add(2,5);
            Console.WriteLine("Result:{0}",result);
            for (int i = 1; i <= 3;i++ )
            {
                Thread.Sleep(TimeSpan.FromSeconds(i));
                Console.WriteLine("{0}:Client executed{1}seconds",Thread.CurrentThread.Name,i);
            }
            Console.ReadLine();
        }
    }
    public class Calculator
    { 
        public int Add(int x,int y)
        {
            if(Thread.CurrentThread.IsThreadPoolThread==true)
            {
                Thread.CurrentThread.Name = "Pool Thread";
            }
            Console.WriteLine("Method invoked!");
            for (int i = 1; i <= 2;i++ )
            {
                Thread.Sleep(TimeSpan.FromSeconds(i));
                Console.WriteLine("{0}:Add executed{1}seconds.",Thread.CurrentThread.Name,i);
            }
            Console.WriteLine("Method complete !");
            return x + y;
        }
    }
}
