using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofSettlement.ofPut
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
