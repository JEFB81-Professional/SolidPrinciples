
namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    /// <summary>
    /// The Single Responsibility Principle (SRP) states that a class should have only one reason to change, meaning it should focus on a single responsibility.
    /// </summary>

    public class RunSRP
    {
        /// <summary>
        /// The class to demonstrate Single Responsibility Principle
        /// ✅ Why This Follows SRP:
        /// User → Holds user data only.
        /// UserRepository → Handles persistence logic only.
        /// UserService → Handles user input/output only.
        /// Program → Coordinates the flow.
        /// </summary>
        public static void Execute()
        {
            string filePath = "users.txt";

            UserService userService = new();
            UserRepository repository = new(filePath);

            // Create user from input
            User user = userService.UserInput();

            // Save user to file
            repository.SaveToFile(user);

            Console.WriteLine("Operation completed successfully.");
        }

    }
}