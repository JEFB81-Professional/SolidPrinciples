using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{

    public class MultiFunctionMachine : IPrinter, IScanner, IFax
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => Console.WriteLine("Scanning...");
        public void Fax() => Console.WriteLine("Faxing...");
    }
}