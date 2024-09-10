using MediatR;

namespace Notification.Handler
{
    internal class NotificationFirstHandler : INotificationHandler<SampleNotification>
    {
        public async Task Handle(SampleNotification notification, CancellationToken cancellationToken)
        {
            await Task.Delay(10000, cancellationToken);
            Console.WriteLine($"First Handler: {notification.Id}, Time: {notification.NotificationTime}");
        }
    }
}
