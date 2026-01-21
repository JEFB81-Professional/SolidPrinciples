namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    /// <summary>
    /// Demonstrates the Liskov Substitution Principle (LSP) violation.
    /// Square cannot be substituted for Rectangle without altering expected behavior.
    /// If you substitute Rectangle with Square, setting Width and Height separately breaks expectations.
    /// Objects of a superclass should be replaceable with objects of its subclasses without breaking the application.
    /// In other words, derived classes must honor the behavior expected from the base class.
    /// </summary>

    public class RunLSP
    {
        /// <summary>
        /// Demonstrates the Liskov Substitution Principle (LSP) violation.
        /// Square cannot be substituted for Rectangle without altering expected behavior.
        /// If you substitute Rectangle with Square, setting Width and Height separately breaks expectations.
        /// </summary>
        public static void ExecuteViolation()
        {
            RectangleViolatesLSP rect = new SquareViolatesLSP();
            rect.Width = 5;
            rect.Height = 10; // Expected area = 50, but actual = 10
        }

        /// <summary>
        /// Demonstrates adherence to the Liskov Substitution Principle (LSP).
        /// Square can be substituted for Rectangle without altering expected behavior.
        /// </summary>
        public static void ExecuteAdherence()
        {
            IShape rect = new Rectangle { Width = 5, Height = 10 };
            IShape square = new Square { Side = 5 };

            Console.WriteLine($"Rectangle area: {rect.GetArea()}");
            Console.WriteLine($"Square area: {square.GetArea()}");

        }
    }
}