namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            var oldPrinter = new OldPrinter();
            var newPrinter = new NewPrinter(oldPrinter);

            newPrinter.PrintFast("Print");
        }
    }
}
