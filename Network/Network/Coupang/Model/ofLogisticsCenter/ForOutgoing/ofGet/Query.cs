using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofLogisticsCenter.ForOutgoing.ofGet
{
    public class Query
    {
        public long placeCode { get; set; }
        public string placeNames { get; set; }
        public int pageNum { get; set; }
        public int pageSize { get; set; }
    }
}
