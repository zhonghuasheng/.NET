using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Remoting.Messaging;


namespace _02DNS异步委托回调
{  
    class Program
    {
        static void Main(string[] args)
        {
            Dns.BeginGetHostAddresses("www.baidu.com", result => { IPAddress[] address = Dns.EndGetHostAddresses(result); Console.WriteLine(address[0]); }, null);
            Console.ReadLine();
        }
    }
}
