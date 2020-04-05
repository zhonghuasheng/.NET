using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09获得多个返回值与异常处理
{
    public delegate string DemoEventHandler(int num);
    public class Publisher
    {
        public event DemoEventHandler NumberChanged;
        public List<string> DoSomething()
        {
            List<string> strList = new List<string>();
            if(NumberChanged==null)
            {
                return strList;
            }
            Delegate[] delArray = NumberChanged.GetInvocationList();
            foreach(Delegate del in delArray)
            {
                DemoEventHandler method = (DemoEventHandler)del;//强制向下转换
                strList.Add(method(100));
            }
            return strList;
        }
    }
    public class Subscriber1
    {
        public string OnNumberChanged(int num)
        {
            Console.WriteLine("subscriber1 invoke,number:{0}",num);
            return "[Subscriber1 returned]";
        }
    }
    public class Subscriber2
    {
        public string OnNumberChanged(int num)
        {
            Console.WriteLine("subscriber2 invoke,number:{0}", num);
            return "[Subscriber2 returned]";
        }
    }
    public class Subscriber3
    {
        public string OnNumberChanged(int num)
        {
            Console.WriteLine("subscriber3 invoke,number:{0}", num);
            return "[Subscriber3 returned]";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            Subscriber3 sub3 = new Subscriber3();
            pub.NumberChanged += new DemoEventHandler(sub1.OnNumberChanged);
            pub.NumberChanged += new DemoEventHandler(sub2.OnNumberChanged);
            pub.NumberChanged += new DemoEventHandler(sub3.OnNumberChanged);
            List<string> list = pub.DoSomething();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
