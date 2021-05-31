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