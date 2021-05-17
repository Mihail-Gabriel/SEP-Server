using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);
        Task<User> RegisterUserAsync(string username, string password, string number, string address, string city);
    }
}