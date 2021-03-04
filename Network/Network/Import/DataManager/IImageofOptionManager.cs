using Import.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public interface IImageofOptionManager
    {
        void Add(ImageofOption Image);
        void DeleteById(int ImageNo);
        ImageofOption GetById(int ImageNo);
        List<ImageofOption> GetByCommodityToList(Commodity commodity);
        void Update(ImageofOption Image);
        List<ImageofOption> GetByOptionToList(Option option);
        
        Task GetByEntities(List<Option> options);
    }
}
