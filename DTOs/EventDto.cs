namespace service_events_api.DTOs
{
    public class EventDto
    {
        public required Guid Id { get; set; }
        public required string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public required DateTime StartAt { get; set; }
        public required DateTime EndAt { get; set; }
    }
}
