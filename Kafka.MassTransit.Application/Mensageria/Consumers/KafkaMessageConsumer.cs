using System;
using System.Threading.Tasks;
using MassTransit;

namespace Kafka.MassTransit.Application.Mensageria.Consumers
{
    public partial class Startup
    {
        public class KafkaMessageConsumer :
            IConsumer<MessageContracts.Startup.IKafkaMessage>
        {
            public Task Consume(ConsumeContext<MessageContracts.Startup.IKafkaMessage> context)
            {
                throw new Exception();
                // return Task.CompletedTask;
            }
        }
    }
}