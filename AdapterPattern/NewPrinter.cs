using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    internal class NewPrinter : INewPrinter
    {
        private readonly IOldPrinter oldPrinter;

        public NewPrinter(IOldPrinter oldPrinter)
        {
            this.oldPrinter = oldPrinter;
        }

        public void PrintFast(string str)
        {
            this.oldPrinter.PrintSlow(str);
        }
    }
}
