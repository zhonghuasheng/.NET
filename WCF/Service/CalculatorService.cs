using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CalculatorService: ICalculator
    {
        public double Add(double A, double B)
        {
            return A + B;
        }

        public double Subtract(double A, double B)
        {
            return A - B;
        }
    }
}
