using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public interface IImageofDetailManager
    {
        void Add(ImageofDetail Image);
        void DeleteById(int ImageNo);
        ImageofDetail GetById(int ImageNo);
        List<ImageofDetail> GetByCommodityToList(Commodity commodity);
        void Update(ImageofDetail Image);

        Task GetByEntity(CommodityDetail commodityDetail);
    }
}
