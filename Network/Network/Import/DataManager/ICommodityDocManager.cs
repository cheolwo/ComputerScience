using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Import.DataManager
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
