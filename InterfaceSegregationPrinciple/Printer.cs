using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class Printer : IPrinter
    {
        public void Print() => Console.WriteLine("Printing...");
    }
}
