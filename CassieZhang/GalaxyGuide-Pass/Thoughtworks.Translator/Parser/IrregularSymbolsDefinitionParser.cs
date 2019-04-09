using System;
using System.Linq;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// Roman Symbol Definition Parser
    /// </summary>
    public class IrregularSymbolsDefinitionParser : ParserBase
    {
        public IrregularSymbolsDefinitionParser(Context context) : base(context)
        {

        }

        /// <summary>
        /// Parses the Roman symbol definition
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>The result of whether it is success</returns>
        public override bool Parse(string input)
        {
            string[] words = input.Split(new[] { TranslatorConstant.Is }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Count() != 2)
            {
                return false;
            }
            if (words[0].Trim().Contains(TranslatorConstant.Blank))
            {
                return false;
            }

            if (words[1].Length != 1)
            {
                return false;
            }

            RomanSymbol romanSymbol = RomanSymbolUtility.GetRomanSymbol(words[1]);
            string key = words[0].Trim();
            Context.IrregularSymbolsDefinition[key] = romanSymbol ?? throw new Exception(TranslatorConstant.InvalidRomanSymbol);

            return true;
        }
    }
}
