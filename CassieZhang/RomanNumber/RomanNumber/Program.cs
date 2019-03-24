using System;
using System.Collections.Generic;
using System.IO;

namespace RomanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDataFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "InputData.txt");
            List<string> needAnswerLines = new List<string>();
            List<string> canNotHandlerLines = new List<string>();
            using (StreamReader streamReader = new StreamReader(inputDataFilePath))
            {
                string line = streamReader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    if (line.Contains(" ?"))
                    {
                        if (line.Contains(" is "))
                        {
                            needAnswerLines.Add(line);
                        }
                        else
                        {
                            canNotHandlerLines.Add(line);
                        }
                    }
                }
            }

            foreach (string line in needAnswerLines)
            {
                string result = Helper.HandlerLine(line);

            }
        }
    }
}
