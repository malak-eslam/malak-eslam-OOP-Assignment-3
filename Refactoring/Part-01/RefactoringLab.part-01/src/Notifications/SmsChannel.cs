using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_01.src.Notifications;
public class SmsChannel : INotificationChannel
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[sms] {to}: {message}");
    }
}
