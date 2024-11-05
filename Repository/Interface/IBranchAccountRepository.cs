using Repository.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBranchAccountRepository
    {
        Task<IEnumerable<BranchAccount>> GetAllAsync();
        Task<BranchAccount> GetByIdAsync(int accountId);
        Task<BranchAccount> CreateAsync(BranchAccount account);
        Task<BranchAccount> UpdateAsync(BranchAccount account);
        Task DeleteAsync(int accountId);
    }

}
