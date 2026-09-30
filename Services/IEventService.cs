using service_events_api.DTOs;
using service_events_api.Models;

namespace service_events_api.Services
{
    public interface IEventService
    {
        List<EventDto?> GetAll();
        EventDto? GetById(Guid id);
        EventDto? Create(EventDto eventDto);
        EventDto? Update(Guid id, EventDto eventDto);
        void Delete(Guid id);
    }
}
