using VirtualProxyPattern.Interfaces;

namespace VirtualProxyPattern
{
    class NumbersParserProxy : INumbersParser
    {
        private INumbersParser originalParser = null;
        private readonly int[] nums;
        private readonly object padlock = new object();

        public NumbersParserProxy(int[] nums)
        {
            this.nums = nums;
        }

        public int GetMaxNumber()
        {
            this.EnsureOriginalObjectCreated();
            var maxNum = this.originalParser.GetMaxNumber();

            return maxNum;
        }

        public int GetMinNumber()
        {
            this.EnsureOriginalObjectCreated();
            var minNum = this.originalParser.GetMinNumber();

            return minNum;
        }

        public int GetNthNumber(int n)
        {
            this.EnsureOriginalObjectCreated();
            var nthNumber = this.originalParser.GetNthNumber(n);

            return nthNumber;
        }

        private void EnsureOriginalObjectCreated()
        {
            if (this.originalParser == null)
            {
                lock (this.padlock)
                {
                    if (this.originalParser == null)
                    {
                        this.originalParser = new NumbersParser(this.nums);
                    }
                }
            }
        }
    }
}
