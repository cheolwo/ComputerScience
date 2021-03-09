using System.Collections.Generic;
using System.Threading.Tasks;
using Trade.Model;

namespace Trade.ICommodityDataManager
{
    /// <summary>
    /// Add, UPDATE, DELETE, GET, GETLIST
    /// </summary>
    public interface ICommodityManager
    {
        Task<Commodity> AddAsync(Commodity commodity);
        Task<Commodity> UpdateAsync(Commodity commodity);
        Task DeleteByIdAsync(int id);
        Task DeleteByEntityAsync(Commodity commodity);
        Task<Commodity> GetByIdAsync(int id);
        Task<List<Commodity>> GetToListAsync();  

        Commodity Add(Commodity commodity);
        Commodity GetById(int id);
        List<Commodity> GetToList();
        Commodity Update(Commodity commodity);
        void DeleteByEntity(Commodity commodity);
        void DeleteById(int id);

        // Task AddAsync() 
    }
}
