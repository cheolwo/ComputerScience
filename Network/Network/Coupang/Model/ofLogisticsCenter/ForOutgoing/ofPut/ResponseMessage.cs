using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofLogisticsCenter.ForOutgoing.ofPut
{
    public class ResponseMessage
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
}

/*
 * HTTP 상태 코드 (오류 유형)	오류 메시지	해결 방법
400 (요청변수확인)	Post code can't be empty	returnZipCode 값을 입력했는지 확인합니다.
400 (중복 입력)	
[출고지중복] 이미 등록된 주소지명이 있습니다 (중복 주소지 코드:2026xxxx)

동일한 returnAddress 값을 입력했는지 확인합니다.
400 (중복 입력)	[출고지중복] Duplicated request. name:주식회사xxxxx	동일한 shippingPlaceName 값을 입력했는지 확인합니다.
400 (요청변수확인)	배송비는 0원, 1000원 이상 20000원 이하만 가능합니다.	jeju, notJeju 값을 올바른 범위로 입력했는지 확인합니다. 도서산간배송비를 0 또는 최소 1,000원 이상 최대 20000원 이하로 입력합니다.
400 (요청변수확인)	The format of postal code is invalid, it can only be number	returnZipCode 값에 숫자가 아닌 문자를 입력했는지 확인합니다.
400 (요청변수확인)	params are not allowed null...	null 값을 입력했는지 확인합니다.
400 (요청변수확인)	params's vendorId not equals gateway's vendorId!	잘못된 vendorId를 입력했는지 확인합니다.
400 (요청변수확인)	The max length of the shipping place name is 50, please input the correct length name	shippingPlaceName 값이 50자 이상인지 확인합니다.
400 (요청변수확인)	The address detail info can't be null(placeAddress)	returnAddress 값을 입력했는지 확인합니다.
400 (요청변수확인)	Must input the default phone number(phoneNumber1)	phoneNumber1 값을 입력했는지 확인합니다.
400 (요청변수확인)	Must input the default address(address1)	returnAddress 값을 입력했는지 확인합니다.
400 (요청변수확인)	The length of country code is 2, please input correct length country code	올바른 countryCode 값을 입력했는지 확인합니다.
400 (요청변수확인)	The format of phone number is invalid, min length is 11 and max length is 14 include the character '-'	companyContactNumber 값을 올바른 형식으로 입력했는지 확인합니다. '-'를 포함하여 최소 11자 이상 최대 14자 이하로 입력합니다.
400 (요청변수확인)	The format of postal code is invalid, it can only be number, min length is 5 and max length is 6	returnZipCode 값을 올바르게 입력했는지 확인합니다. 숫자로만 최소 5, 최대 6자 이하로 입력합니다.
 */
