using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    internal class NewPrinter : INewPrinter
    {
        public void PrintFast(string str)
        {
            Console.WriteLine(str);
        }
    }
}
