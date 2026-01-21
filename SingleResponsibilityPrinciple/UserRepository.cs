namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    // Class responsible for persistence
    public class UserRepository
    {
        private readonly string _filePath;

        public UserRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void SaveToFile(User user)
        {
            string userData = $"{user.Name},{user.Email}";
            File.AppendAllText(_filePath, userData + Environment.NewLine);
            Console.WriteLine($"User {user.Name} saved to {_filePath}");
        }

    }

}