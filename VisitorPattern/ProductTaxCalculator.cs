using VisitorPattern.Interfaces;
using VisitorPattern.Products;

namespace VisitorPattern
{
	public class ProductTaxCalculator : ITaxCalculator
	{
		public decimal DiscountMultiplier { get; set; } = 1;

		public decimal CalculateTax(Alcohol alcohol)
		{
			var alcoholTax = alcohol.Price * 1.3m;
			var alcoholTotalPrice = alcohol.Price + alcoholTax;
			var calcoholTotalPriceWithDiscount = alcoholTotalPrice * this.DiscountMultiplier;

			return calcoholTotalPriceWithDiscount;
		}

		public decimal CalculateTax(Cigaretes cigaretes)
		{
			var cigaretesTax = cigaretes.Price * 1.5m;
			var cigaretesTotalPrice = cigaretes.Price + cigaretesTax;
			var cigaretesTotalPriceWithDiscount = cigaretesTotalPrice * this.DiscountMultiplier;

			return cigaretesTotalPriceWithDiscount;
		}

		public decimal CalculateTax(Water water)
		{
			var waterTax = 0;
			var waterTotalPrice = water.Price + waterTax;
			var waterTotalPriceWithDiscount = waterTotalPrice * this.DiscountMultiplier;

			return waterTotalPriceWithDiscount;
		}
	}
}
