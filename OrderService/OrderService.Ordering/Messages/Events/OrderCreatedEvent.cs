using MediatR;

namespace OrderService.Ordering.Messages.Events
{
    public class OrderCreatedEvent : INotification 
    {
        public int Id { get; set; }
    }
}