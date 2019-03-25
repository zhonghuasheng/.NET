using RomanNumber.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumber.Business
{
	public class ProductHandler
	{
		/// <summary>
		/// Coount the product value according the product object and product count.
		/// </summary>
		/// <param name="product">The product object.</param>
		/// <param name="productCount">The count of the product.</param>
		/// <returns>The product total value.</returns>
		public double CountProductValue(Product product, int productCount)
		{
			return product.ProductPrice * productCount;
		}
	}
}
