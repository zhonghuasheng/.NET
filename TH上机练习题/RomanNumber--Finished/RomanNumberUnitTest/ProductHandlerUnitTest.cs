using NUnit.Framework;
using RomanNumber;
using RomanNumber.Business;
using RomanNumber.Model;
using System;
using System.Collections.Generic;

namespace RomanNumberUnitTest
{
	public class ProductHandlerUnitTest
	{
		private Product product = null;
		private ProductHandler productHandler = null;

		[SetUp]
		public void Setup()
		{
			product = new Product { ProductName = "Gold", ProductPrice = 10 };
			productHandler = new ProductHandler();
		}

		[Test]
		public void TestCountProductValue()
		{
			int count = 10;
			Assert.AreEqual(100, productHandler.CountProductValue(product, count));
		}
	}
}
