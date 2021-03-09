using Market.Model;
using System.Collections.Generic;

namespace Market.IDataManager.ofSCommodity
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
