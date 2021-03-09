using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofLogisticsCenter.ForOutgoing.ofPut
{
    class Body
    {
        public string vendorId { get; set; }
        public string userId { get; set; }
        public int outboundShippingPlaceCode { get; set; }
        public string shippingPlaceName { get; set; }
        public bool usable { get; set; }
        public bool global { get; set; }
        public List<placeAddresses> placeAddresses { get; set; }
        public List<remoteInfos> remoteInfos { get; set; }
    }
}
