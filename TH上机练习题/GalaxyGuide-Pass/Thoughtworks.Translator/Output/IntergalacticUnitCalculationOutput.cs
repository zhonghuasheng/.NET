using System;
using System.Linq;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// The intergalactic unit calculation output.
    /// </summary>
    public class IntergalacticUnitCalculationOutput : OutputBase
    {
        public IntergalacticUnitCalculationOutput(Context context)
            : base(context)
        {

        }

        /// <summary>
        /// Writes the output result.
        /// </summary>
        /// <param name="question">The question.</param>
        /// <returns>True/False</returns>
        public override bool WriteOutput(string question)
        {
            string intergalacticUnit = Context.IntergalacticUnit;
            string start = string.Format(TranslatorConstant.HowManyIs, intergalacticUnit);
            if (!question.StartsWith(start))
            {
                return false;
            }
            string questionHeader = question.Replace(start, string.Empty).Trim();
            string[] words = questionHeader.Split(new[] { TranslatorConstant.Blank }, StringSplitOptions.RemoveEmptyEntries);
            string metalUnit = words.Last().Trim();

            if (!Context.MetalUnitsDefinition.Keys.Contains(metalUnit))
            {
                return false;
            }
            double metalUnitValue = Context.MetalUnitsDefinition[metalUnit];

            double value = Context.Calculator.Calculate(string.Join(TranslatorConstant.Blank, words.Take(words.Length - 1)), Context.IrregularSymbolsDefinition);

            Console.WriteLine(questionHeader + TranslatorConstant.Is + value * metalUnitValue + TranslatorConstant.Blank + intergalacticUnit);
            return true;
        }
    }
}
