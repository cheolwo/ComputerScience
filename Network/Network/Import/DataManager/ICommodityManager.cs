using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Import.DataManager
{
    /// <summary>
    /// Add, UPDATE, DELETE, GET, GETLIST
    /// </summary>
    public interface ICommodityManager
    {
        void Add(Commodity commodity);
        void Upetae(int EntityNo, Commodity commodity);
        void DeleteById(int id);
        void DeleteByEntity(Commodity commodity);
        Commodity GetById(int id);
        List<Commodity> GetToList();  
    }
}
