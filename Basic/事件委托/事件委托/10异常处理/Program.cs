using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10异常处理
{
    public delegate void MyEventHandler(object sender,EventArgs e);
    public class Publisher
    {
        public event MyEventHandler MyEvent;
        public void DoSomething()
        {
            if (MyEvent != null)
            {
                try
                {
                    MyEvent(this,EventArgs.Empty);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception:{0}",e.Message);
                }
            }
        }
    }
    public class Subscriber1
    {
        public void OnEvent(object sender,EventArgs e) 
        {
            Console.WriteLine("Subscriber1 Invoked !");
        }
    }
    public class Subscriber2
    {
        public void OnEvent(object sender,EventArgs e)
        {
            throw new Exception("Exception2 Failed");
            //捕获异常，使得程序没有异常结束，但是却影响到了后面的订阅者的执行
        }
    }
    public class Subscriber3
    {
        public void OnEvent(object sender,EventArgs e)
        {
            Console.WriteLine("Subscriber3 Invoked!");
        }
    }
    class Program
    {
        static void Main(string [] args)
        {
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            Subscriber3 sub3 = new Subscriber3();
            pub.MyEvent += new MyEventHandler(sub1.OnEvent);
            pub.MyEvent += new MyEventHandler(sub2.OnEvent);
            pub.MyEvent += new MyEventHandler(sub3.OnEvent);
            pub.DoSomething();
            Console.ReadKey();
        }
    }
 
}
