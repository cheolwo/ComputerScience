using Import.Model;
using Market.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Market.IDataManager.ofSCommodity
{
    public interface ICommodityDetailManager
    {
        Task<DetailofSCommodity> AddAsync(DetailofSCommodity commodityDetail);
        Task<DetailofSCommodity> UpdateAsync(DetailofSCommodity commodityDetail);
        Task DeleteByIdAsync(int Id);
        Task<DetailofSCommodity> GetByIdAsync(int Id);
        Task<DetailofSCommodity> GetByCommodityAsync(SCommodity commodity);
        Task<List<DetailofSCommodity>> GetToListAsync();

        DetailofSCommodity Add(DetailofSCommodity commodityDetail);
        DetailofSCommodity Update(DetailofSCommodity commodityDetail);
        void DeleteById(int Id);
        DetailofSCommodity GetById(int Id);
        DetailofSCommodity GetByCommodity(SCommodity commodity);
        List<DetailofSCommodity> GetToList();
    }
}
