namespace Thoughtworks.Translator
{
    /// <summary>
    /// The parser base.
    /// </summary>
    public abstract class ParserBase
    {
        public Context Context { get; set; }

        public ParserBase(Context context)
        {
            Context = context;
        }

        /// <summary>
        /// Parses the input text.
        /// </summary>
        /// <param name="input">The input text.</param>
        /// <returns>True/False</returns>
        public abstract bool Parse(string input);
    }
}
