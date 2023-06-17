using Azure.Messaging.EventGrid;
using System;
using Azure;
using System.Collections.Generic;
using System.Text.Json;

namespace PublishEvents
{
    class Program
    {
        private static Uri topic_endpoint;
        private static AzureKeyCredential topic_accesskey;

        static void Main(string[] args)
        {
            topic_endpoint = new Uri("https://apptopic.francecentral-1.eventgrid.azure.net/api/events");
            topic_accesskey = new AzureKeyCredential("BNaS7qaGpqwhO6DhOsK64blVzYDfRTQx7hDOJb38zwo=");

            EventGridPublisherClient _client = new EventGridPublisherClient(topic_endpoint, topic_accesskey);

            Order _order = new Order()
            {
                OrderID = "O1",
                UnitPrice = 9.99m,
                Quantity = 100
            };

            List<EventGridEvent> _eventsList = new List<EventGridEvent>()
            {
                new EventGridEvent("Placing new order","app.neworder","1.0",JsonSerializer.Serialize(_order))
            };

            _client.SendEvents(_eventsList);
            Console.WriteLine("Sending Event");
            Console.ReadKey();
        }
    }
}
