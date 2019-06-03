using StrategyPattern.Interfaces;
using System.Linq;

namespace StrategyPattern
{
    class DescendingSortingStrategy : ISortingStrategy
    {
        public void Sort(int[] nums)
        {
            var orderedNums = nums.OrderByDescending(n => n).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = orderedNums[i];
            }
        }
    }
}
