namespace Practical_Training.Services
{
    public class TextNotificationService : INotificationService
    {
        public string SenMessage(string message)
        {
            return $"This message ({message}) send by Text";
        }
    }
}
