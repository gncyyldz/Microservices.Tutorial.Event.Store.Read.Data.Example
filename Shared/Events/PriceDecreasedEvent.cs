namespace Shared.Events
{
    public class PriceDecreasedEvent
    {
        public string ProductId { get; set; }
        public decimal DecrementAmount { get; set; }
    }
}
