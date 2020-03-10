namespace VirtualProxyPattern.Interfaces
{
	public interface INumbersParser
	{
		int GetMaxNumber();
		int GetMinNumber();
		int GetNthNumber(int n);
	}
}