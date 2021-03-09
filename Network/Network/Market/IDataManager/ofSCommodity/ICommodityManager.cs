using Market.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.IDataManager.ofSCommodity
{
    /// <summary>
    /// Add, UPDATE, DELETE, GET, GETLIST
    /// </summary>
    public interface ICommodityManager
    {
        Task<SCommodity> AddAsync(SCommodity commodity);
        Task<SCommodity> UpdateAsync(SCommodity commodity);
        Task DeleteByIdAsync(int Id);
        Task DeleteByEntityAsync(SCommodity commodity);
        Task<SCommodity> GetByIdAsync(int Id);
        Task<List<SCommodity>> GetToListAsync();

        SCommodity Add(SCommodity commodity);
        SCommodity GetById(int Id);
        List<SCommodity> GetToList();
        SCommodity Update(SCommodity commodity);
        void DeleteByEntity(SCommodity commodity);
        void DeleteById(int Id);

        // Task AddAsync() 
    }
}
