using NotificationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdge
{
    public class HtmlNotification : Notification
    {
        public HtmlNotification(INotificationSender notificationSender) : base(notificationSender) { }

        public override void Notify(string message)
        {
            _notificationSender.Send($"<html><body><h1>HTML уведомление</h1><p>{message}</p></body></html>");
        }
    }
}
