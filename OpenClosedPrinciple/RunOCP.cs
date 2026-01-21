namespace SolidPrinciples.OpenClosedPrinciple
{
    /// <summary>
    /// Demonstrates the Open/Closed Principle (OCP) in a payment processing system.
    /// Software entities (classes, modules, functions) should be open for extension but closed for modification.
    /// This means you should be able to add new functionality without changing existing code.
    /// </summary>
    public class RunOCP
    {
        /// <summary>
        /// Demonstrates the Open/Closed Principle (OCP) in a payment processing system.
        /// PaymentProcessor does not change when adding new payment types.
        /// To add ApplePay, just create a new class implementing IPaymentMethod
        /// </summary>  
        public static void Execute()
        {
            PaymentProcessor processor = new();

            IPaymentMethod creditCard = new CreditCardPayment();
            IPaymentMethod paypal = new PayPalPayment();

            processor.Process(creditCard);
            processor.Process(paypal);

            Console.WriteLine("Payments processed successfully.");

        }
    }
}