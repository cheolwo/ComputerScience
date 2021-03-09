using Market.Model;
using System.Collections.Generic;

namespace Market.IDataManager
{
    public interface ICommodityDocManager
    {
        Doc Add(Doc doc);
        Doc GetById(int Id);
        List<Doc> GetByCommodityDetail(DetailofSCommodity CommodityDetail);
        Doc Update(Doc doc);
        Doc DeleteById(int Id);
    }
}
