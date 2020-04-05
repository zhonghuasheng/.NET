using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thoughtworks.Translator;

namespace Thoughtworks.TranslatorUnitTest
{
    [TestClass]
    public class IrregularSymbolsDefinitionParserUT
    {
        [TestInitialize]
        public void Init()
        {
            // Nothing to do.
        }

        [TestMethod]
        public void TestParse()
        {
            ParserBase parser = new IrregularSymbolsDefinitionParser(new Context(new RomanCalculator()));

            Assert.AreEqual(parser.Parse("glob is"), false);

            Assert.AreEqual(parser.Parse("is I"), false);

            Assert.AreEqual(parser.Parse("glob is I AM"), false);

            Assert.AreEqual(parser.Parse("glob is I"), true);
        }

        [TestCleanup]
        public void CleanTestData()
        {
           // Nothing to do.
        }
    }
}
