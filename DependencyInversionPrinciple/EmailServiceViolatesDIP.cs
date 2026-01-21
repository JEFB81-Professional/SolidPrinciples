namespace SolidPrinciples.DependencyInversionPrinciple
{
    public class EmailServiceViolatesDIP
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }

    }
}