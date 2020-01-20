using RabbitMQ.Client;
using System;
using System.Text;

namespace Player
{
    class PlaceBet
    {
        static void Main(string[] args)
        {
      var factory = new ConnectionFactory() { HostName = "10.0.15.40" , UserName = "rabbit", Password = "QCctDqnyu2ig" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("PlaceBet", false, false, false, null);
                    var message = "Place bet request";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish("","PlaceBet",null,body);
                    Console.WriteLine(" [x] Sent {0}", message);
                }
            }
        }
    }
}
