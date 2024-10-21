using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
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
