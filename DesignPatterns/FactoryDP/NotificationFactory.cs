using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDP
{
    internal class NotificationFactory
    {
        private static INotification notification;

        public void SetNotificationType(INotification notificationType)
        {
            notification = notificationType ?? throw new ArgumentNullException(nameof(notification));
        }

        public void notifyUser()
        {
            if (notification != null)
            {
                notification.SendMessage();
            }
            else
            {
                throw new InvalidOperationException("set the notification type first");
            }
        }
    }
}
