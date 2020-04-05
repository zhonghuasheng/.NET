using System;
using System.IO;

namespace RomanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputDataFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "InputData.txt");
            //RomanHandler romanHandlerInstance = RomanHandler.GetInstance();
            //foreach (string line in File.ReadAllLines(inputDataFilePath))
            //{
            //    Console.WriteLine(string.Format("The symbols {0} value is {1}", line, romanHandlerInstance.CalculateSymbolsValue(line)));
            //}
            //Console.ReadKey();

            string lineTest = "how much is pish tegj glob glob ?";
            int startIndex = lineTest.IndexOf("is") + 2;
            int endIndex = lineTest.IndexOf("?");
            int length = endIndex - startIndex;
            string k = lineTest.Substring(startIndex, length);
        }
    }
}
