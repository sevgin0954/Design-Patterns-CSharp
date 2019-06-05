using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    internal class OldPrinterAdapter : INewPrinter
    {
        private readonly IOldPrinter oldPrinter;

        internal OldPrinterAdapter(IOldPrinter oldPrinter)
        {
            this.oldPrinter = oldPrinter;
        }

        public void PrintFast(string str)
        {
            this.oldPrinter.PrintSlow(str);
        }
    }
}
