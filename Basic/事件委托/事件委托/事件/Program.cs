using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 事件
{
    delegate void MyEventHandler(int m,int n);

    class MyEvent
    {
        //声明事件 事件名：active
        public event  MyEventHandler active;
        //触发事件的方法
        public void OnEvent(int m,int n)
        {
            //判断是否有事件被绑定
            if(active!=null)
            {
                active(m,n);//事件发生。格式：事件名（参数）；
            }
        }
    }

    class Program
    {
        static void  Handler(int m,int n)
        {
            Console.WriteLine("事件发生"+(m+n));
        }
        static void Main(string[] args)
        {
           
            MyEvent evt = new MyEvent();
            //将封装Handler方法的委托添加到active事件的列表中
            evt.active += new MyEventHandler(Handler);
            //事件的预定就是向委托的调用列表中添加方法。 事件名 += new 委托名（方法名）；
            //只要事件被触发，委托列表中所预定的方法就会被调用
            //调用触发事件的方法
            evt.OnEvent(3,4);
            Console.ReadLine();


            #region//总结一下
            /*
             * 1、首先声明一个委托，委托的后缀名是EventHandler
             * 2、然后在声明一个事件，事件名就是委托名去掉EventHandler的部分。可以在另一个类中声明
             * 3、写一个触发事件的方法。首先要判断是否有事件被绑定，然后再触发事件
             * 4、写一个方法，用于封装到委托中。
             * 5、将封装方法的委托添加到事件的列表中
             * 6、最后在Main()方法中调用触发事件的方法。事件名.触发事件的方法名（）
             * 7、本程序执行的过程：实例化MyEvent类->注册事件->触发事件的方法OnEvent->判断事件是否为空，否：触发事件->执行委托列表中对应的方法
            */

            #endregion
        }
    }
}
