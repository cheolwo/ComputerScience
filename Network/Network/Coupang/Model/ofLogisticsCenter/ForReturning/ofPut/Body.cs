using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofLogisticsCenter.ForReturning.ofPut
{
    class Body
    {
        public string vendorId { get; set; }
        public int returnCenterCode { get; set; }
        public string userId { get; set; }
        public string shippingPlaceName { get; set; }
        public bool usable { get; set; }
        public List<placeAddresses> placeAddresses { get; set; }
        public goodsflowInfoDto goodsflowInfoDto { get; set; }
    }

    public class goodsflowInfoDto
    {
        public int vendorCreditFee05kg { get; set; }
        public int vendorCreditFee10kg { get; set; }
        public int vendorCreditFee20kg { get; set; }
        public int vendorCashFee05kg { get; set; }
        public int vendorCashFee10kg { get; set; }
        public int vendorCashFee20kg { get; set; }
        public int consumeCashFee05kg { get; set; }
        public int consumerCashFee10kg { get; set; }
        public int consumerCashFee20kg { get; set; }

        public int returnFee05kg { get; set; }
        public int returnFee10kg { get; set; }
        public int returnFee20kg { get; set; }
    }
}
