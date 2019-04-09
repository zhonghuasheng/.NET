using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// Roman Calculator.
    /// </summary>
    public class RomanCalculator : ICalculator
    {
        private List<RomanSymbol> romanSymbols;

        public RomanCalculator()
        {
            romanSymbols = new List<RomanSymbol>();
        }

        /// <summary>
        /// Calculates the Roman to Arabic.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="romanSymbolDefinition">The roman symbol definitions</param>
        /// <returns>Arabic Value</returns>
        public double Calculate(string input, Dictionary<string, RomanSymbol> romanSymbolDefinition)
        {
            Initial(input, romanSymbolDefinition);
            return ConvertToArabic();
        }

        /// <summary>
        /// Converts Roman to Arabic.
        /// </summary>
        /// <returns>Arabic value</returns>
        /// <exception cref="Exception">Format error</exception>
        private double ConvertToArabic()
        {
            double total = 0;
            double previousValue = 0;

            for (int i = 0; i < romanSymbols.Count(); i++)
            {
                RomanSymbol currentSymbol = romanSymbols[i];

                if (i == romanSymbols.Count() - 1)
                {
                    if (i - 1 >= 0)
                    {
                        RomanSymbol previousSymbol = romanSymbols[i - 1];

                        // "D", "L", and "V" can never be repeated.
                        if (currentSymbol.Symbol.Equals(previousSymbol.Symbol) && !currentSymbol.AllowRepeat)
                        {
                            throw new Exception(string.Format(TranslatorConstant.UnRepeatableError, currentSymbol.Symbol));
                        }

                        // Symbols must be placed in order of value, starting with the largest values.
                        if (previousValue != 0 && currentSymbol.ArabicValue > previousValue)
                        {
                            throw new Exception(TranslatorConstant.SymbolOrderError);
                        }
                    }

                    total += currentSymbol.ArabicValue;
                    break;
                }

                RomanSymbol nextSymbol = romanSymbols[i + 1];

                // Only one small value symbol may be subtracted from any large-value symbol.
                if (currentSymbol.ArabicValue < nextSymbol.ArabicValue)
                {
                    // "I" can be subtracted from "V" and "X" only. "X" can be subtracted from "L" and "C" only. 
                    // "C" can be subtracted from "D" and "M" only. "V", "L", and "D" can never be subtracted.
                    if (currentSymbol.AllowSubtracted && currentSymbol.SubtractedFrom.Contains(nextSymbol.Symbol))
                    {
                        previousValue = nextSymbol.ArabicValue - currentSymbol.ArabicValue;
                        total += previousValue;
                        i++;
                    }
                    else
                    {
                        if (!currentSymbol.AllowSubtracted)
                        {
                            throw new Exception(string.Format(TranslatorConstant.SubtractedError,
                                currentSymbol.Symbol));
                        }

                        if (!currentSymbol.SubtractedFrom.Contains(nextSymbol.Symbol))
                        {
                            throw new Exception(string.Format(TranslatorConstant.SubtractedError2,
                                currentSymbol.Symbol, nextSymbol.Symbol));
                        }
                    }
                }
                else
                {
                    // "D", "L", and "V" can never be repeated.
                    if (currentSymbol.ArabicValue == nextSymbol.ArabicValue)
                    {
                        if (!currentSymbol.AllowRepeat)
                        {
                            throw new Exception(string.Format(TranslatorConstant.UnRepeatableError, currentSymbol.Symbol));
                        }
                    }

                    // Symbols must be placed in order of value, starting with the largest values.
                    if (previousValue != 0 && currentSymbol.ArabicValue > previousValue)
                    {
                        throw new Exception(TranslatorConstant.SymbolOrderError);
                    }

                    // The symbols "I", "X", "C", and "M" can be repeated three times in succession, but no more.
                    if (i + 3 < romanSymbols.Count()
                        && currentSymbol.Symbol.Equals(nextSymbol.Symbol)
                        && currentSymbol.Symbol.Equals(romanSymbols[i + 2].Symbol)
                        && currentSymbol.Symbol.Equals(romanSymbols[i + 3].Symbol))
                    {
                        throw new Exception(TranslatorConstant.ThreeTimesLimitError);
                    }

                    previousValue = currentSymbol.ArabicValue;
                    total += previousValue;
                }
            }

            return total;
        }

        /// <summary>
        /// Initials roman symbols.
        /// </summary>
        /// <param name="input">The input text.</param>
        /// <param name="romanSymbolDefinition">The roman symbols</param>
        private void Initial(string input, Dictionary<string, RomanSymbol> romanSymbolDefinition)
        {
            romanSymbols.Clear();
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!romanSymbolDefinition.Keys.Contains(words[i]))
                {
                    throw new Exception(TranslatorConstant.InvalidSymbol);
                }

                romanSymbols.Add(RomanSymbolUtility.GetRomanSymbol(romanSymbolDefinition[words[i]].Symbol));
            }
        }
    }
}
