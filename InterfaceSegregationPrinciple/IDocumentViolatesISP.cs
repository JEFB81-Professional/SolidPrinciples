using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public interface IDocumentViolatesISP
    {

        void Print();
        void Scan();
        void Fax();

    }
}