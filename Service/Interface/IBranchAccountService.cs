using Repository.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBranchAccountService
    {
        Task<List<BranchAccountDTO>> GetAllAccountsAsync();
        Task<BranchAccountDTO> GetAccountByIdAsync(int accountId);
        Task<BranchAccountDTO> CreateAccountAsync(BranchAccountDTO accountDto);
        Task<BranchAccountDTO> UpdateAccountAsync(int accountId, BranchAccountDTO accountDto);
        Task<bool> DeleteAccountAsync(int accountId);
    }
}
