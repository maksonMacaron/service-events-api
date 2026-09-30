using Microsoft.AspNetCore.Mvc;
using service_events_api.Services;

namespace service_events_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
