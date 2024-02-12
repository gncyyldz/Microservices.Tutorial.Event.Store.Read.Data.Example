namespace Shared.Events
{
    public class AvailabilityChangedEvent
    {
        public string ProductId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
