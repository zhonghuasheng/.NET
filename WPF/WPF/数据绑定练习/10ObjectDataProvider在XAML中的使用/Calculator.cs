using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10ObjectDataProvider在XAML中的使用
{
    class Calculator
    {
        public string Add(string str1, string str2)
        {
            double x, y, z = 0;
            if (double.TryParse(str1, out x) && double.TryParse(str2, out y))
            {
                z = x + y;
                return z.ToString();
            }
            else
            {
                return "Input Error!";
            }
        }
    }
}
