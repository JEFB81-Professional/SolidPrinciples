namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    // Class responsible for user input/output (UI logic)
    public class UserService
    {
        public User UserInput()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter email: ");
            string email = Console.ReadLine() ?? string.Empty;

            return new User { Name = name, Email = email };
        }

    }
}