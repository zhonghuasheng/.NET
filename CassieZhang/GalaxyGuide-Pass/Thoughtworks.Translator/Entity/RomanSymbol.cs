using System.Collections.Generic;
using System.Linq;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// Roman symbol entity.
    /// </summary>
    public class RomanSymbol
    {
        public int ArabicValue { get; set; }
        public string Symbol { get; set; }
        public string SubtractedFrom { get; set; }
        public bool AllowRepeat { get; set; }
        public bool AllowSubtracted { get; set; }

        public RomanSymbol(string symbol, int arabicValue, string subtractedFrom, bool allowRepeat = false, bool allowSubtract = false)
        {
            Symbol = symbol;
            ArabicValue = arabicValue;
            SubtractedFrom = subtractedFrom;
            AllowRepeat = allowRepeat;
            AllowSubtracted = allowSubtract;
        }
    }
}
