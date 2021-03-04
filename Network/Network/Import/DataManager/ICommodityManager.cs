﻿using Import.Model;
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
        // Task AddAsync() 
    }
}
