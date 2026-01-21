namespace SolidPrinciples.DependencyInversionPrinciple
{
    /// <summary>
    /// This class demonstrates a violation of the Dependency Inversion Principle (DIP).
    /// The high-level module (NotificationManagerViolatesDIP) depends directly on the low-level module (EmailServiceViolatesDIP).
    /// Both should depend on abstractions (e.g., interfaces) instead.
    /// Problem:
    /// NotificationManager depends directly on EmailService. If we want to add SMS or Push notifications, we must modify NotificationManager, violating DIP.
    /// </summary>
    public class NotificationManagerViolatesDIP
    {

        private EmailServiceViolatesDIP _emailService;

        public NotificationManagerViolatesDIP()
        {
            // problematic: directly depends on a concrete class
            _emailService = new EmailServiceViolatesDIP();
        }

        public void Notify(string message)
        {
            _emailService.SendEmail(message);
        }

    }
}