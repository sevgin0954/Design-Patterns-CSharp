using StrategyPattern;
using StrategyPattern.Interfaces;
using System;

class Program
{
    static void Main()
    {
        var ascStrategy = new AscendingSortingStrategy();
        var descStrategy = new DescendingSortingStrategy();

        var nums = new int[] { 9, 2, -5, 0, 9, 1, 10, -9 };
        Sort(nums, ascStrategy);
        Print(nums);
        Sort(nums, descStrategy);
        Print(nums);
    }

    private static void Sort(int[] nums, ISortingStrategy sortingStrategy)
    {
        sortingStrategy.Sort(nums);
    }

    private static void Print(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}