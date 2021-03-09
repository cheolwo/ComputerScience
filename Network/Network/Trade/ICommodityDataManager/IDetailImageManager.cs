using System.Collections.Generic;
using Trade.Model;

namespace Trade.ICommodityDataManager
{
    public interface IDetailImageManager
    {
        DetailImage GetById(int detailImageNo);
        void DeleteByDetailImage(DetailImage detailImage);
        List<DetailImage> GetToList();
        List<DetailImage> GetToListByCommmodityDetail(CommodityDetail commodityDetail);
        DetailImage Add(DetailImage detailImage);
        DetailImage Update(DetailImage detailImage);
    }
}
