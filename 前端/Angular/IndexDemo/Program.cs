using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test[0] = "cassie";
            test[1] = "luke";

            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.ReadKey();
        }
    }

    public class Test
    {
        private string[] name = new string[2];
        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }
}
