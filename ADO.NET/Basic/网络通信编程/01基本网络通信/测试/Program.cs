using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;


namespace 测试
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断IP地址
            //Console.WriteLine("dagadggag");
            //string pattrn = @"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))))";
            //string a = Console.ReadLine();
            //if (System.Text.RegularExpressions.Regex.IsMatch(a, pattrn))
            //{
            //    //string ip = IPAddress.Parse(a);
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("cuowu");
            //}
            //Console.ReadKey();

            //判断数字
             Console.WriteLine("dagadggag");
             string pattrn = @"^[-]?\d+[.]?\d*$";
            string a = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(a, pattrn))
            {
                //string ip = IPAddress.Parse(a);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("cuowu");
            }
            Console.ReadKey();

            
        }
    }
}
