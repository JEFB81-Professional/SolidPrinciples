namespace SolidPrinciples.DependencyInversionPrinciple
{
    /// <summary>
    /// This class is intended to demonstrate the Dependency Inversion Principle (DIP).
    /// High-level modules should not depend on low-level modules. Both should depend on abstractions.
    /// This means we should depend on interfaces or abstract classes, not concrete implementations.
    /// </summary>
    public class RunDIP
    {
        /// <summary>
        /// Demonstrates the Dependency Inversion Principle (DIP) by showing both a violation and adherence to the principle.
        /// NotificationManager depends on IMessageService (an abstraction), not concrete classes.
        /// Adding a new service (e.g., PushNotification) requires no changes to NotificationManager.
        /// </summary>
        public static void Execute()
        {
            // Violates DIP
            var notificationManagerViolatesDIP = new NotificationManagerViolatesDIP();
            notificationManagerViolatesDIP.Notify("This is a notification (violates DIP).");

            // Adheres to DIP
            IMessageService emailService = new EmailService();
            var notificationManager = new NotificationManager(emailService);
            notificationManager.Notify("This is a notification via Email (adheres to DIP).");

            IMessageService smsService = new SmsService();
            var notificationManagerSms = new NotificationManager(smsService);
            notificationManagerSms.Notify("This is a notification via SMS (adheres to DIP).");
        }   
    }
}