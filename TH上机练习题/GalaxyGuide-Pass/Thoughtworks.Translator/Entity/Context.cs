using System.Collections.Generic;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// The context translated from the input file.
    /// </summary>
    public class Context
    {
        public string IntergalacticUnit { get; set; }
        public Dictionary<string, double> MetalUnitsDefinition { get; set; }
        public Dictionary<string, RomanSymbol> IrregularSymbolsDefinition { get; set; }
        public List<string> Questions { get; set; }
        public ICalculator Calculator { get; set; }

        public Context(ICalculator calculator)
        {
            MetalUnitsDefinition = new Dictionary<string, double>();
            IrregularSymbolsDefinition = new Dictionary<string, RomanSymbol>();
            Questions = new List<string>();
            Calculator = calculator;
        }
    }
}
