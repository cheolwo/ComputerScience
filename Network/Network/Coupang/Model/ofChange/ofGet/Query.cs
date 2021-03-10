using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofChange.ofGet
{
    // /v2/providers/openapi/apis/api/v4/vendors/{vendorId}/exchangeRequests
    public class Query
    {
        public string createdAtFrom { get; set; }
        public string createdAtTo {get; set;}
        public string status {get; set;}
        public string nextToken {get; set;} // 다음 페이지 조회를 위한 토큰값
        public long orderId {get; set;} // orderId
        public int maxPerPage {get; set;}
    }
}
