using System.Collections.Generic;
using System.Linq;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// Roman symbol utility.
    /// </summary>
    public class RomanSymbolUtility
    {
        private static List<RomanSymbol> Symboles = new List<RomanSymbol>{
                new RomanSymbol("I", 1, "VX", true, true),
                new RomanSymbol("V", 5, string.Empty),
                new RomanSymbol("X", 10, "LC", true, true),
                new RomanSymbol("L", 50, string.Empty),
                new RomanSymbol("C", 100, "DM", true, true),
                new RomanSymbol("D", 500, string.Empty),
                new RomanSymbol("M", 1000, string.Empty, true),
        };

        /// <summary>
        /// Gets whole roman symbol info by symbol.
        /// </summary>
        /// <param name="symbol">Galaxy symbol.</param>
        /// <returns>A Roman symbol object.</returns>
        public static RomanSymbol GetRomanSymbol(string symbol)
        {
            RomanSymbol result = null;
            if (Symboles.Any(o => o.Symbol.Equals(symbol)))
            {
                result = Symboles.Find(o => o.Symbol.Equals(symbol));
            }
            return result;
        }
    }
}
