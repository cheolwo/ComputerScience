using Market.Model;
using Market.Model.ofSCommodity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.IDataManager.ofSCommodity
{
    public interface IImageofDetailManager
    {
        ImageofDetail Add(ImageofDetail image);
        void DeleteByEntity(ImageofDetail imageofDetail);
        void DeleteById(int Id);
        ImageofDetail GetById(int Id);
        List<ImageofDetail> GetToListByImageofOption(ImageofOption imageofOption);
        ImageofDetail Update(ImageofDetail image);

        Task<ImageofDetail> AddAsync(ImageofDetail image);
        Task DeleteByEntityAsync(ImageofDetail imageofDetail);
        Task DeleteByIdAsync(int Id);
        Task<ImageofDetail> GetByIdAsync(int Id);
        Task<List<ImageofDetail>> GetToListByImageofOptionAsync(ImageofOption imageofOption);
        Task<ImageofDetail> UpdateAsync(ImageofDetail image);
    }
}
