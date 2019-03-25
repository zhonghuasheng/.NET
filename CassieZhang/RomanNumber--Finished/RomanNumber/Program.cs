using RomanNumber.Business;
using RomanNumber.Model;
using System;
using System.Collections;
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
            List<string> declareLines = new List<string>();
			using (StreamReader streamReader = new StreamReader(inputDataFilePath))
			{
				string line;
				while (!string.IsNullOrEmpty((line = streamReader.ReadLine())))
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
                    else
                    {
                        declareLines.Add(line);
                    }

					Console.WriteLine(line);
				}
			}

			Console.WriteLine("\r\nPlease wait......\r\n");

            Util.HandlerDeclareLine(declareLines);

			#region Output the need answer lines.
			RomanHandler romanHandler = new RomanHandler();
			foreach (string needAnswerLine in needAnswerLines)
			{
				ArrayList result = Util.HandlerAnswerLine(needAnswerLine);
				if (result.Count == 1)
				{
					Console.WriteLine(string.Format("{0} is {1}", Util.SubStringMainWord(needAnswerLine), romanHandler.CalculateSymbolsValue(result[0].ToString())));
				}
				else if (result.Count == 2)
				{
					Product product = Util.ProductMap[result[1].ToString()];

					int productCount = romanHandler.CalculateSymbolsValue(result[0].ToString());
					ProductHandler productHandle = new ProductHandler();
					Console.WriteLine(string.Format("{0} is {1} Credits", Util.SubStringMainWord(needAnswerLine), productHandle.CountProductValue(product, productCount)));
				}
			}
			#endregion

			#region Output the can not handler lines.
			foreach (string canNotHandlerLine in canNotHandlerLines)
			{
				Console.WriteLine("I have no idea what you are talking about");
			}
			#endregion

			Console.ReadKey();
		}
	}
}
