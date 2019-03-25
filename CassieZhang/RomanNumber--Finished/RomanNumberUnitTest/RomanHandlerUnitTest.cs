using NUnit.Framework;
using RomanNumber;
using RomanNumber.Business;
using RomanNumber.Model;
using System;
using System.Collections.Generic;

namespace RomanNumberUnitTest
{
	public class RomanHandlerUnitTest
	{
		private RomanHandler romanHandler = null;
		private List<Roman> baseRomansList = null;

		[SetUp]
		public void Setup()
		{
			romanHandler = new RomanHandler();
			baseRomansList = RomanCommon.RomanObjs;
		}

		[Test]
		public void TestCalculateSymbolsValueExpIsEmpty()
		{
			string symbolsExpression = string.Empty;
			int calculateResult = romanHandler.CalculateSymbolsValue(symbolsExpression);
			Assert.AreEqual(0, calculateResult);
		}

		[Test]
		public void TestCalculateSymbolsValueHasOneSymbolNotRecognized()
		{
			string symbolsExpression = "N";
			Exception exception = null;
			try
			{
				int calculateResult = romanHandler.CalculateSymbolsValue(symbolsExpression);
			}
			catch (Exception ex)
			{
				exception = ex;
			}
			Assert.AreNotEqual(null, exception);
		}

		[Test]
		public void TestCalculateSymbolsValueHasOneSymbolRecognized()
		{
			string symbolsExpression = "M";
			int calculateResult = romanHandler.CalculateSymbolsValue(symbolsExpression);
			Assert.AreEqual(1000, calculateResult);
		}

		[Test]
		public void TestCalculateSymbolsValueHasMultiplySymbolsNotRecognized()
		{
			string symbolsExpression = "MKDC";
			Exception exception = null;
			try
			{
				int calculateResult = romanHandler.CalculateSymbolsValue(symbolsExpression);
			}
			catch (Exception ex)
			{
				exception = ex;
			}
			Assert.AreNotEqual(null, exception);
		}

		[Test]
		public void TestCalculateSymbolsValueHasMultiplySymbolsCanNotRepeat()
		{
			string symbolsExpression = "MDDC";
			Exception exception = null;
			try
			{
				int calculateResult = romanHandler.CalculateSymbolsValue(symbolsExpression);
			}
			catch (Exception ex)
			{
				exception = ex;
			}
			Assert.AreNotEqual(null, exception);
		}

		[Test]
		public void TestCalculateSymbolsValueHasMultiplySymbolsRepeatMoreThanThree()
		{
			string symbolsExpression = "MCMMMM";
			Exception exception = null;
			try
			{
				int calculateResult = romanHandler.CalculateSymbolsValue(symbolsExpression);
			}
			catch (Exception ex)
			{
				exception = ex;
			}
			Assert.AreNotEqual(null, exception);
		}

		[Test]
		public void TestCalculateSymbolsValueHasMultiplySymbolsRepeatNormally()
		{
			string symbolsExpression = "MCMMM";
			int calculateResult = romanHandler.CalculateSymbolsValue(symbolsExpression);
			Assert.AreEqual(3900, calculateResult);
		}
	}
}