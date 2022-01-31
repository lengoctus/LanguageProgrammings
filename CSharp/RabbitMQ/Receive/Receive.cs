using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ReceiveMessage
{
    public class Receive
    {
        public static void Main()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var messages = body;
                    
                };
            }
        }
    }
}