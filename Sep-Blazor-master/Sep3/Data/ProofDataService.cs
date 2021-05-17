using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sep3.Data
{
    public class ProofDataService : IProofData
    {
        private string uri = "http://localhost:8080/message"; //What is the URI?
        private readonly HttpClient client;

        public ProofDataService()
        {
            client = new HttpClient();
        }
        
        public async Task<string> GetMessageAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri);
            string message = await stringAsync;
            
            return message;
        }

        public async Task SendMessageAsync(string message)
        {
            HttpContent content = new StringContent(message, Encoding.UTF8);
            await client.PostAsync(uri, content); //What is the URI?
        }
    }
}