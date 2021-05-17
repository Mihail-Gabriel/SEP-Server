using System.Threading.Tasks;

namespace Sep3.Data
{
    public interface IProofData
    {
        Task<string> GetMessageAsync();
        Task SendMessageAsync(string message);
    }
}