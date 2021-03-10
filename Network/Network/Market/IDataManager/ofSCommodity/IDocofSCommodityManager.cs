using Market.Model;
using Market.Model.ofSCommodity;
using System.Collections.Generic;

namespace Market.IDataManager.ofSCommodity
{
    public interface IDocofSCommodityManager
    {
        Doc Add(Doc doc);
        Doc GetById(int Id);
        List<Doc> GetByCommodityDetail(DetailofSCommodity CommodityDetail);
        Doc Update(Doc doc);
        Doc DeleteById(int Id);
    }
}
