using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03多重委托
{
    //第一步声明一个委托
    delegate void AddEventHandler(int m,int n);
    class AddNum
    {
        public void Test1(int m,int n)
        {
            Console.WriteLine("非静态方法"+(m+n));
        }
        public static void Test2(int m,int n)
        {
            Console.WriteLine("静态方法"+(m+n));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AddNum myNum = new AddNum();
            //第二步实例化委托
            AddEventHandler myAdd1 = new AddEventHandler(myNum.Test1);
            AddEventHandler myAdd2 = new AddEventHandler(AddNum.Test2);
            //调用委托myAdd2 myAdd1
            myAdd2(1,1);//封装了myNum.Test1（）方法
            myAdd1(2,2);//封装了AddNum.Test2（）
            //多重委托  
            AddEventHandler myAdd3 = myAdd1 + myAdd2;//(1)封装了 myNum.Test1()和AddNum.Test2()方法
            myAdd3(3,3);
            AddEventHandler myAdd4 = myAdd3 - myAdd1;//(2)封装了AddNum.Test2（）
            myAdd4(4,4);
            myAdd1 += myAdd2;//(3)封装了 myNum.Test1（）和AddNum.Test2（）方法
            myAdd1(5,5);
            myAdd3 -= myAdd2;//(4)封装了myNum.Test1（）方法
            myAdd3(6,6);
            Console.ReadLine();
            #region//总结一下-委托的调用与运算
            /*
             *1、委托实例一旦被创建，将始终引用同一目标对象和方法。这样myAdd1实现了对静态方法      AddNum.Test2（）和类的实例化方法myNum.Test1（）的封装。
             *2、当主程序中调用委托的实例时，实际会调用myNum.Test1（）和AddNum.Test2（）方法，这样 就实现了对方法的回调。
             *3、委托实例所封装的方法的集合称为调用列表
             *4、多重委托实质上相当于一个委托实例指向多个方法地址，调用多重委托就会按照调用列表中  的顺序调用多个方法。----实现了C#中的多态
             *5、注意在调用委托的时候还应该传入与委托声明时的参数列表匹配的识记参数，当然这些参数  实际传入了被封装的方法，这也就要求我们在声明委托和添加方法的时候格式要对应
             *6、委托运算符
             *    +：将两个委托实例的调用列表组合起来，产生一个新的委托。如（1）
             *    -：从一个委托的调用列表中移除另一个委托的列表项，产生一个新的委托。如（2）
             *    +=：将一个委托的调用列表合并到另一个委托的调用列表中，不产生新的委托。如：（3）
             *    -=：从一个委托的调用列表中删除另一个委托的调用列表，不产生新的委托。如：（4）
             *    初始化一个委托后不能第一次就是用+=，将会出现“使用了未赋值的局部变量”
            */
            #endregion
        }
    }
}
