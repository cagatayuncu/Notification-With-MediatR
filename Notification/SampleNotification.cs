using MediatR;

namespace Notification
{
    public record SampleNotification : INotification
    {
        public Guid Id { get; set; }
        public DateTime NotificationTime { get; set; }

    }
}
