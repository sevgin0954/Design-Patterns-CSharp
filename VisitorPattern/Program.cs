using System;
using System.Collections.Generic;
using VisitorPattern.Interfaces;
using VisitorPattern.Products;

namespace VisitorPattern
{
	public class Program
	{
		public static void Main()
		{
			var productsVisitable = new List<ITaxCalculatorVisitable>();
			productsVisitable.Add(new Alcohol());
			productsVisitable.Add(new Cigaretes());
			productsVisitable.Add(new Water());

			var taxCalculator = new ProductTaxCalculator();
			PrintProductsPrice(productsVisitable, taxCalculator);

			// After 50% discount
			taxCalculator.DiscountMultiplier = 0.5m;
			PrintProductsPrice(productsVisitable, taxCalculator);
		}

		private static void PrintProductsPrice(
			IEnumerable<ITaxCalculatorVisitable> taxCalculatorVisitable,
			ITaxCalculator taxCalculator)
		{
			foreach (var product in taxCalculatorVisitable)
			{
				Console.WriteLine(product.accept(taxCalculator));
			}
		}
	}
}
