using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _11委托中订阅者方法的超时处理
{
    public delegate void MyEventHandler(object sender,EventArgs e);
    public class Publisher
    {
        public event MyEventHandler MyEvent;
        public void DoSomething()
        {
            Console.WriteLine("DoSomething invoke !");
            Program.FireEvent(MyEvent,this,EventArgs.Empty);
        }
    }
    public class Subscriber1
    {
        public void OnEvent(object sender,EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("Wait for 3 seconds ,subscriber1 invoked !");
        }
        
    }
    public class Subscriber2
    {
        public void OnEvent(object sender,EventArgs e)
        {
            Console.WriteLine("Subscriber2 is Invoked !");
        }
    }
    public class Subscriber3
    {
        public void OnEvent(object sender,EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Wait for 2 seconds ,subscriber2 invoked !");
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
            pub.MyEvent += new MyEventHandler(sub1.OnEvent);
            pub.MyEvent += new MyEventHandler(sub2.OnEvent);
            pub.MyEvent += new MyEventHandler(sub3.OnEvent);
            //调用触发事件的方法
            pub.DoSomething();
            Console.WriteLine("返回控制权");
            Console.ReadLine();
        }
        public static object[] FireEvent(Delegate del,params object[]args)
        {
            List<object> objList = new List<object>();
            if(del!=null)
            {
                Delegate[] delArray = del.GetInvocationList();
                foreach(Delegate method in delArray)
                {
                    try
                    {
                        object obj = method.DynamicInvoke(args);
                        if (obj != null)
                        {
                            objList.Add(obj);
                        }
                    }
                    catch { }
                    }
                }
            return objList.ToArray();
            }
        }
    #region//总结一下
    /*
     * 1、在依次执行订阅者方法时，当前线程会转去执行方法中的代码，调用方法的客户端会被中断，
     *    只有当方法全部执行完毕之后，控制权才回到客户端手里。
     * 2、事件的发布者并不关心谁订阅了事件，也不关心订阅者的方法有没有返回值，它只需要在事件
     *    发生的瞬间告知订阅者事件已经发生并将相关的参数传给订阅者就可以了，然后继续执行它后
     *    面的代码，而不是等待订阅者完成后再执行后面的代码。
     */
    #endregion
}
