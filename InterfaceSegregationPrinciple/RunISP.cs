namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Clients should not be forced to depend on interfaces they do not use.   
    /// In other words, split large interfaces into smaller, more specific ones.
    /// </summary>
    public class RunISP
    {
        /// <summary>
        /// Demonstrates the Interface Segregation Principle (ISP) by using specific interfaces for different
        /// Each class depends only on the methods it needs.
        /// Adding new functionality (e.g., Email) doesn’t break existing classes.
        /// </summary>
        public static void Execute()
        {
            IPrinter printer = new Printer();
            printer.Print();

            MultiFunctionMachine mfm = new MultiFunctionMachine();
            mfm.Print();
            mfm.Scan();
            mfm.Fax();
        }
    }
}