using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thoughtworks.Translator;

namespace Thoughtworks.TranslatorUnitTest
{
    [TestClass]
    public class QuestionDefinitionParserUT
    {
        [TestInitialize]
        public void Init()
        {
            // Nothing to do.
        }

        [TestMethod]
        public void TestParse()
        {
            ParserBase parser = new QuestionDefinitionParser(new Context(new RomanCalculator()));
            Assert.AreEqual(parser.Parse("how much is pish tegj glob glob ?"), true);

            Assert.AreEqual(parser.Parse("how many Credits is glob prok Silver ?"), true);

            Assert.AreEqual(parser.Parse("how much wood could a woodchuck chuck if a woodchuck could chuck wood ?"), true);

            Assert.AreEqual(parser.Parse("how old are you ?"), false);
        }

        [TestCleanup]
        public void CleanTestData()
        {
            // Nothing to do.
        }
    }
}
