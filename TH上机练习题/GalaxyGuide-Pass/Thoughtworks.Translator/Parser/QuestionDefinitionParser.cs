namespace Thoughtworks.Translator
{
    /// <summary>
    /// Question Definition Parser
    /// </summary>
    public class QuestionDefinitionParser : ParserBase
    {
        public QuestionDefinitionParser(Context context) : base(context)
        {

        }

        /// <summary>
        /// Parses the question definition
        /// </summary>
        /// <param name="input">The input text</param>
        /// <returns>The True/False</returns>
        public override bool Parse(string input)
        {
            if (!input.StartsWith(TranslatorConstant.HowMuch) && !input.StartsWith(TranslatorConstant.HowMany))
            {
                return false;
            }

            Context.Questions.Add(input.Replace(TranslatorConstant.QuestionMark, string.Empty).Trim());

            return true;
        }
    }
}
