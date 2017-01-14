using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07让事件只允许一个客户端订阅
{
    public delegate string GenneralEventHandler();
    public class Publisher
    {
        public event GenneralEventHandler NumberChanged;
        public void Register(GenneralEventHandler method)
        {
            //注意这里：此处注册事件采用的是方法，而不再用+=了
            NumberChanged=method;
        }
        public void UnRegister(GenneralEventHandler method)
        {
            NumberChanged-=method;
        }
        public void DoSomething()
        {
            if(NumberChanged!=null)
            {
                string rtn=NumberChanged();
                Console.WriteLine(rtn);
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
            pub.Register(sub1.OnNumberChanged);
            pub.Register(sub2.OnNumberChanged);//输出的是subscriber2
            //pub.UnRegister(sub2.OnNumberChanged);//将其注释去掉，输出为空
            pub.DoSomething();
            Console.ReadLine();
        }
    }
}
