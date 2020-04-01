using System.Threading.Tasks;
using System.Windows.Input;
using Shared.RabbitMq;

namespace Shared.Handlers
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command, ICorrelationContext context);
    }
}