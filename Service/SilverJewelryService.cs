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
    public class SilverJewelryService : ISilverJewelryService
    {
        private readonly ISilverJewelryRepository _silverJewelryRepository;

        public SilverJewelryService(ISilverJewelryRepository silverJewelryRepository)
        {
            _silverJewelryRepository = silverJewelryRepository;
        }

        public async Task<IEnumerable<SilverJewelry>> GetAllAsync()
        {
            return await _silverJewelryRepository.GetAllAsync();
        }

        public async Task<SilverJewelry> GetByIdAsync(string jewelryId)
        {
            return await _silverJewelryRepository.GetByIdAsync(jewelryId);
        }

        public async Task CreateAsync(SilverJewelry jewelry)
        {
            await _silverJewelryRepository.CreateAsync(jewelry);
        }

        public async Task UpdateAsync(SilverJewelry jewelry)
        {
            await _silverJewelryRepository.UpdateAsync(jewelry);
        }

        public async Task DeleteAsync(string jewelryId)
        {
            await _silverJewelryRepository.DeleteAsync(jewelryId);
        }
    }
}
