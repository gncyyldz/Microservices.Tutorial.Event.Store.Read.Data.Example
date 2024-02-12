namespace Shared.Events
{
    public class CountDecreasedEvent
    {
        public string ProductId { get; set; }
        public int DecrementAmount { get; set; }
    }
}
