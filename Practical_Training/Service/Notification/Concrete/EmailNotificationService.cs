namespace Practical_Training.Services
{
    public class EmailNotificationService : INotificationService
    {
        public string SenMessage(string message)
        {
            return $"This message ({message}) send by Email";
        }
    }
}
