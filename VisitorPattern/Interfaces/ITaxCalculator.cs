using VisitorPattern.Products;

namespace VisitorPattern.Interfaces
{
	public interface ITaxCalculator
	{
		decimal CalculateTax(Alcohol alcohol);
		decimal CalculateTax(Cigaretes cigaretes);
		decimal CalculateTax(Water water);
	}
}
