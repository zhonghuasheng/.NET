using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13匿名委托_匿名方法
{
    class Program
    {
        public delegate void PrintDelegate();
        static void Main(string[] args)
        {
            PrintDelegate pd = delegate
            {
                Console.WriteLine("匿名委托-匿名方法");
            };//注意此处大括号后有分号
            pd();
            Console.ReadKey();
            #region//总结一下
            /*1、匿名委托的本质是一个传递给委托的代码块，是使用委托的另一种方法，匿名委托的最大好处在于其减少了系统开销，方法仅在委托使用时才定义。
             * 2、匿名委托中不能使用跳转语句跳至此匿名方法的外部。
             * 3、在匿名方法内不能访问不安全代码，不能在匿名方法的外部定义ref和out参数。
             */
            #endregion
        }
    }
}
