namespace service_events_api.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public Event(string title, string? description, DateTime startAt, DateTime endAt)
        {
            Id = Guid.NewGuid();
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("Наименование меропрития должно быть заполнено");
            Title = title;
            Description = description;
            StartAt = startAt;
            EndAt = endAt;
            if (startAt.Date > endAt.Date)
                throw new ArgumentNullException("Дата начала не может быть позже даты окончания");
        }
    }
}
