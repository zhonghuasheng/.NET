namespace Thoughtworks.Translator
{
    /// <summary>
    /// The output base.
    /// </summary>
    public abstract class OutputBase
    {
        public Context Context { get; private set; }

        public OutputBase(Context context)
        {
            Context = context;
        }

        /// <summary>
        /// Writes the output result.
        /// </summary>
        /// <param name="question">The question.</param>
        /// <returns>True/False</returns>
        public abstract bool WriteOutput(string input);
    }
}
