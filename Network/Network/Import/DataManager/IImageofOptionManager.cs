using Import.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public interface IImageofOptionManager
    {
        ImageofOption Add(ImageofOption image);
        ImageofOption GetById(int imageNo);
        ImageofOption Update(ImageofOption image);
        List<ImageofOption> GetToListByOption(Option option);
        void DeleteById(int imageNo);
        void DeleteByEntity(ImageofOption imageofOption);
        
        Task<ImageofOption> AddAsync(ImageofOption image);
        Task<ImageofOption> GetByIdAsync(int imageNo);
        Task<ImageofOption> UpdateAsync(ImageofOption Image);
        Task<List<ImageofOption>> GetToListByOptionAsync(Option option);
        Task DeleteByIdAsync(int imgaeNo);
        Task DeleteByEntityAsync(ImageofOption imageofOption);
        Task DeleteByOption(Option updateOption);
    }
}
