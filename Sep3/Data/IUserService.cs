using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.Data
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);
        Task RegisterUserAsync(string username, string password, string number, string address, string city);
    }
}