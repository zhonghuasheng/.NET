using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thoughtworks.Translator;

namespace Thoughtworks.TranslatorUnitTest
{
    [TestClass]
    public class IntergalacticUnitCalculationOutputUT
    {
        private Dictionary<string, RomanSymbol> romanSymbolDefinition = new Dictionary<string, RomanSymbol>();
        private Dictionary<string, RomanSymbol> irregularSymbolsDefinition = new Dictionary<string, RomanSymbol>();
        private List<string> questions = new List<string>();
        private Dictionary<string, double> metalUnitsDefinition = new Dictionary<string, double>();
        private string intergalacticUnit = string.Empty;

        [TestInitialize]
        public void Init()
        {
            List<RomanSymbol> symboles = new List<RomanSymbol>{
                new RomanSymbol("I", 1, "VX", true, true),
                new RomanSymbol("V", 5, string.Empty),
                new RomanSymbol("X", 10, "LC", true, true),
                new RomanSymbol("L", 50, string.Empty),
                new RomanSymbol("C", 100, "DM", true, true),
                new RomanSymbol("D", 500, string.Empty),
                new RomanSymbol("M", 1000, string.Empty, true),
            };

            foreach (RomanSymbol symbol in symboles)
            {
                romanSymbolDefinition.Add(symbol.Symbol, symbol);
            }

            irregularSymbolsDefinition.Add("glob", new RomanSymbol("I", 1, "VX", true, true));
            irregularSymbolsDefinition.Add("prok", new RomanSymbol("V", 5, string.Empty));
            irregularSymbolsDefinition.Add("pish", new RomanSymbol("X", 10, "LC", true, true));
            irregularSymbolsDefinition.Add("tegj", new RomanSymbol("L", 50, string.Empty));

            metalUnitsDefinition.Add("Silver", 17);
            metalUnitsDefinition.Add("Gold", 14450);
            metalUnitsDefinition.Add("Iron", 195.5);

            intergalacticUnit = "Credits";

            questions.Add("how much is pish tegj glob glob ?".Replace(TranslatorConstant.QuestionMark, string.Empty).Trim());
            questions.Add("how many Credits is glob prok Bronze ?".Replace(TranslatorConstant.QuestionMark, string.Empty).Trim());
            questions.Add("how many Credits is glob prok Silver ?".Replace(TranslatorConstant.QuestionMark, string.Empty).Trim());
        }

        [TestMethod]
        public void TestWriteOutput()
        {
            Context context = new Context(new RomanCalculator());
            context.IrregularSymbolsDefinition = irregularSymbolsDefinition;
            context.MetalUnitsDefinition = metalUnitsDefinition;
            context.Questions = questions;
            context.IntergalacticUnit = intergalacticUnit;

            OutputBase output = new IntergalacticUnitCalculationOutput(context);
            Assert.AreEqual(output.WriteOutput(context.Questions[0]), false);

            Assert.AreEqual(output.WriteOutput(context.Questions[1]), false);

            Assert.AreEqual(output.WriteOutput(context.Questions[2]), true);
        }

        [TestCleanup]
        public void CleanTestData()
        {
            romanSymbolDefinition.Clear();
            irregularSymbolsDefinition.Clear();
            questions.Clear();
            metalUnitsDefinition.Clear();
            intergalacticUnit = string.Empty;
        }
    }
}
