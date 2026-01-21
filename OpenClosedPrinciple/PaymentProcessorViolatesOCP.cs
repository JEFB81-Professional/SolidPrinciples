namespace SolidPrinciples.OpenClosedPrinciple
{
    // Example: Payment Processing System
    // ❌ Bad Design (Violates OCP)
    public class PaymentProcessorViolatesOCP
    {
        // Method to process payment
        // Problem: Every time we add a new payment method, we must modify PaymentProcessor. This violates OCP.
        public void ProcessPayment(string paymentType)
        {
            if (paymentType == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment...");
            }
            else if (paymentType == "PayPal")
            {
                Console.WriteLine("Processing PayPal payment...");
            }
            // Adding a new payment type requires modifying this class
        }

    }
}