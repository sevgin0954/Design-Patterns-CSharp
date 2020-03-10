using System.Linq;
using VirtualProxyPattern.Interfaces;

namespace VirtualProxyPattern
{
	class NumbersParser : INumbersParser
	{
		private readonly int[] sortedNumbers;

		public NumbersParser(int[] nums)
		{
			// Slow sorting
			this.sortedNumbers = nums.OrderBy(n => n).ToArray();
		}

		public int GetMaxNumber()
		{
			var lastNumber = sortedNumbers[^1];

			return lastNumber;
		}

		public int GetMinNumber()
		{
			var minNumber = sortedNumbers[0];

			return minNumber;
		}

		public int GetNthNumber(int n)
		{
			var nthNumber = sortedNumbers[n];

			return nthNumber;
		}
	}
}
