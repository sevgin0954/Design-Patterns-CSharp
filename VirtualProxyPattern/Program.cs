using System;

namespace VirtualProxyPattern
{
	class Program
	{
		static void Main()
		{
			var nums = new int[] { 3, 50, -5, 9, 8, 1, 20, -5 };
			var proxyParser = new NumbersParserProxy(nums);

			Console.WriteLine(proxyParser.GetMaxNumber());
		}
	}
}