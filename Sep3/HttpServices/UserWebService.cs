using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public class UserWebService : IUserService
    {
        private readonly HttpClient _client;

        public UserWebService(HttpClient client)
        {
            this._client = client;
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            
            var url = "http://localhost:8080/user/login";
            var resp =  await _client.PostAsync(url,new StringContent(username+" "+password));
            var user = resp.Content.ReadFromJsonAsync<User>().Result;
            Console.WriteLine("USER+++ "+user.username+" "+user.address+" "+user.telephoneNo +" " +user.city+" "+user.password+" "+user.role);
            return user;
        
        }

        public async Task<User> RegisterUserAsync(string username, string password, string number, string address, string city)
        {
            var url = "http://localhost:8080/user/register";
            
            User newUser = new User {username = username, password = password, telephoneNo = number, address = address, city = city, role = "0"};
            string userAsJson = JsonSerializer.Serialize(newUser);
            HttpContent content = new StringContent(userAsJson, Encoding.UTF8, "application/json");
            
            var resp =  await _client.PostAsync(url,content);
            var user = resp.Content.ReadFromJsonAsync<User>().Result;
            return user;
        }
    }
}