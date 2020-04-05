using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06为什么使用事件
{
    //定义委托
    public delegate void NumberChangedEventHandler(int count);
    //定义事件的发布者
    public class Publisher
    {
        //声明一个事件
        public event NumberChangedEventHandler NumberChanged;
        //声明一个委托变量
        //(1)public NumberChangedEventHandler NumberChanged;
        //声明触发事件的方法
        public void DoSomething()
        {
            for (int i = 0; i < 23; i++)
            {
                if (i == 8)
                {
                    if (NumberChanged != null)
                    {
                        NumberChanged(i);
                    }
                }
            }
        }
    }
    //定义事件的订阅者
    public class Subscriber
    {
        public void OnNumberChanged(int count)
        {
            Console.WriteLine("事件订阅者：{0}", count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber sb = new Subscriber();
            Publisher pb = new Publisher();
            pb.NumberChanged += new NumberChangedEventHandler(sb.OnNumberChanged);
            pb.DoSomething();//事件的本意是当事件发布类中的某个行为触发时，引发事件，也就是说当触发事件的方法满足某个条件时触发事件。事件不应该由客户端触发，而是由事件的发布类的内部触发。这样写使事件的发布类的封装性更好。
            //(1)pb.NumberChanged(100);//定义一个委托变量，这里的NumberChanged不是事件
            Console.ReadLine();
        }
    }
}
