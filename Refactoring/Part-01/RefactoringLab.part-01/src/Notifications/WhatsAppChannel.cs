using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_01.src.Notifications;
public class WhatsAppChannel : INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[whatsapp] {to}: {message}");
}
