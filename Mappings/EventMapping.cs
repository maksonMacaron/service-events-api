using service_events_api.DTOs;
using service_events_api.Models;

namespace service_events_api.Mappings
{
    public static class EventMapping
    {
        public static List<EventDto?> ConvertToDtos(List<Event> events)
        {
            if (events == null) throw new ArgumentNullException("Ошибка конвертации ConvertToDtos(List<Event> events)");
            if (events.Count == 0) return new List<EventDto?>();

            return events.Select(e => (ConvertToDto(e))).ToList();
        }

        public static EventDto? ConvertToDto(Event? currnetEvent)
        {
            if (currnetEvent == null)
                return null;

            EventDto eventDto = new EventDto()
            {
                EndAt = currnetEvent.EndAt,
                Id = currnetEvent.Id,
                StartAt = currnetEvent.StartAt,
                Title = currnetEvent.Title,
                Description = currnetEvent.Description,
            };
            return eventDto;
        }
    }
}
