using System.Threading.Tasks;
using Shared.Messages;
using Shared.RabbitMq;

namespace Shared.Handlers
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event, ICorrelationContext context);
    }
}