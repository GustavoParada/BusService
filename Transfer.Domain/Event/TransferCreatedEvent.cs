using Project.Domain.Core.Events;

namespace Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }

        public int From { get; set; }

        public int To { get; set; }

        public decimal Amount { get; set; }
    }
}
