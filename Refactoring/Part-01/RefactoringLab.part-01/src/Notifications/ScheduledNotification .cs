using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_01.src.Notifications;
public class ScheduledNotification : INotification
{
    private readonly INotification _notification;
    private readonly DateTime _sendAt;

    public ScheduledNotification(INotification notification, DateTime sendAt)
    {
        _notification = notification;
        _sendAt = sendAt;
    }

    public void Send(string to, string message)
    {

        Console.WriteLine($"[scheduled {_sendAt:g}]" );
        _notification.Send(to, message);
    }
}
