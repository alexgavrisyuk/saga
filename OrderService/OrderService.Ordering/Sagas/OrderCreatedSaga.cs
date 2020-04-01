using System;
using System.Threading.Tasks;
using Chronicle;
using OrderService.MessageQueue;
using OrderService.Ordering.Messages.Events;

namespace OrderService.Ordering.Sagas
{
    public class SagaData
    {
        public bool IsMessage1Received { get; set; }
        public bool IsMessage2Received { get; set; }
    }
    
    public class OrderCreatedSaga : Saga<SagaData>,
        ISagaStartAction<OrderCreatedEvent>,
        ISagaAction<ProductsReservedEvent>

    {
        private readonly RabbitMqClient _rabbitMqClient;

        public OrderCreatedSaga(RabbitMqClient rabbitMqClient)
        {
            _rabbitMqClient = rabbitMqClient;
        }

        
        public Task HandleAsync(OrderCreatedEvent message, ISagaContext context)
        {
            _rabbitMqClient.Publish(message);
            CompleteSaga();
        }

        public async Task CompensateAsync(OrderCreatedEvent message, ISagaContext context)
        {    
            await Task.CompletedTask;
        }


        public Task HandleAsync(ProductsReservedEvent message, ISagaContext context)
        {
            _rabbitMqClient.Publish(message);
            CompleteSaga();
        }

        public async Task CompensateAsync(ProductsReservedEvent message, ISagaContext context)
        {
            await Task.CompletedTask;
        }
        
        private void CompleteSaga()
        {
            if (!Data.IsMessage1Received || !Data.IsMessage2Received) return;
            Complete();
            Console.WriteLine("SAGA COMPLETED");
        }
    }
}