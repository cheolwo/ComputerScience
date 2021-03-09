using System.Collections.Generic;

namespace Coupang.Model.ofCommodity.ofGet
{
    public class ResponseMessage
    {
        public int code { get; set; }
        public string message { get; set; }
        public data data { get; set; }
    }

    public class data
    {
        public string code { get; set; }
        public string message { get; set; }

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


    public class item
    {
        public int sellerProductItemId { get; set; }
        public int vendorItemId { get; set; }
        public int originalPrice { get; set; }
        public int salePrice { get; set; }
        public int maximumBuyCount { get; set; }
        public int maximumBuyForPerson { get; set; }
        public int maximumBuyForPersonPeriod { get; set; }
        public int outboundShippingTimeDay { get; set; }

        // string
        public string itemName { get; set; }
        public string adultOnly { get; set; }
        public string taxType { get; set; }
        public string parallelImported { get; set; }
        public string overseasPurchased { get; set; }
        public string externalVendorSku { get; set; }
        public string barcode { get; set; }
        public string emptyBarcodeReason { get; set; }
        public string modelNo { get; set; }

        public Dictionary<string, string> extraProperties { get; set; }
        public List<certification> certifications { get; set; }
        public List<string> searchTags { get; set; }
        public List<image> images { get; set; }
        public List<notice> notices { get; set; }
        public List<attribute> attributes { get; set; }
        public List<content> contents { get; set; }

        public string offerCondition { get; set; }
        public string offerDescription { get; set; }
    }

    public class content
    {
        public string contentsType { get; set; }
        public List<contentDetail> contentsDetail { get; set; }
    }

    public class image
    {
        public int imageOrder { get; set; }
        public string imageType { get; set; }
        public string cdnPath { get; set; }
        public string vendorPath { get; set; }

    }

    public class certification
    {
        public string certificationType { get; set; }
        public string certificationCode { get; set; }
    }

    public class requiredDocument
    {
        public string templateName { get; set; }
        public string documentPath { get; set; }
        public string vendorDocumentPath { get; set; }
    }

    public class notice
    {
        public string noticeCategoryName { get; set; }
        public string noticeCategoryDetailName { get; set; }
        public string content { get; set; }
    }

    public class attribute
    {
        public string attributeTypeName { get; set; }
        public string attributeValueName { get; set; }
        public string exposed { get; set; }
        public string editable { get; set; }
    }

    public class contentDetail
    {
        public string detailType { get; set; }
        public string content { get; set; }
    }
}
/*
 * HTTP 상태 코드 (오류 유형)	오류 메시지	해결 방법
400 (요청변수확인)	상품 정보가 등록 또는 수정되고 있습니다. 잠시 후 다시 조회해 주시기 바랍니다. [1320***883]	상품등록 요청 수행 이후 최소 10분 이후에 조회 요청합니다. 
400 (요청변수확인)	업체[A00123456]는 다른 업체[A0011***5]의 상품을 조회할 수 없습니다.	등록상품ID(sellerProductId) 값을 올바로 입력했는지 확인합니다.
400 (요청변수확인)	상품(123456789)의 데이터가 없습니다.	등록상품ID(sellerProductId) 값을 올바로 입력했는지 확인합니다.
400 (요청변수확인)	업체상품아이디[null]는 숫자형으로 입력해주세요.	등록상품ID(sellerProductId) 값을 올바른 숫자로 입력했는지 확인합니다.
 */
