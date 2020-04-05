using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks;
using MathWorks.MATLAB;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MLApp;

namespace com组件
{
    class Program
    {
        static void Main(string[] args)
        {
            MLApp.MLAppClass mat = new MLApp.MLAppClass();
            mat.Visible = 0;
            StringBuilder command = new StringBuilder();
            command.Append("f=rand(20,20)");
            Console.WriteLine(mat.Execute(command.ToString()));
            Console.ReadKey();
        }
    }
}
