using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofLogisticsCenter.ForReturning.ofPost
{
    public class Body
    {
        public string vendorId { get; set; }
        public string usesrId { get; set; }
        public string shippingPlaceName { get; set; }

        public goodsflowInfoOpenApiDto goodsflowInfoOpenApiDto { get; set; }
        public List<placeAddresses> placeAddresses { get; set; }
    }

    public class goodsflowInfoOpenApiDto
    {
        public string deliveryCode { get; set; }
        public string deliveryName { get; set; }
        public string contractNumber { get; set; }
        public string contractCustomerNumber { get; set; }
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
