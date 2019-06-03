using StrategyPattern.Interfaces;
using System.Linq;

namespace StrategyPattern
{
    internal class AscendingSortingStrategy : ISortingStrategy
    {
        public void Sort(int[] nums)
        {
            var orderedNums = nums.OrderBy(n => n).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = orderedNums[i];
            }
        }
    }
}
