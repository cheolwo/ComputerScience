using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Import.DataManager
{
    public interface ICommodityDetailManager
    {
        Task<CommodityDetail> AddAsync(CommodityDetail commodityDetail);
        Task<CommodityDetail> UpdateAsync(CommodityDetail commodityDetail);
        Task DeleteByIdAsync(int DetailNo);
        Task<CommodityDetail> GetByIdAsync(int DetailNo);
        Task<CommodityDetail> GetByCommodityAsync(Commodity commodity);
        Task<List<CommodityDetail>> GetToListAsync();

        CommodityDetail Add(CommodityDetail commodityDetail);
        CommodityDetail Update(CommodityDetail commodityDetail);
        void DeleteById(int DetailNo);
        CommodityDetail GetById(int DetailNo);
        CommodityDetail GetByCommodity(Commodity commodity);
        List<CommodityDetail> GetToList();
    }
}
