using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace RabbitMQ_Testes
{
    public class Consumer
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "dupa.com.br", UserName = "userRabbit", Password = "12345" };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("teste", false, false, false, null);

                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, ea) => {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);

                        Console.WriteLine("Mensagem recebida {0}", message);
                    };

                    channel.BasicConsume("teste", true, consumer);

                    Console.ReadKey();
                }
            }
        }
    }
}
