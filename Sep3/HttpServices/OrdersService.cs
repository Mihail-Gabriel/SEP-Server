using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public class OrdersService : IOrdersService
    {
        private readonly HttpClient _client;

        public OrdersService(HttpClient client)
        {
            _client = client;
        }

        public async Task AddOrderFoodAsync(OrderFood orderFood)
        {
            string jsonOrderFood = JsonSerializer.Serialize(orderFood);
            Console.WriteLine(jsonOrderFood);
            HttpResponseMessage response = await _client.PostAsync("http://localhost:8080/orderfood/add",new StringContent(jsonOrderFood));
            
            if (!response.IsSuccessStatusCode)
                throw new Exception(@"Error:{responseMessage.StatusCode},{responseMessage.ReasonPhrase}");
        }

        public async Task AddOrderAsync(Orders order)
        {
            string jsonOrder = JsonSerializer.Serialize(order);
            Console.WriteLine(jsonOrder);
            HttpResponseMessage response = await _client.PostAsync("http://localhost:8080/order/add",new StringContent(jsonOrder));
            
            if (!response.IsSuccessStatusCode)
                throw new Exception(@"Error:{responseMessage.StatusCode},{responseMessage.ReasonPhrase}");
        }
    }
}