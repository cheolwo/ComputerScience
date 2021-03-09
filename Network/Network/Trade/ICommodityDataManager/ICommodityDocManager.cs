using System.Collections.Generic;
using Trade.Model;

namespace Trade.ICommodityDataManager
{
    public interface ICommodityDocManager
    {
        Doc Add(Doc doc);
        Doc GetById(int DocNo);
        List<Doc> GetByCommodityDetail(CommodityDetail CommodityDetail);
        Doc Update(Doc doc);
        Doc DeleteById(int DocNo);
    }
}
