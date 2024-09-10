using MediatR;

namespace Notification.Handler
{
    internal class NotificationThirdHandler : INotificationHandler<SampleNotification>
    {
        public async Task Handle(SampleNotification notification, CancellationToken cancellationToken)
        {
            await Task.Delay(5000, cancellationToken);
            Console.WriteLine($"Third Handler: {notification.Id}, Time: {notification.NotificationTime}");
        }
    }
}
