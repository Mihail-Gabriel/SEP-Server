using System.Collections.Generic;
using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public class BranchWebService : IBranchService
    {
        public async Task<List<Branch>> GetBranchesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task AddBranchAsync(Branch branch)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveBranchAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Menu> GetMenuByNameAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task AddMenuAsync(Menu menu)
        {
            throw new System.NotImplementedException();
        }
    }
}