using Birdge;

namespace NotificationSystem
{
    public abstract class Notification
    {
        protected INotificationSender _notificationSender;

        protected Notification(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public abstract void Notify(string message);
    }
}
