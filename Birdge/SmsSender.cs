using Birdge;
using System;

namespace NotificationSystem
{
    public class SmsSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправлено SMS: {message}");
        }
    }
}

