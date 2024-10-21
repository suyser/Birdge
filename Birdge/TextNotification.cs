using NotificationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdge
{ 
public class TextNotification : Notification
{
    public TextNotification(INotificationSender notificationSender) : base(notificationSender) { }

    public override void Notify(string message)
    {
        _notificationSender.Send($"Текстовое уведомление: {message}");
    }
}
}
