using RomanNumber.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RomanNumber.Business;

namespace RomanNumber
{
	public static class Util
	{
        public static Dictionary<string, Roman> RomanNumberMap = new Dictionary<string, Roman>();
        public static Dictionary<string, Product> ProductMap = new Dictionary<string, Product>();

        /// <summary>
        /// Handler the declare lines.
        /// </summary>
        /// <param name="declareLines">The declare lines.</param>
        public static void HandlerDeclareLine(List<string> declareLines)
        {
            RomanHandler romanHandler = new RomanHandler();
            foreach (string declareLine in declareLines)
            {
                string[] split = declareLine.Trim().Split(" ");
                if (split != null && split.Length == 3)
                {
                    if (split[1] == KeyWords.IS)
                    {
                        RomanNumberMap.Add(split[0], RomanCommon.RomanObjs.FirstOrDefault(x => x.Symbol == split[2].ToCharArray()[0]));
                    }
                }
                else if (declareLine.Trim().EndsWith(KeyWords.CREDITS) && split != null && split.Length > 5)
                {
                    string romanString = string.Empty;
                    string productName = split[split.Length - 4];
                    for (int i = 0; i < split.Length - 4; i++)
                    {
                        if (RomanNumberMap[split[i]] != null)
                        {
                            romanString += RomanNumberMap[split[i]].Symbol;
                        }
                    }

                    int totalNum = romanHandler.CalculateSymbolsValue(romanString);
                    double totalValue = Convert.ToDouble(split[split.Length - 2]);
                    double price = 0;
                    if (totalValue > 0 && totalValue > 0)
                    {
                        price = totalValue / totalNum;
                    }
                    Product product = new Product { ProductName = productName, ProductPrice = price };
                    ProductMap.Add(productName, product);
                }
            }
        }

		/// <summary>
		/// Extract the import keyword accoding the line text.
		/// </summary>
		/// <param name="lineText">The line text used get the keyword.</param>
		/// <returns>Return the list of the keyword, contains two kind of keyword, 
		/// the first kind is roman object and the second is product object.</returns>
		public static ArrayList HandlerAnswerLine(string lineText)
		{
			ArrayList result = new ArrayList();
			string romanList = string.Empty;
			string productList = string.Empty;

			string subStringLine = SubStringMainWord(lineText);
			Array characters = subStringLine.Split(" ");

			if (characters.Length > 0)
			{
				foreach (string character in characters)
				{
                    if (RomanNumberMap.Keys.Contains(character))
                    {
                        romanList += RomanNumberMap[character].Symbol;
                    }
                    else if (ProductMap.Keys.Contains(character))
                    {
                        productList += character;
                    }
                    else
                    {
                    }
				}
			}

			result.Add(romanList);
			if (!string.IsNullOrEmpty(productList))
			{
				result.Add(productList);
			}
			return result;
		}

		/// <summary>
		/// Sub string the key word in the line text.
		/// </summary>
		/// <param name="lineText">The line text.</param>
		/// <returns>The substring line text.</returns>
		public static string SubStringMainWord(string lineText)
		{
			int startIndex = lineText.IndexOf(KeyWords.IS) + 2;
			int endIndex = lineText.IndexOf(KeyWords.QUESTIONMARK);
			int length = endIndex - startIndex;
			return lineText.Substring(startIndex, length).Trim();
		}
	}
}
