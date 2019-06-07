using IteratorPattern.Interfaces;

namespace IteratorPattern
{
    internal class ArrayIterator : Iterator
    {
        private readonly int[] array;
        private int currentIndex = 0;

        internal ArrayIterator(int[] array)
        {
            this.array = array;
        }

        public object Next()
        {
            if (this.HasNext())
            {
                var item = array[currentIndex];
                currentIndex++;

                return item;
            }
            else
            {
                return null;
            }
        }

        public bool HasNext()
        {
            return currentIndex < array.Length;
        }
    }
}
