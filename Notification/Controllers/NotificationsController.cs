using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Notification.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationsController(ILogger<NotificationsController> logger, IMediator mediator)
        : ControllerBase
    {

        private readonly ILogger<NotificationsController> _logger = logger;

        // add SendNotificationAsync method
        [HttpPost(Name = "SendNotification")]
        public async Task<IActionResult> SendNotificationAsync()
        {
            var notification = new SampleNotification
            {
                Id = Guid.NewGuid(),
                NotificationTime = DateTime.Now
            };



            await mediator.Publish(notification);

            return Ok();
        }


    }
}
