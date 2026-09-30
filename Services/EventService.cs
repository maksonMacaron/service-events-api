using service_events_api.Models;

namespace service_events_api.Services
{
    public class EventService : IEventService
    {
        private static List<Event> _events = new List<Event>()
        {
        };

        public Event Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Event> GetAll()
        {
            return _events;
        }

        public Event? GetById(Guid id)
        {
            return _events.FirstOrDefault(e => e.Id == id);
        }

        public Event Update(Event currentEvent)
        {
            throw new NotImplementedException();
        }
    }
}
