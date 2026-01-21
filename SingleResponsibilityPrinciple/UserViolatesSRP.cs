
namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    // Violates SRP: Handles both user data, saving  to a file system and input
    public class UserViolatesSRP
    {
        public required string Name { get; set; }
        public required string Email { get; set; }

        public static void SaveToFile()
        {
            // Code to save user data to a file
            Console.WriteLine("User saved to file.");
        }   
 
        public void ReadInput()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter email: ");
            Email = Console.ReadLine() ?? string.Empty;
        }
    }
}