using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_01.src.Notifications;
public class UrgentNotification : INotification
{
    private readonly INotification _notification;

    public UrgentNotification(INotification notification)
    {
        _notification = notification;
    }

    public void Send(string to, string message)
    {
        _notification.Send(to, $"[URGENT] {message}");
    }
}
