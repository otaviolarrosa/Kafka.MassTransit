namespace Kafka.MassTransit.Application.Mensageria.MessageContracts
{
    public partial class Startup
    {
        public interface IKafkaMessage
        {
            string Text { get; }
        }
    }
}