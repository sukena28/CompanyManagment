using Practical_Training.Services;

namespace Practical_Training.Service.Notification.Concrete
{
    public class CloudNotificationService : INotificationService
    {
        public string SenMessage(string message)
        {
            return $"This message ({message}) send by Cloud";
        }
    }
}
