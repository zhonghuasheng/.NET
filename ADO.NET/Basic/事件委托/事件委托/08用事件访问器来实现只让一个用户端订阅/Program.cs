using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08用事件访问器来实现只让一个用户端订阅
{
    public delegate string GeneralEventHandler();
    public class Publisher
    {
        private event GeneralEventHandler numberChanged;
        public event GeneralEventHandler Numberchanged
        {
            add
            {
                numberChanged = value;
            }
            remove
            {
                numberChanged -= value;
            }
        }
        public void DoSomething()
        { 
            if(numberChanged!=null)
            {
                string str = numberChanged();
                Console.WriteLine(str);
            }
        }
    }
    public class Subscriber1
    {
        public string OnNumberChanged()
        {
            Console.WriteLine("subscriber1 invoke");
            return "subscriber1";
        }
    }
    public class Subscriber2
    {
        public string OnNumberChanged()
        {
            Console.WriteLine("subscriber2 invoke");
            return "subscriber2";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            pub.Numberchanged += sub1.OnNumberChanged;
            pub.Numberchanged += sub2.OnNumberChanged;
          //  pub.Numberchanged -= sub2.OnNumberChanged;
            pub.DoSomething();
            Console.ReadLine();
        }
    }
}
