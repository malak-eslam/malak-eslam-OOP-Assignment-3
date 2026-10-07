namespace part_01.src.Notifications;

public class Notification : INotification
{
    private readonly INotificationChannel _channel;

    public Notification(INotificationChannel channel)
    {
        _channel = channel;
    }

    public virtual void Send(string to, string message) =>  _channel.Send(to, message);
}



