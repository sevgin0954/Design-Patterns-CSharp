using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            var oldPrinter = new OldPrinter();
            var oldPrinterAdapter = new OldPrinterAdapter(oldPrinter);
            var newPrinter = new NewPrinter();

            var newPrinters = new INewPrinter[2] { oldPrinterAdapter, newPrinter };
            foreach (var printer in newPrinters)
            {
                printer.PrintFast("Printtttttt");
            }
        }
    }
}
