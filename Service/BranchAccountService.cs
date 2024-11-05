using Repository.Data.DTO;
using Repository.Data.Entity;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BranchAccountService : IBranchAccountService
    {
        private readonly IBranchAccountRepository _branchAccountRepository;

        public BranchAccountService(IBranchAccountRepository branchAccountRepository)
        {
            _branchAccountRepository = branchAccountRepository;
        }

        public async Task<List<BranchAccountDTO>> GetAllAccountsAsync()
        {
            var accounts = await _branchAccountRepository.GetAllAsync();
            return accounts.Select(account => new BranchAccountDTO
            {
                AccountID = account.AccountID,
                FullName = account.FullName,
                EmailAddress = account.EmailAddress,
                Role = account.Role
            }).ToList();
        }

        public async Task<BranchAccountDTO> GetAccountByIdAsync(int accountId)
        {
            var account = await _branchAccountRepository.GetByIdAsync(accountId);
            if (account == null) return null;

            // Chuyển đổi từ Entity sang DTO
            return new BranchAccountDTO
            {
                AccountID = account.AccountID,
                AccountPassword = account.AccountPassword,
                FullName = account.FullName,
                EmailAddress = account.EmailAddress,
                Role = account.Role
            };
        }

        public async Task<BranchAccountDTO> CreateAccountAsync(BranchAccountDTO accountDto)
        {
            var newAccount = new BranchAccount
            {
                AccountID = accountDto.AccountID,
                AccountPassword = accountDto.AccountPassword,
                FullName = accountDto.FullName,
                EmailAddress = accountDto.EmailAddress,
                Role = accountDto.Role
            };

            var createdAccount = await _branchAccountRepository.CreateAsync(newAccount);

            return new BranchAccountDTO
            {
                AccountID = createdAccount.AccountID,
                AccountPassword = createdAccount.AccountPassword,
                FullName = createdAccount.FullName,
                EmailAddress = createdAccount.EmailAddress,
                Role = createdAccount.Role
            };
        }

        public async Task<BranchAccountDTO> UpdateAccountAsync(int accountId, BranchAccountDTO accountDto)
        {
            var accountToUpdate = await _branchAccountRepository.GetByIdAsync(accountId);
            if (accountToUpdate == null) return null;

            accountToUpdate.AccountPassword = accountDto.AccountPassword;
            accountToUpdate.FullName = accountDto.FullName;
            accountToUpdate.EmailAddress = accountDto.EmailAddress;
            accountToUpdate.Role = accountDto.Role;

            var updatedAccount = await _branchAccountRepository.UpdateAsync(accountToUpdate);

            return new BranchAccountDTO
            {
                AccountID = updatedAccount.AccountID,
                AccountPassword = updatedAccount.AccountPassword,
                FullName = updatedAccount.FullName,
                EmailAddress = updatedAccount.EmailAddress,
                Role = updatedAccount.Role
            };
        }

        public async Task<bool> DeleteAccountAsync(int accountId)
        {
            return await _branchAccountRepository.DeleteAsync(accountId);
        }
    }
}
