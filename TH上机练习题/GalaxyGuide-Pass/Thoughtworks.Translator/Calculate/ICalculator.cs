using System.Collections.Generic;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// ICalculator interface.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Calculates the value of input.
        /// </summary>
        /// <param name="input">The input content.</param>
        /// <param name="romanSymbolDefinition">The roman symbol definitions.</param>
        /// <returns>The calculation result.</returns>
        double Calculate(string input, Dictionary<string, RomanSymbol> romanSymbolDefinition);
    }
}
