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
        void Add(Commodity commodity);
        Task AddAsync(Commodity commodity);
        void Update(int EntityNo, Commodity commodity);
        void Update(Commodity commodity);
        void DeleteById(int id);
        void DeleteByEntity(Commodity commodity);
        Commodity GetById(int id);
        List<Commodity> GetToList();  
        // Task AddAsync() 
    }
}
