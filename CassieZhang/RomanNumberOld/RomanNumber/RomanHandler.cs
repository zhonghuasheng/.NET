using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumber
{
    public class RomanHandler
    {
        private static RomanHandler romanHandlerInstance = null;
        private static object obj = new object();
        public static RomanHandler GetInstance()
        {
            if (romanHandlerInstance == null)
            {
                lock (obj)
                {
                    if (romanHandlerInstance == null)
                    {
                        romanHandlerInstance = new RomanHandler();
                    }
                }
            }

            return romanHandlerInstance;
        }

        private List<Roman> romenObjects = null;
        /// <summary>
        /// Private constructor to prepare the romen objects.
        /// </summary>
        private RomanHandler()
        {
            var symbols = new char[7] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            var symbolValues = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };

            romenObjects = new List<Roman>();

            for (int i = 0; i < symbols.Length; i++)
            {
                romenObjects.Add(new Roman
                {
                    Symbol = symbols[i],
                    Value = symbolValues[i],
                    CanRepeat = symbols[i] == 'I' || symbols[i] == 'X' || symbols[i] == 'C' || symbols[i] == 'M'
                });
            }
        }

        /// <summary>
        /// Calculate the symbols value according the given symbol expression.
        /// </summary>
        /// <param name="symbolsExpression">The given symbols expression.</param>
        /// <returns>The calculated symbol value.</returns>
        public int CalculateSymbolsValue(string symbolsExpression)
        {
            int calculateResult = 0;
            if (string.IsNullOrEmpty(symbolsExpression)) return 0;

            char[] symbols = symbolsExpression.ToCharArray();
            Roman currentRoman = null;
            if (symbols.Length == 1)
            {
                currentRoman = romenObjects.FirstOrDefault(x => x.Symbol == symbols[0]);
                if (currentRoman == null)
                {
                    Console.WriteLine(string.Format("The symbol {0} can not be recognized", symbols[0]));
                    return 0;
                }
                calculateResult = romenObjects.FirstOrDefault(x => x.Symbol == symbols[0]).Value;
            }
            else
            {
                for (int i = 0; i < symbols.Length; i += 2)// at first i+=2, if current roman >= next roman, then i--;
                {
                    currentRoman = romenObjects.FirstOrDefault(x => x.Symbol == symbols[i]);
                    if (currentRoman == null)
                    {
                        Console.WriteLine(string.Format("The symbol {0} can not be recognized", symbols[i]));
                        return 0;
                    }

                    if (i >= symbols.Length - 1)// if it is the last symbol, then add the value and return;
                    {
                        calculateResult += currentRoman.Value;
                        break;
                    }

                    Roman nextRoman = romenObjects.FirstOrDefault(x => x.Symbol == symbols[i + 1]);
                    if (nextRoman == null)
                    {
                        Console.WriteLine(string.Format("The symbol {0} can not be recognized", symbols[i+1]));
                        return 0;
                    }

                    if (currentRoman.Value > nextRoman.Value)
                    {
                        calculateResult += currentRoman.Value;
                        i--; // current value > next value, i--
                    }
                    else if (currentRoman.Value == nextRoman.Value)
                    {
                        if (!currentRoman.CanRepeat)
                        {
                            Console.WriteLine(string.Format("The symbol {0} can not be repeat", currentRoman.Symbol));
                            return 0;
                        }

                        int repeatCount = 2;
                        // To handler the scenario that if the symbol expression is like 'MCMMMMIII', the 'M' repeat 4 times but can not be found.
                        if (i > 0)
                        {
                            if (symbols[i - 1] == currentRoman.Symbol)
                            {
                                repeatCount = 3;
                            }
                        }

                        for (int j = i + 2; j < symbols.Length; j++)
                        {
                            if (symbols[j] != currentRoman.Symbol)
                            {
                                break;
                            }

                            repeatCount++;
                            if (repeatCount > 3)
                            {
                                Console.WriteLine(string.Format("The symbol {0} repeats more than three times", currentRoman.Symbol));
                                return 0;
                            }
                        }

                        calculateResult += currentRoman.Value;
                        i--; // if current value = next value and the repeat time <=3, then only add the current value, i--;
                    }
                    else
                    {
                        // if current value < next value, then add the next value - current value to the result and skip the next symbol.
                        calculateResult += nextRoman.Value - currentRoman.Value; 
                    }

                }
            }

            return calculateResult;
        }

    }
}
