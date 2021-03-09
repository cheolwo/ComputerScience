using Market.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.IDataManager.ofSCommodity
{
    public interface IOptionManager
    {
        Option Add(Option option);
        List<Option> GetToListByCommodity(SCommodity commodity);
        Option GetById(int Id);
        Option Update(Option option);
        void DeleteById(int Id);
        void DeleteByEntity(Option option);

        Task<Option> AddAsync(Option option);
        Task<List<Option>> GetToListByCommodityAsync(SCommodity commodity);
        Task<Option> GetByIdAsync(int Id);
        Task<Option> UpdateAsync(Option option);
        Task DeleteByIdAsync(int Id);
        Task DeleteByEntityAsync(Option option);
    }
}
