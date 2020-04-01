using System;
using System.Windows.Input;
using Shared.Messages;
using Shared.Types;

namespace Shared.RabbitMq
{
    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeCommand<TCommand>(string @namespace = null, string queueName = null,
            Func<TCommand, GeneralException, IRejectedEvent> onError = null)
            where TCommand : ICommand;

        IBusSubscriber SubscribeEvent<TEvent>(string @namespace = null, string queueName = null,
            Func<TEvent, GeneralException, IRejectedEvent> onError = null) 
            where TEvent : IEvent;
    }
}