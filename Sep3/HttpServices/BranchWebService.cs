using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public class BranchWebService : IBranchService
    {
        public async Task<List<Branch>> GetBranchesAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/branch/all");

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
            throw new System.NotImplementedException();
        }

        public async Task RemoveBranchAsync(int id)
        {
            throw new System.NotImplementedException();
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