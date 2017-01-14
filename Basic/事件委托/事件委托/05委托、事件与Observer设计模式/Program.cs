using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _05委托_事件与Observer设计模式
{
    public delegate void HeateEventHandler(int temp);
    public class Heater
    {
        //定义一个私有字段
        private int temperature;
        public event HeateEventHandler heate;
        public void HeateOnEvent()
        {
            for (int i = 0; i <= 100;i++ )
            {
                temperature = i;
                if(i>96)
                {
                    if(heate!=null)
                    {
                        heate(temperature);
                        Thread.Sleep(5000);
                    }
                }
            }
        }
    
    }
    public class Alarm
    {
        public void MakeAlarm(int temp)
        {
            Console.WriteLine("警报：当前水温{0}度",temp);
        }
    }
    public class Display
    {
        public static void ShowDisplay(int temp)
        {
            Console.WriteLine("显示：水快烧开了，当前温度为{0}",temp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Heater he = new Heater();
            Alarm al = new Alarm();
            he.heate += al.MakeAlarm;
            //给匿名对象注册方法
            //he.heate+=(new Alarm).MakeAlarm;
            he.heate += Display.ShowDisplay;
            he.HeateOnEvent();
            Console.ReadLine();
        }
        #region//总结一下-Observer设计模式
        /*概念：Observer设计模式是为了定义对象间的一种一对多的依赖关系，以便于当一个对象的状态改变                 时，其他依赖于它的对象会被自动告知并更新。Observer模式是一种松耦合的设计模式。
         * 1、什么是耦合？什么是松耦合？什么是紧耦合？
              解释：耦合就是依赖的程度。松耦合就是依赖程度不强，紧耦合就是依赖程度很强。网上找了个
              形象的解释：假如你去麦当劳前台买可乐, 你可以把你和麦当劳工作人员想象为软件的两层或两               个模块.那么你给服务员5块钱,然后他帮你打一杯可乐,你们之间是松耦合的,你们的接口就是5块               钱,你只要给他钱,就不用管他是怎么拿杯子，从哪打的可乐.但是如果你给他5块钱,然后你要自己              去取杯子,去找可乐机,自己排队, 那么你跟麦当劳就是紧密耦合的.
         * 2、Observer设计模式中主要包括两类对象：Subject(监视对象，包含监视者感兴趣的东西)和                    Observer(监视者，当监视的对象中某个事件发生时，监视者就采取行动)。本例中Heate是监视对              象，Alarm和Dispaly是监视者，感兴趣的东西就是温度，当温度超过某一临界值的时候，监视对               象将监视者感兴趣的东西传给监视者，监视者采取行动。
         * 3、匿名对象：一个临时的对象。没有明确给出名字的对象，只在堆内存中开辟空间，在棧内存中没               有引用地址。
         */
        #endregion
    }
}
