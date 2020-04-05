using System;

namespace Thoughtworks.Translator
{
    public class Translator
    {
        /// <summary>
        /// Translates the input text.
        /// </summary>
        /// <param name="commands">commands</param>
        public static void Translate(string[] commands)
        {
            try
            {
                Context context = new Context(new RomanCalculator());

                // Intials parsers.
                ParserBase[] contextParsers = new ParserBase[]
                {
                new IrregularSymbolsDefinitionParser(context),
                new UnitDefinitionParser(context),
                new QuestionDefinitionParser(context)
                };

                // Intials outputs.
                OutputBase[] outputs = new OutputBase[]
                {
                new IrregularSymbolCalculationOutput(context),
                new IntergalacticUnitCalculationOutput(context)
                };

                // Parses the input text to a context entity.
                foreach (string cmd in commands)
                {
                    try
                    {
                        bool isSuccess = false;
                        foreach (ParserBase contextParser in contextParsers)
                        {
                            if (contextParser.Parse(cmd))
                            {
                                isSuccess = true;
                                break;
                            }
                        }
                        if (!isSuccess)
                        {
                            Console.WriteLine(TranslatorConstant.SyntaxError + TranslatorConstant.InputTag + cmd);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + TranslatorConstant.InputTag + cmd);
                    }
                }

                // Writes the output.
                foreach (string cmd in context.Questions)
                {
                    try
                    {
                        bool flag = false;
                        foreach (OutputBase output in outputs)
                        {
                            if (output.WriteOutput(cmd))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine(TranslatorConstant.BadQuestionError);
                        }
                    }
                    catch
                    {
                        Console.WriteLine(TranslatorConstant.BadQuestionError);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
