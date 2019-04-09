using System;
using System.Linq;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// Unit definition parser
    /// </summary>
    public class UnitDefinitionParser : ParserBase
    {
        public UnitDefinitionParser(Context context)
            : base(context)
        {

        }

        /// <summary>
        /// Parses the Unit definition
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

            string[] leftWords = words[0].Split(new[] { TranslatorConstant.Blank }, StringSplitOptions.RemoveEmptyEntries);

            if (leftWords.Length < 2)
            {
                return false;
            }

            if (!double.TryParse(words[1].Split(new[] { TranslatorConstant.Blank }, StringSplitOptions.RemoveEmptyEntries)[0], out double rightValue))
            {
                return false;
            }

            string intergalacticUnit = words[1].Split(new[] { TranslatorConstant.Blank }, StringSplitOptions.RemoveEmptyEntries)[1];
            if (string.IsNullOrEmpty(Context.IntergalacticUnit))
            {
                Context.IntergalacticUnit = intergalacticUnit;
            }
            else
            {
                if (!Context.IntergalacticUnit.Equals(intergalacticUnit))
                {
                    throw new Exception(TranslatorConstant.IntergalacticUnitLimitError);
                }
            }

            double calculatedValue = Context.Calculator.Calculate(string.Join(TranslatorConstant.Blank, leftWords.Take(leftWords.Length - 1)), Context.IrregularSymbolsDefinition);

            string metalUnit = leftWords.Last();
            double metalUnitValue = rightValue / calculatedValue;

            Context.MetalUnitsDefinition[metalUnit] = metalUnitValue;
            return true;
        }
    }
}
