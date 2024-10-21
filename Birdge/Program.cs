using Birdge;
using NotificationSystem;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        INotificationSender emailSender = new EmailSender();
        INotificationSender smsSender = new SmsSender();

        Notification textEmailNotification = new TextNotification(emailSender);
        textEmailNotification.Notify("Это текстовое уведомление на Email.");

        Notification textSmsNotification = new TextNotification(smsSender);
        textSmsNotification.Notify("Это текстовое уведомление по SMS.");

        Notification htmlEmailNotification = new HtmlNotification(emailSender);
        htmlEmailNotification.Notify("Это HTML уведомление на Email.");

        Notification htmlSmsNotification = new HtmlNotification(smsSender);
        htmlSmsNotification.Notify("Это HTML уведомление по SMS.");
    }
}