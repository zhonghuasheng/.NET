using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10使用ObjectDataProvider对象作为Binding的Source
{
    class Calculator
    {
        public string Add(string str1, string str2)
        {
            double x,y,z = 0;
            if (double.TryParse(str1, out x) && double.TryParse(str2, out y))
            {
                z = x + y;
                return z.ToString();
            }
            else
            {
                return "Inpurt Error!";
            }
        }
    }
}
