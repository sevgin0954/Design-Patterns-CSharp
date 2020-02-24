using VisitorPattern.Interfaces;
using VisitorPattern.Products.Interfaces;

namespace VisitorPattern.Products
{
	public class Alcohol : IProduct, ITaxCalculatorVisitable
	{
		public decimal Price { get; set; } = 10;

		public decimal accept(ITaxCalculator taxCalculator)
		{
			return taxCalculator.CalculateTax(this);
		}
	}
}
