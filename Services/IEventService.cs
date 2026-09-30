using service_events_api.Models;

namespace service_events_api.Services
{
    public interface IEventService
    {
        List<Event> GetAll();
        Event? GetById(Guid id);
        Event Create();
        Event Update(Event currentEvent);
        void Delete(Guid id);
    }
}
