using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01委托
{
    //第一步声明委托
    delegate int MyDelegate();
    delegate int MyDelegateNumber(int a,int b);

    class MyClass
    {
        public int M1()
        {
            Console.WriteLine("调用实例方法");
            return 0;
        }
        public static int M2()
        {
            Console.WriteLine("调用静态方法");
            return 0;
        }
    }

    class Add
    {
        public int NumberAdd(int num1,int num2)
        { 
            return(num1+num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClss = new MyClass();
            //实例化委托。非静态方法的调用需要先实例化该类
            MyDelegate myDelete1 = new MyDelegate(myClss.M1);
            Console.WriteLine("委托一");
            myDelete1();
            //静态方法的调用直接用 类名.方法名
            MyDelegate myDelete2;
            myDelete2 = MyClass.M2;//给委托类型的变量赋值
            Console.WriteLine("委托二");
            myDelete2();
            MyDelegate myDelete3 = myDelete1 + myDelete2;
            Console.WriteLine("委托三");
            myDelete3();
            Add myAdd = new Add();
            MyDelegateNumber p = new MyDelegateNumber(myAdd.NumberAdd);
            Console.WriteLine(p(1,2));
            Console.ReadLine();
            #region
            /*
             * 1、委托类似C++中的函数指针，用于通过对方法特征（方法签名）和返回类型的声明，封装了
             *    具有相同特征和返回类型的方法，与指针不同的是委托实例独立于它所封装的方法的类。
             * 2、委托类型隐含为sealed（密封类），是一个引用类型。
             */
            #endregion
        }
    }
}
