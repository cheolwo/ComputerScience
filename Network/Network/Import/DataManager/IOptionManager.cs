using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public interface IOptionManager
    {
        Option Add(Option option);
        List<Option> GetToListByCommodity(Commodity commodity);
        Option GetById(int optionNo);
        Option Update(Option option);
        void DeleteById(int optionNo);
        void DeleteByEntity(Option option);

        Task<Option> AddAsync(Option option);
        Task<List<Option>> GetToListByCommodityAsync(Commodity commodity);
        Task<Option> GetByIdAsync(int optionNo);
        Task<Option> UpdateAsync(Option option);
        Task DeleteByIdAsync(int optionNo);
        Task DeleteByEntityAsync(Option option);
    }
}
