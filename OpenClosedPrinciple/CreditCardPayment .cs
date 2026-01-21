namespace SolidPrinciples.OpenClosedPrinciple
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }
}