namespace SolidPrinciples.DependencyInversionPrinciple
{
    /// <summary>
    /// This class demonstrates adherence to the Dependency Inversion Principle (DIP).
    /// The high-level module (NotificationManager) depends on the abstraction (IMessageService) rather than concrete implementations.
    /// This allows for easy extension to support new message services without modifying NotificationManager.
    /// Solution:
    /// NotificationManager depends on the IMessageService interface. We can inject any implementation (EmailService, SmsService, etc.) without changing NotificationManager.
    /// </summary>
    public class NotificationManager
    {
        private readonly IMessageService _messageService;

        public NotificationManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}