using System.Collections.Generic;
using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public interface IBranchService
    {
        Task<List<Branch>> GetBranchesAsync();
        Task AddBranchAsync(Branch branch);
        Task RemoveBranchAsync(int id);

        Task<Menu> GetMenuByNameAsync(string name);

        Task AddMenuAsync(Menu menu);
    }
}