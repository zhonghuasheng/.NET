using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey inputkey = Console.ReadKey().Key;
            Char inputchar = Console.ReadKey().KeyChar;
            string getstr = Console.ReadLine();
            var key = Console.Read();



            bool flag;
            switch (inputkey)
            {
                case ConsoleKey.N:
                    flag = true;
                    break;
                case ConsoleKey.Y:
                    flag = false;
                    break;
            }



            switch (inputchar)
            {
                case 'N':
                    flag = true;
                    break;
                case 'Y':
                    flag = false;
                    break;
            }



            switch (getstr)
            {
                case "No":
                    flag = true;
                    break;
                case "Yes":
                    flag = false;
                    break;
            }
        }
    }
}
