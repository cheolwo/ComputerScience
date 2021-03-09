using System.Collections.Generic;
using System.Threading.Tasks;
using Trade.Model;

namespace Trade.ICommodityDataManager
{
    public interface IImageofDetailManager
    {
        ImageofDetail Add(ImageofDetail image);
        void DeleteByEntity(ImageofDetail imageofDetail);
        void DeleteById(int imageNo);
        ImageofDetail GetById(int imageNo);
        List<ImageofDetail> GetToListByImageofOption(ImageofOption imageofOption);
        ImageofDetail Update(ImageofDetail image);

        Task<ImageofDetail> AddAsync(ImageofDetail image);
        Task DeleteByEntityAsync(ImageofDetail imageofDetail);
        Task DeleteByIdAsync(int imageNo);
        Task<ImageofDetail> GetByIdAsync(int imageNo);
        Task<List<ImageofDetail>> GetToListByImageofOptionAsync(ImageofOption imageofOption);
        Task<ImageofDetail> UpdateAsync(ImageofDetail image);
    }
}
