using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
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

        Commodity Add(Commodty commodity);
        Commodity GetById(int id);
        List<Commodity> GetToList();
        Commodity Update(Commodity commodity);
        void DeleteByEntity(Commodity commodity);
        void DeleteById(int id);

        // Task AddAsync() 
    }
}
