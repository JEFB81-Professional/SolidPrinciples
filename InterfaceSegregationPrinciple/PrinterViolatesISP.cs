namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    /// <summary>
    /// A printer that violates the Interface Segregation Principle (ISP)
    ///  by implementing methods it does not use.
    /// Printer is forced to implement Scan() and Fax() even though it doesn’t support them. This violates ISP.
    /// </summary>
    public class PrinterViolatesISP : IDocumentViolatesISP
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => throw new NotImplementedException();
        public void Fax() => throw new NotImplementedException();

    }
}