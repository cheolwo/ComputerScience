using Coupang.Model.ofCommodity.ofGet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofCommodity.ofPut
{
    public class Body
    {
        public int sellerProductId { get; set; }
        public int displayCategoryCode { get; set; }
        public int deliveryCharge { get; set; }
        public int freeShipOverAmount { get; set; }
        public int deliveryChargeOnReturn { get; set; }
        public int returnCharge { get; set; }
        public int outboundShippingPlaceCode { get; set; }

        public string statusName { get; set; }
        public string sellerProductName { get; set; }
        public string vendorId { get; set; }
        public string saleStartedAt { get; set; }
        public string saleEndedAt { get; set; }
        public string displayProductName { get; set; }
        public string brand { get; set; }
        public string generalProductName { get; set; }
        public string productGroup { get; set; }
        public string deliveryMethod { get; set; }
        public string deliveryCompanyCode { get; set; }
        public string deliveryChargeType { get; set; }
        public string remoteAreaDeliverable { get; set; }
        public string unionDeliveryType { get; set; }

        public string returnCenterCode { get; set; }
        public string returnChargeName { get; set; }
        public string companyContactNumber { get; set; }
        public string returnZipCode { get; set; }
        public string returnAddress { get; set; }
        public string returnAddressDetail { get; set; }
        public string returnChargeVendor { get; set; }
        public string afterServiceInformation { get; set; }
        public string afterServiceContactNumber { get; set; }
        public string vendorUserId { get; set; }

        public string extraInfoMessage { get; set; }
        public string manufacture { get; set; }

        public bool requested { get; set; }
        public bool pccNeeded { get; set; }
        public bool bestPriceGuaranteed3P { get; set; }
        public bool emptyBarcode { get; set; }

        public List<requiredDocument> requiredDocuments { get; set; }
        public List<item> items { get; set; }
    }
}
