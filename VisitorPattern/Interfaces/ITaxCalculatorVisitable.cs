namespace VisitorPattern.Interfaces
{
	public interface ITaxCalculatorVisitable
	{
		decimal accept(ITaxCalculator taxCalculator);
	}
}
