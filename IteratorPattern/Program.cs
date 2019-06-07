using IteratorPattern.Interfaces;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main()
        {
            var array = new int[] { 1, 2, 3, 4 };
            var matrix = new int[,]
            {
                { 5, 6, 7 },
                { 8, 9, 10 }
            };

            var arrayIterator = new ArrayIterator(array);
            var matrixIterator = new MatrixIterator(matrix);
            Print(arrayIterator);
            Print(matrixIterator);
        }

        private static void Print(Iterator items)
        {
            while (items.HasNext())
            {
                Console.WriteLine(items.Next());
            }

        }
    }
}
