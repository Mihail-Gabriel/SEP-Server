using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public class BranchWebService : IBranchService
    {
        private readonly HttpClient _client;
        public BranchWebService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Branch>> GetBranchesAsync()
        {
            
            HttpResponseMessage responseMessage = await _client.GetAsync("http://localhost:8080/branch/all");

            if (!responseMessage.IsSuccessStatusCode)
                throw new (@"Error:{responseMessage.StatusCode},{responseMessage.ReasonPhrase}");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Branch> branches = JsonSerializer.Deserialize<List<Branch>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return branches;

        }


        public async Task AddBranchAsync(Branch branch)
        {
           
            HttpResponseMessage response = await _client.PostAsync("http://localhost:8080/branch/add",new StringContent(branch.ToString()));
            if (!response.IsSuccessStatusCode)
                throw new Exception(@"Error:{responseMessage.StatusCode},{responseMessage.ReasonPhrase}");
        }

        public async Task RemoveBranchAsync(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync("http://localhost:8080/branch/remove?id="+id);
            if (!response.IsSuccessStatusCode)
                throw new Exception(@"Error:{responseMessage.StatusCode},{responseMessage.ReasonPhrase}");
        }

        public async Task<Branch> GetBranchByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task AddNewOrderAsync(Order order)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Order> GetOrderAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}