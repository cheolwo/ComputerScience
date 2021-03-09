using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofCategory.ofPost
{
    public class ResponseMessage
    {
        public int code { get; set; }
        public string message { get; set; }
        public data data { get; set; }
    }

    public class data
    {
        public string autoCategorizationPredictionResultType { get; set; }
        public string comment { get; set; }
        public string predictedCategoryId {get; set;}
        public string predictedCategoryName {get; set;}
    }

    /*
    HTTP 상태 코드(오류 유형)	오류 메시지	해결 방법
400 (요청변수확인)	
Input product name should not be empty!

상품명(productName) 입력이 누락되지 않았는지 확인합니다.
500 (서버오류)	Error occurred when communicating with seller_intelligence domain service. vendorId = A00123456, productName = ********  ..	추천 카테고리 예측 도중 오류가 발생했습니다. 일정시간 이후 재호출 하거나 입력 값을 수정합니다.
500 (서버오류)	Fail to communicate with the downstream domain services (catalog prediction service)	일정시간 이후 재호출 하거나 입력 값을 수정합니다.
500 (서버오류)	Fail to communicate with the listing domain to retrieve category name	일정시간 이후 재호출 하거나 입력 값을 수정합니다.
500 (서버오류)	Receive error message from the downstream domain services (catalog prediction service) 	일정시간 이후 재호출 하거나 입력값을 수정합니다. 
    */
}
