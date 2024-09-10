using MediatR;

namespace Notification.Handler;

internal class NotificationSecondHandler : INotificationHandler<SampleNotification>
{
    public Task Handle(SampleNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Second Handler: {notification.Id}, Time: {notification.NotificationTime}");
        return Task.CompletedTask;
    }
}