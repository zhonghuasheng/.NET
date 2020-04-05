using RomanNumber.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumber
{
    public static class Helper
    {
        private static readonly string glob = "I";
        private static readonly string prok = "V";
        private static readonly string pish = "X";
        private static readonly string tegj = "L";
        private static readonly string Silver = "[Silver]";
        private static readonly string Gold = "[Gold]";
        private static readonly string Iron = "Iron";

        //Product SilverProduct = new Product { ProductName = "Silver", Price = 17 };
        //Product GoldProduct = new Product() { ProductName = "Gold", Price = 14450 };
        //Product IronProduct = new Product() { ProductName = "Iron", Price = 195.5 };

        public static string HandlerLine(string lineTest)
        {
            string result = null;
            int startIndex = lineTest.IndexOf("is") + 2;
            int endIndex = lineTest.IndexOf("?");
            int length = endIndex - startIndex;
            string subStringLine = lineTest.Substring(startIndex, length);
            Array characters = subStringLine.Split(' ');
            if (characters.Length > 0)
            {
                foreach (string character in characters)
                {
                    switch (character)
                    {
                        case "glob":
                            result += glob;
                            break;
                        case "prok":
                            result += prok;
                            break;
                        case "pish":
                            result += pish;
                            break;
                        case "tegj":
                            result += tegj;
                            break;
                        case "Silver":
                            result += Silver;
                            break;
                        case "Gold":
                            result += Gold;
                            break;
                        case "Iron":
                            result += Iron;
                            break;
                        default:
                            break;
                    }
                }
            }

            return result;
        }
    }
}
