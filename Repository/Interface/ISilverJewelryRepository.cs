using Repository.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface ISilverJewelryRepository
    {
        Task<IEnumerable<SilverJewelry>> GetAllAsync();
        Task<SilverJewelry> GetByIdAsync(string jewelryId);
        Task CreateAsync(SilverJewelry jewelry);
        Task UpdateAsync(SilverJewelry jewelry);
        Task DeleteAsync(string jewelryId);
    }

}
