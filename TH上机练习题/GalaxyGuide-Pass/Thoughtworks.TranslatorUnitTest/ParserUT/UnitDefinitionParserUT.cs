using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Thoughtworks.Translator;

namespace Thoughtworks.TranslatorUnitTest
{
    [TestClass]
    public class UnitDefinitionParserUT
    {
        private RomanSymbol romanSymbol = null;
        private System.Collections.Generic.Dictionary<string, RomanSymbol> irregularSymbolsDefinition = null;

        [TestInitialize]
        public void Init()
        {
            romanSymbol = new RomanSymbol("I", 1, "VX", true, true);
            irregularSymbolsDefinition = new System.Collections.Generic.Dictionary<string, RomanSymbol>();
            irregularSymbolsDefinition.Add("glob", romanSymbol);
        }

        [TestMethod]
        public void TestParse()
        {
            Context context = new Context(new RomanCalculator());
            ParserBase parser = new UnitDefinitionParser(context);
            Assert.AreEqual(parser.Parse("glob glob Silver is "), false);

            Assert.AreEqual(parser.Parse("glob is 34 Credits"), false);

            Assert.AreEqual(parser.Parse("glob glob Silver is aa Credits"), false);

            context.IntergalacticUnit = "Points";
            Assert.AreEqual(Assert.ThrowsException<Exception>(() => parser.Parse("glob glob Silver is 34 Credits")).Message, "Only allowe one intergalactic unit.");

            context.IntergalacticUnit = string.Empty;
            context.IrregularSymbolsDefinition = irregularSymbolsDefinition;
            Assert.AreEqual(parser.Parse("glob glob Silver is 34 Credits"), true);
        }

        [TestCleanup]
        public void CleanTestData()
        {
            romanSymbol = null;
            irregularSymbolsDefinition.Clear();
        }
    }
}
