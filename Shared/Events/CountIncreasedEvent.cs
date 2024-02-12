namespace Shared.Events
{
    public class CountIncreasedEvent
    {
        public string ProductId { get; set; }
        public int IncrementAmount { get; set; }
    }
}
