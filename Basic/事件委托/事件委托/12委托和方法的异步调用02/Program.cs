using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _12委托和方法的异步调用02
{
    public delegate int AddDelegate(int x,int y);
    public class Calculator
    {
        public int Add(int x,int y)
        {
            if(Thread.CurrentThread.IsThreadPoolThread==true)
            {
                Thread.CurrentThread.Name = "线程池";
            }
            //延缓两秒钟
            for (int i = 1; i <= 2;i++ )
            {
                Thread.Sleep(TimeSpan.FromSeconds(i));
                Console.WriteLine("{0}:延缓{1}秒",Thread.CurrentThread.Name,i);
            }
            Console.WriteLine("方法执行完毕");
            return x + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("客户端应用程序开始执行");
            Thread.CurrentThread.Name = "主线程";

            Calculator cal = new Calculator();
            AddDelegate del = new AddDelegate(cal.Add);
            IAsyncResult asr=del.BeginInvoke(2,3,null,null);
            //模拟3秒钟
            for (int i = 1; i <= 3;i++ )
            {
                Thread.Sleep(TimeSpan.FromSeconds(i));
                Console.WriteLine("{0}:客户端线程停留{1}",Thread.CurrentThread.Name,i);
            }
            int result = del.EndInvoke(asr);
            Console.WriteLine("结果：{0}",result);
            Console.WriteLine("结束");

            Console.ReadLine();
        }
    }
}
