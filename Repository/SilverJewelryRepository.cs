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
    public class SilverJewelryRepository : ISilverJewelryRepository
    {
        private readonly SilverJewelryContext _context;

        public SilverJewelryRepository(SilverJewelryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SilverJewelry>> GetAllAsync()
        {
            return await _context.SilverJewelries.ToListAsync();
        }

        public async Task<SilverJewelry> GetByIdAsync(string jewelryId)
        {
            return await _context.SilverJewelries.FindAsync(jewelryId);
        }

        public async Task CreateAsync(SilverJewelry jewelry)
        {
            _context.SilverJewelries.Add(jewelry);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SilverJewelry jewelry)
        {
            _context.SilverJewelries.Update(jewelry);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string jewelryId)
        {
            var jewelry = await GetByIdAsync(jewelryId);
            if (jewelry != null)
            {
                _context.SilverJewelries.Remove(jewelry);
                await _context.SaveChangesAsync();
            }
        }
    }

}
