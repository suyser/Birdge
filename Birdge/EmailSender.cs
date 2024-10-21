using Birdge;
using System;

namespace NotificationSystem
{
    public class EmailSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправлено Email: {message}");
        }
    }
}

