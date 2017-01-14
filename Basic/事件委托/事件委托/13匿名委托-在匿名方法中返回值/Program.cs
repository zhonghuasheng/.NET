using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13匿名委托_在匿名方法中返回值
{
    class Program
    {
        public delegate int PrintDelegate();
        static void Main(string[] args)
        {
            PrintDelegate pd = delegate
            {
                Console.WriteLine("匿名委托-在匿名方法中返回值");
                return 521;
            };
            int result = pd();
            Console.WriteLine("匿名委托-匿名方法中返回值：{0}",result);
            Console.ReadKey();
        }
    }
}
