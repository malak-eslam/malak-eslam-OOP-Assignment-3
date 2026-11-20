using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_01.src.Notifications;
public interface INotificationChannel
{
    public void Send(string to, string message);
}





