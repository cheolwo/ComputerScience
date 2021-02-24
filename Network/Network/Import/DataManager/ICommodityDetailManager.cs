using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Import.DataManager
{
    public interface ICommodityDetailManager
    {
        void Add(CommodityDetail commodityDetail);
        void Update(int DetailNo, CommodityDetail commodityDetail);
        void DeleteById(int DetailNo);
        CommodityDetail GetById(int DetailNo);
        CommodityDetail GetByCommodity(Commodity commodity);
    }
}
