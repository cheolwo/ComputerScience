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
        Task<Commodity> Update(Commodity commodity);
        Task DeleteById(int id);
        Task DeleteByEntity(Commodity commodity);
        Task<Commodity> GetById(int id);
        Task<List<Commodity>> GetToList();  
        // Task AddAsync() 
    }
}
