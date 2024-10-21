using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TextNotification : Notification
    {
        public TextNotification(INotificationSender notificationSender) : base(notificationSender) { }

        public override void Notify(string message)
        {
            _notificationSender.Send($"Текст: {message}");
        }
    }
}
