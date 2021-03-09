using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofCommodity.ofPost
{
    public class ResponseMessage
    {
        public int code { get; set; }
        public string message { get; set; }
        public long data { get; set; }  // 업체상품아이디 / 생성된 업체상품아이디
    }

}
