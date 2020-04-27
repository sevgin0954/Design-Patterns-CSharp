using VisitorPattern.Interfaces;
using VisitorPattern.Products;
using VisitorPattern.Products.Interfaces;

namespace VisitorPattern
{
	public class ProductTaxCalculator : ITaxCalculator
	{
		public decimal DiscountMultiplier { get; set; } = 1;

		public decimal CalculateTax(Alcohol alcohol)
		{
			var alcoholTax = alcohol.Price * 1.3m;
			var calcoholTotalPriceWithDiscount = CalculateTotalPrice(alcoholTax, alcohol);

			return calcoholTotalPriceWithDiscount;
		}

		public decimal CalculateTax(Cigaretes cigaretes)
		{
			var cigaretesTax = cigaretes.Price * 1.5m;
			var cigaretesTotalPriceWithDiscount = CalculateTotalPrice(cigaretesTax, cigaretes);

			return cigaretesTotalPriceWithDiscount;
		}

		public decimal CalculateTax(Water water)
		{
			var waterTax = 0;
			var waterTotalPriceWithDiscount = CalculateTotalPrice(waterTax, water);

			return waterTotalPriceWithDiscount;
		}

		private decimal CalculateTotalPrice(decimal tax, IProduct product)
		{
			var price = product.Price + tax;
			var priceWithDiscount = price * this.DiscountMultiplier;

			return priceWithDiscount;
		}
	}
}
