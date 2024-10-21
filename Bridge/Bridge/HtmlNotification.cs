using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class HtmlNotification : Notification
    {
        public HtmlNotification(INotificationSender notificationSender) : base(notificationSender) { }

        public override void Notify(string message)
        {
            _notificationSender.Send($"<html><body><p>{message}</p></body></html>");
        }
    }
}
