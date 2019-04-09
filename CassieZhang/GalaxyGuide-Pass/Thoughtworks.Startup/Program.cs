using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Thoughtworks.Startup
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string FilePathConst = "inputFilePath";

            string inputFilePath = ConfigurationManager.AppSettings[FilePathConst];

            List<string> commands = new List<string>();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string command;
                do
                {
                    command = string.Empty;
                    command = reader.ReadLine();
                    if (command != null && !string.IsNullOrEmpty(command.Trim()))
                    {
                        commands.Add(command);
                    }
                }
                while (command != null);
            }

            Translator.Translator.Translate(commands.ToArray());

            Console.ReadKey();
        }
    }
}
