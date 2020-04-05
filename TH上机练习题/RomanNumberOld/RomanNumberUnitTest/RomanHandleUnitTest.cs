using NUnit.Framework;
using RomanNumber;
using System.Collections.Generic;
using System.Reflection;

namespace RomanNumberUnitTest
{
    public class Tests
    {
        private RomanHandler romanHandlerInstance = null;
        [SetUp]
        public void Setup()
        {
            romanHandlerInstance = RomanHandler.GetInstance();
        }

        [Test]
        public void TestGetInstance()
        {
            Assert.IsNotNull(romanHandlerInstance);
        }

        [Test]
        public void TestCalculateSymbolsValueExpIsEmpty()
        {
            string symbolsExpression = string.Empty;
            int calculateResult = romanHandlerInstance.CalculateSymbolsValue(symbolsExpression);
            Assert.AreEqual(0, calculateResult);
        }

        [Test]
        public void TestCalculateSymbolsValueHasOneSymbolNotRecognized()
        {
            string symbolsExpression = "N";
            int calculateResult = romanHandlerInstance.CalculateSymbolsValue(symbolsExpression);
            Assert.AreEqual(0, calculateResult);
        }

        [Test]
        public void TestCalculateSymbolsValueHasOneSymbolRecognized()
        {
            string symbolsExpression = "M";
            int calculateResult = romanHandlerInstance.CalculateSymbolsValue(symbolsExpression);
            Assert.AreEqual(1000, calculateResult);
        }

        [Test]
        public void TestCalculateSymbolsValueHasMultiplySymbolsNotRecognized()
        {
            string symbolsExpression = "MKDC";
            int calculateResult = romanHandlerInstance.CalculateSymbolsValue(symbolsExpression);
            Assert.AreEqual(0, calculateResult);
        }

        [Test]
        public void TestCalculateSymbolsValueHasMultiplySymbolsCanNotRepeat()
        {
            string symbolsExpression = "MDDC";
            int calculateResult = romanHandlerInstance.CalculateSymbolsValue(symbolsExpression);
            Assert.AreEqual(0, calculateResult);
        }

        [Test]
        public void TestCalculateSymbolsValueHasMultiplySymbolsRepeatMoreThanThree()
        {
            string symbolsExpression = "MCMMMM";
            int calculateResult = romanHandlerInstance.CalculateSymbolsValue(symbolsExpression);
            Assert.AreEqual(0, calculateResult);
        }

        [Test]
        public void TestCalculateSymbolsValueHasMultiplySymbolsRepeatNormally()
        {
            string symbolsExpression = "MCMMM";
            int calculateResult = romanHandlerInstance.CalculateSymbolsValue(symbolsExpression);
            Assert.AreEqual(3900, calculateResult);
        }
    }
}