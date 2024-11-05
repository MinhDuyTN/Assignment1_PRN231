using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Data.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BranchAccountRepository : IBranchAccountRepository
    {
        private readonly SilverJewelryContext _context;

        public BranchAccountRepository(SilverJewelryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BranchAccount>> GetAllAsync()
        {
            return await _context.BranchAccounts.ToListAsync();
        }

        public async Task<BranchAccount> GetByIdAsync(int accountId)
        {
            return await _context.BranchAccounts.FindAsync(accountId);
        }

        public async Task<BranchAccount> CreateAsync(BranchAccount account)
        {
            _context.BranchAccounts.Add(account);
            await _context.SaveChangesAsync();
            return account;
        }

        public async Task<BranchAccount> UpdateAsync(BranchAccount account)
        {
            _context.BranchAccounts.Update(account);
            await _context.SaveChangesAsync();
            return account;
        }

        public async Task DeleteAsync(int accountId)
        {
            var account = await GetByIdAsync(accountId);
            if (account != null)
            {
                _context.BranchAccounts.Remove(account);
                await _context.SaveChangesAsync();
            }
        }
    }

}
