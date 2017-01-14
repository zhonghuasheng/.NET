using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _11委托中订阅者方法的超时处理02
{
    //public delegate void MyEventHandler(object sender,EventArgs e);
    public class Publisher
    {
        public event EventHandler MyEvent;
        public void DoSomething()
        {
            Console.WriteLine("DoSomething Invoke !");
            if (MyEvent != null)
            {
                Delegate[] delArray = MyEvent.GetInvocationList();
                foreach (Delegate del in delArray)
                {
                    try
                    {
                        EventHandler method = (EventHandler)del;
                        method.BeginInvoke(null, EventArgs.Empty, null, null);
                        //对于多个订阅者注册的情况，必须使用GetInvocationList()获得所有委托对象，
                        ///然后遍历它们，分别在其上调用BeginInvoke()方法
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
            }
        }
    }
    public class Subscriber1
    {
        public void OnEvent(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("Subscriber1 Invoked ! 延迟3秒");
        }
    }
    public class Subscriber2
    {
        public void OnEvent(object sender, EventArgs e)
        {
            throw new Exception("Subscriber2 failed !");
        }
    }
    public class Subscriber3
    {
        public void OnEvent(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Subscriber3 Invoked !延迟2秒");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //初始化对象
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            Subscriber3 sub3 = new Subscriber3();
            //初始化事件
            pub.MyEvent += new EventHandler(sub1.OnEvent);
            pub.MyEvent += new EventHandler(sub2.OnEvent);
            pub.MyEvent += new EventHandler(sub3.OnEvent);
            //调用触发事件的方法
            pub.DoSomething();
            Console.WriteLine("返回控制权");
            Console.WriteLine("press any key to exit");
            Console.ReadLine();

            #region
            /*
             * 1、当我们直接调用委托时，实际上是调用了Invoke()方法，它会中断调用它的客户端，然后在
             *    客户端程序上执行所有订阅者的方法，最后将控制权返回客户端
             * 2、客户端所在的线程通常是主线程，而执行订阅者方法的线程来自线程池，属于后台线程，当
             *    主线程结束时，不论后台线程有没有结束，都会退出程序。
             * 3、本次订阅者中一个停留3秒，一个停留两秒，实际上这两个方法是并行执行的，也就是说最长
             *    的是3秒。
             */
            #endregion
        }
    }
}
