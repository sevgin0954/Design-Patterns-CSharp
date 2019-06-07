using IteratorPattern.Interfaces;

namespace IteratorPattern
{
    internal class MatrixIterator : Iterator
    {
        private readonly int[,] matrix;
        private int rowIndex = 0;
        private int colIndex = 0;

        internal MatrixIterator(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public object Next()
        {
            if (this.HasNext())
            {
                var item = matrix[rowIndex, colIndex];
                colIndex++;
                if (colIndex >= matrix.GetLength(1))
                {
                    colIndex = 0;
                    rowIndex++;
                }

                return item;
            }
            else
            {
                return null;
            }
        }

        public bool HasNext()
        {
            return rowIndex < matrix.GetLength(0) && colIndex < matrix.GetLength(1);
        }
    }
}
