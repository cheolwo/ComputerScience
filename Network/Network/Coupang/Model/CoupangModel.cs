// 출고지 등록 API
// RequestBody
using System.Collections.Generic;

public class Warehouse
{
    public string VendorId { get; set; }
    public string UserId { get; set; }
    public string shippingPlaceName { get; set; }
    public bool Usable { get; set; }
    public bool global { get; set; }
    public placeAddresses[] placeAddresses { get; set; }
    public remoteInfos[] remoteInfos { get; set; }
}

public class placeAddresses
{
    public string addressType { get; set; }
    public string countryCode { get; set; }
    public string companyContactNumber { get; set; }
    public string phoneNumber2 { get; set; }
    public string returnZipCode { get; set; }
    public string returnAddress { get; set; }
    public string returnAddressDetail { get; set; }
}

public class remoteInfos
{
    public string deliveryCode { get; set; }
    public int jeju { get; set; }
    public int notJeju { get; set; }
}
// Response Message
public class ResponseofCreateWarehouse
{
    public int code { get; set; }
    public string message { get; set; }
    public data data { get; set; }

}

public class data
{
    public string resultCode { get; set; }
    public string resultMessage { get; set; }
}
/*****************************************************/
// 출고지 조회 API
// Query String Parameters
public class WarehouseInfoQuery
{
    public long placeCode { get; set; }
    public string placeNames { get; set; }
    public int pageNum { get; set; }
    public int pageSize { get; set; }
}

// Not RequireBody
//Respense Message
public class WarehouseInfo
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
/*****************************************************/
// 출고지 수정 API

// Path Segment Parameter

public class UpdateWarehousePathParameter
{
    public string vendorId { get; set; }
    public int outboundShippingPlaceCode { get; set; }
}

// Body Parameter
public class UpdateWarehouseBodyParameter
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

public class UpdateWarehouseResponseMessage
{
    public int code { get; set; }
    public string message { get; set; }
    public data data { get; set; }
}

/****************************************/
// 반품지 생성 API
public class ReWarehouseBody
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

// ReponseMeesage
public class ReWarehouseMessageofCreating
{
    public int code { get; set; }
    public string message { get; set; }
    public data data { get; set; }
}

/************************************************/
// 반품지 목록 조회API

public class ReWarehouseQueryForGetting
{
    public int pageNum { get; set; }
    public int pageSize { get; set; }
}

public class ReWarehouseResponseMessage
{
    public int code { get; set; }
    public string message { get; set; }
    public List<MessageData> data { get; set; }

}

public class MessageData
{
    public string vendorId { get; set; }
    public string returnCenterCode { get; set; }
    public string shippingPlaceName { get; set; }
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

    public bool usable { get; set; }
    public List<placeAddresses> placeAddresses { get; set; }
}
/************************************************/
// 반품지 수정 API

public class ReWarehousePathForUpdating
{
    public string vendorId { get; set; }
    public int returnCenterCode { get; set; }
}

public class ReWarehouseBodyForUpdating
{
    public string vendorId { get; set; }
    public int returnCenterCode { get; set; }
    public string userId { get; set; }
    public string shippingPlaceName { get; set; }
    public bool usable { get; set; }
    public List<placeAddresses> placeAddresses { get; set; }
    public goodsflowInfoOpenApiDtoForUpdating GoodsflowInfoOpenApiDto { get; set; }
}

public class goodsflowInfoOpenApiDtoForUpdating
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

public class UpdateReWarehouseResponseMessage
{
    public int code { get; set; }
    public string message { get; set; }
    public data data { get; set; }
}

/*반품지 단건조회*/
