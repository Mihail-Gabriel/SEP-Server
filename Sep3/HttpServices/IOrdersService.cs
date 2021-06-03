using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public interface IOrdersService
    {
        Task AddOrderFoodAsync(OrderFood orderFood);
        Task AddOrderAsync(Orders order);
    }
}