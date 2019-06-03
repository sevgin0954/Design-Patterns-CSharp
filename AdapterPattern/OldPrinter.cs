using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    class OldPrinter : IOldPrinter
    {
        public void PrintSlow(string str)
        {
            Console.WriteLine(str);
        }
    }
}
