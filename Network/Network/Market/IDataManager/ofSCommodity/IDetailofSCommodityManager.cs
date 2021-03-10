using Market.Model;
using Market.Model.ofSCommodity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.IDataManager.ofSCommodity
{
    public interface IDetailofSCommodityManager
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
