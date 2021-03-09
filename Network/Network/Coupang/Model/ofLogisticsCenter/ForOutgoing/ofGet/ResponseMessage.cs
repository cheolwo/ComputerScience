using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofLogisticsCenter.ForOutgoing.ofGet
{
    public class ResponseMessage
    {
            public List<Content> Content { get; set; }
    }

    public class Content
    {
        public int outboundShippingPlaceCode { get; set; }
        public string shippingPlaceName { get; set; }
        public List<placeAddresses> placeAddresses { get; set; }
        public List<remoteInfos> remoteInfos { get; set; }
        public string createDate { get; set; }
        public bool usable { get; set; }
    }

    public class pagination
    {
        public int currentPage { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public int countPerPage { get; set; }
    }
}
