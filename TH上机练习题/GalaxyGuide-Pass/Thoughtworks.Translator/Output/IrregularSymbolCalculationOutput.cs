using System;

namespace Thoughtworks.Translator
{
    /// <summary>
    /// The Irregular symbol calculation output.
    /// </summary>
    public class IrregularSymbolCalculationOutput : OutputBase
    {
        public IrregularSymbolCalculationOutput(Context context)
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
            if (!question.StartsWith(TranslatorConstant.HowMuchIs))
            {
                return false;
            }

            string questionHeader = question.Replace(TranslatorConstant.HowMuchIs, string.Empty).Trim();
            double value = Context.Calculator.Calculate(questionHeader, Context.IrregularSymbolsDefinition);

            Console.WriteLine(questionHeader + TranslatorConstant.Is + value.ToString());
            return true;
        }
    }
}
