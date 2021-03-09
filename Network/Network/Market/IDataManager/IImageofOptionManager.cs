using Market.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.IDataManager
{
    public interface IImageofOptionManager
    {
        ImageofOption Add(ImageofOption image);
        ImageofOption GetById(int Id);
        ImageofOption Update(ImageofOption image);
        List<ImageofOption> GetToListByOption(Option option);
        void DeleteById(int Id); 
        void DeleteByEntity(ImageofOption imageofOption);
        
        Task<ImageofOption> AddAsync(ImageofOption image);
        Task<ImageofOption> GetByIdAsync(int Id);
        Task<ImageofOption> UpdateAsync(ImageofOption Image);
        Task<List<ImageofOption>> GetToListByOptionAsync(Option option);
        Task DeleteByIdAsync(int Id);
        Task DeleteByEntityAsync(ImageofOption imageofOption);
        Task DeleteByOption(Option updateOption);
    }
}
