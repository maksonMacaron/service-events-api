using service_events_api.DTOs;
using service_events_api.Mappings;
using service_events_api.Models;

namespace service_events_api.Services
{
    public class EventService : IEventService
    {
        private static List<Event> _events = new List<Event>()
        {
            new Event("Тест 1", "Описание 1", new DateTime(2026, 9, 30, 8, 0, 0), new DateTime(2026, 9, 30, 9, 30, 0)),
            new Event("Тест 2", null, new DateTime(2026, 10, 1, 12, 0, 0), new DateTime(2026, 10, 3, 0, 00, 0)),
        };

        public EventDto? Create(EventDto eventDto)
        {
            Event create = new Event(eventDto.Title, eventDto.Description, eventDto.StartAt, eventDto.EndAt);
            _events.Add(create);
            return EventMapping.ConvertToDto(create);
        }

        public void Delete(Guid id)
        {
            Event? find = _events.FirstOrDefault(e => e.Id == id);
            if (find == null)
                throw new KeyNotFoundException("Событие с данным Id не найдено");
            _events.Remove(find);
        }

        public List<EventDto?> GetAll()
        {
            return EventMapping.ConvertToDtos(_events);
        }

        public EventDto? GetById(Guid id)
        {
            return EventMapping.ConvertToDto(_events.FirstOrDefault(e => e.Id == id));
        }

        public EventDto? Update(Guid id, EventDto eventDto)
        {
            Event? find = _events.FirstOrDefault(e => e.Id == id);
            if (find == null)
                throw new KeyNotFoundException("Событие с данным Id не найдено");

            find.Title = eventDto.Title;
            find.Description = eventDto.Description;
            find.StartAt = eventDto.StartAt;
            find.EndAt = eventDto.EndAt;
            return EventMapping.ConvertToDto(find);
        }
    }
}
