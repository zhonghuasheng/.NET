using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Thoughtworks.Translator;

namespace Thoughtworks.TranslatorUnitTest
{
    [TestClass]
    public class RomanCalculatorUT
    {
        private string[] commands = null;
        private Dictionary<string, RomanSymbol> romanSymbolDefinition = new Dictionary<string, RomanSymbol>();

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

            commands = new string[]
            {
                "M M M C M D C D C C C X C L X L X X X I X V I V I I I",
                "V X X X",
                "I L",
                "C D D",
                "C M M",
                "C C C C",
                "A M M M"
            };
        }

        [TestMethod]
        public void TestCalculate()
        {
            ICalculator calculator = new RomanCalculator();
            Assert.AreEqual(calculator.Calculate(commands[0], romanSymbolDefinition), 5331);

            Assert.AreEqual(
                Assert.ThrowsException<Exception>(
                    () => calculator.Calculate(commands[1], romanSymbolDefinition)).Message,
                "V can not be subtracted");

            Assert.AreEqual(
                Assert.ThrowsException<Exception>(
                    () => calculator.Calculate(commands[2], romanSymbolDefinition)).Message,
                "I can not be subtracted from L");

            Assert.AreEqual(
                Assert.ThrowsException<Exception>(
                    () => calculator.Calculate(commands[3], romanSymbolDefinition)).Message,
                "D can not be repeated");

            Assert.AreEqual(
                Assert.ThrowsException<Exception>(
                    () => calculator.Calculate(commands[4], romanSymbolDefinition)).Message,
                "Symbols must be placed in order of value, starting with the largest values");

            Assert.AreEqual(
                Assert.ThrowsException<Exception>(
                    () => calculator.Calculate(commands[5], romanSymbolDefinition)).Message,
                "The symbols can be repeated three times in succession, but no more");

            Assert.AreEqual(
                Assert.ThrowsException<Exception>(
                    () => calculator.Calculate(commands[6], romanSymbolDefinition)).Message,
                "Invalid Symbol");
        }

        [TestCleanup]
        public void CleanTestData()
        {
            commands = null;
            romanSymbolDefinition.Clear();
        }
    }
}
