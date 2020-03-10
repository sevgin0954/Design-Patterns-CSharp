using System;
using VirtualProxyPattern.Interfaces;

namespace VirtualProxyPattern
{
	class NumbersParser : INumbersParser
	{
		private readonly int[] sortedNumbers;

		public NumbersParser(int[] nums)
		{
			// Slow sorting
			Array.Copy(nums, 0, sortedNumbers, 0, nums.Length);
			Array.Sort(nums);
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
