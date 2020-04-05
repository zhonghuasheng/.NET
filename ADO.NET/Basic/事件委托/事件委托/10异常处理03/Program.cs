using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10异常处理03
{
    public delegate void MyEventHandler(object sender,EventArgs e);
    public class Publisher
    {
        public event MyEventHandler MyEvent;
        public void DoSomething()
        {
            Publisher.FireEvent(MyEvent,this,EventArgs.Empty);
        }
        public static object[]FireEvent(Delegate del,params object[]args)
        {
            List<object>objList=new List<object>();
            if(del!=null)
            {
                Delegate[]delArray=del.GetInvocationList();
                foreach(Delegate method in delArray)
                {
                    try
                    {
                        object obj=method.DynamicInvoke(args);
                        if(obj!=null)
                        {
                            objList.Add(obj);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Exception:{0}",e.Message);
                        //此处修改写法
                    }
                }
                
            }
            return objList.ToArray();
        }
    }
    public class Subscriber1
    {
        public void OnEvent(object sender,EventArgs e)
        {
            Console.WriteLine("subscriber1 Invoke !");
        }
    }
    public class Subscriber2
    {
        public static void OnEvent(object sender,EventArgs e)
        {
            throw new Exception("Subscriber2 failed !");
        }
    }
    public class Subscriber3
    {
        public void OnEvent(object sender,EventArgs e)
        {
            Console.WriteLine("Subscriber3 Invoke !");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber3 sub3 = new Subscriber3();

            pub.MyEvent += new MyEventHandler(sub1.OnEvent);
            pub.MyEvent += new MyEventHandler(Subscriber2.OnEvent);
            pub.MyEvent += new MyEventHandler(sub3.OnEvent);

            pub.DoSomething();

            Console.ReadLine();
        }
    }
    
}
