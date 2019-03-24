using RomanNumber.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumber
{
    public static class RomanCommon
    {
        private static readonly char[] symbols = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        private static readonly int[] numbers = { 1, 5, 10, 50, 100, 500, 1000 };

        private static List<Roman> romanObjs;
        public static List<Roman> RomanObjs
        {
            get { return romanObjs; }
            set
            {
                romanObjs = new List<Roman>();
                for (int i = 0; i < symbols.Length; i++)
                {
                    romanObjs.Add(new Roman
                    {
                        Symbol = symbols[i],
                        Value = numbers[i],
                        CanRepeat = symbols[i] == 'I' || symbols[i] == 'X' || symbols[i] == 'C' || symbols[i] == 'M'
                    });
                }
            }
        }
    }
}
