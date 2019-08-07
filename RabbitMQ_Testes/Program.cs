using RabbitMQ.Client;
using System;
using System.Text;

namespace RabbitMQ_Testes
{
    public class Publisher
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName="dupa.com.br", UserName= "userRabbit", Password="12345" };

            using (var connection =  factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("teste", false, false, false, null);

                    string message = "Olá mundo!";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish("", "teste", null, body);

                    Console.WriteLine("Mensagem enviada {0}", message);
                }
            }
        }
    }
}
